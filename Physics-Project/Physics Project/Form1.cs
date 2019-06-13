using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Physics_Project
{
    public partial class mainForm : Form
    {
        ArduinoSystem arSystem;
        SensorSetup sensorSetup;

        Grapher tempGrapher;
        Table tempTable;

        BackgroundWorker bgw;
        bool cd = false; // Collecting Data


        public mainForm()
        {
            InitializeComponent();

            GlobalData.allRuns = new List<RunData>();

            arSystem = new ArduinoSystem();

            if (adsCB.Checked)
                if (!arSystem.HasPort)
                    MessageBox.Show("Please connect the arduino.");
                else
                {
                    systemConnectedCB.Checked = true;
                    MessageBox.Show("The system is connected to: " + arSystem.GetPortName());
                }

            sensorSetup = new SensorSetup(arSystem);
            sensorSetup.Show();

            float[] tempFloatArr1 = new float[8] { -12, -2, 3, 4.6f, 9.1f, 13, 15.3f, 50 };
            float[] tempFloatArr2 = new float[8] { 0, -2, 3, 2.4f, 9.1f, 4, 2.7f, -50 };
            float[] tempFloatArr3 = new float[8] { -3, -1, 4, 9, 15.1f, 20, 24, 61 };
            float[] tempFloatArr4 = new float[8] { 0, -2, 3, 2.4f, 9.1f, 4, 2.7f, 3 };


            RunData runData = new RunData();

            runData.AddDataList("Temporary List 1", tempFloatArr1);
            runData.AddDataList("Temporary List 2", tempFloatArr2);
            runData.AddDataList("Temporary List 3", tempFloatArr3);
            runData.AddDataList("Temporary List 4", tempFloatArr4);

            float[] xsquared1 = new float[200];
            float[] X1 = new float[200];

            for (int x = -100; x < 100; x++)
            {
                X1[x + 100] = x;
                xsquared1[x + 100] = -(float)Math.Pow(x, 2);
            }
            NamedList X = new NamedList("x", X1);
            NamedList xSquared = new NamedList("y", xsquared1);
            runData.AddDataList(X);
            runData.AddDataList(xSquared);


            GlobalData.allRuns.Add(runData);

            #region Visualize fake initial data

            //tempAllRunsTreeView = new AllRunsTreeView(allRuns);


            /*Table tempTable = new Table();
            tempTable.DisplayData(runData);
            tempTable.Show();*/



            tempGrapher = new Grapher();
            tempGrapher.Update2();
            /*tempGrapher.AddDataSet(runData.AllData[0], runData.AllData[1]);
            tempGrapher.AddDataSet(runData.AllData[2], runData.AllData[3]);
            tempGrapher.Update2();*/
            tempGrapher.Show();

            tempTable = new Table();
            //tempTable.AddColumn(runData.AllData[0]);
            //tempTable.AddColumn(runData.AllData[1]);
            //tempTable.AddColumn(runData.AllData[2]);
            //tempTable.AddColumn(runData.AllData[3]);
            tempTable.Show();


            //AllRunsTreeView tempARTV = new AllRunsTreeView();
            //tempARTV.Show();


            #endregion


        }


        private void startB_Click(object sender, EventArgs e)
        {
            arSystem.ClearBuffer();

            if (!arSystem.HasPort)
            {
                arSystem = new ArduinoSystem();

                if (!arSystem.HasPort)
                {
                    MessageBox.Show("Please connect the arduino.");
                    return;
                }
            }


            for (int i = 0; i < sensorSetup.Sensors.Length; i++)
            {
                if (sensorSetup.Sensors[i].Type != 0)
                {
                    string s = "sensor," + sensorSetup.Sensors[i].Type + "," + i + "," + sensorSetup.Sensors[i].SampleRate;
                    arSystem.SendCommand(s);
                }
            }

            //string str = arSystem.ReadLine();

            cd = true; // cd = "Collecting Data"

            startB.Enabled = false;
            stopB.Enabled = true;

            NewRun_Better(arSystem);
        }


        #region Get data from arduino
        static float runTime;


        public static void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            runTime += 0.01f;
        }


        public NamedList Get_V(NamedList x, NamedList t)
        {
            NamedList v = new NamedList("Velocity");
            for (int i = 0; i < x.Count - 1; i++)
                v.Add((x[i + 1] - x[i]) / (t[i + 1] - t[i]));

            return v;
        }
        public NamedList Get_VCheat(NamedList x, NamedList t)
        {
            NamedList v = new NamedList("VelocityCheat");
            for (int i = 1; i < x.Count - 2; i++)
                v.Add(((x[i] + x[i + 2]) / 2 - (x[i + 1] + x[i - 1]) / 2) / ((t[i] + t[i + 2]) / 2 - (t[i + 1] + t[i - 1]) / 2));
            return v;
        }


        public void NewRun_Better(ArduinoSystem ars)
        {
            runTime = 0;

            RunData ret = new RunData();
            GlobalData.allRuns.Add(ret);

            ret.Index = GlobalData.allRuns.Count;

            foreach (Sensor sensor in sensorSetup.Sensors)
            {
                ret.AddDataList(new NamedList("Time (s)" + ret.Index.ToString()));
                ret.AddDataList(new NamedList(GlobalData.DataNames[sensor.Type] + " (" + GlobalData.MeasurmentsNames[sensor.Type][sensor.Measurement] + ")" + ret.Index.ToString()));

                if (sensor.Type != 0)
                    tempGrapher.AddDataSet(ret.AllData[ret.AllData.Count - 2], ret.AllData[ret.AllData.Count - 1]);

                //tempTable.AddColumn(ret.AllData[ret.AllData.Count - 2]);
                //tempTable.AddColumn(ret.AllData[ret.AllData.Count - 1]);

            }

            //tempGrapher.RealTimeMode = true;

            int updateInterval = 2;
            int sensorNum = 0;
            foreach (Sensor sensor in sensorSetup.Sensors)
                if (sensor.Type != 0)
                    sensorNum++;

            updateInterval *= sensorNum;

            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 10;
            t.Elapsed += T_Elapsed;


            bgw = new BackgroundWorker();
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.ProgressChanged += Bgw_ProgressChanged;
            bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw.DoWork += (obj, ea) => DataCollectLoop_Better(arSystem, ret, sensorSetup.Sensors, updateInterval);
            bgw.RunWorkerAsync();
        }

        private void DataCollectLoop_Better(ArduinoSystem ars, RunData ret, Sensor[] sensors, int updateEvery = 2)
        {
            int updateIndex = 0;


            ars.SendCommand("start");
            ars.ClearBuffer();

            //Thread.Sleep(500);
            //string s = ars.ReadLine();

            int sensorIndex = -1;
            float data = 0, time = 0;
            while (cd)
            {
                if (ars.HasData)
                {
                    ars.ReadPort_TimeAndData(ref sensorIndex, ref data, ref time);

                    switch (sensorSetup.Sensors[sensorIndex / 2].Type)
                    {
                        case 1:
                            data *= 0.017f;
                            break;


                        default:
                            break;
                    }

                    ret.AllData[sensorIndex].Add(time / 1000);
                    ret.AllData[sensorIndex + 1].Add(data);


                    updateIndex++;
                    if (updateIndex >= updateEvery)
                    {
                        updateIndex = 0;

                        bgw.ReportProgress(0);
                    }

                }
            }


            ars.SendCommand("stop");
            ars.ClearBuffer();

            for (int i = sensors.Length - 1; i >= 0; i--)
                if (sensors[i].Type == 0)
                {
                    ret.AllData.Remove(ret.AllData[i * 2 + 1]);
                    ret.AllData.Remove(ret.AllData[i * 2]);
                }


        }





        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tempGrapher.Update2();
            //tempTable.Update2();
        }
        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tempGrapher.RealTimeMode = false;
            tempGrapher.Update2();
            //tempTable.Update2();
        }
        #endregion

        private void pauseB_Click(object sender, EventArgs e)
        {

        }
        private void stopB_Click(object sender, EventArgs e)
        {
            cd = false;
            startB.Enabled = true;
            stopB.Enabled = false;
        }


        private void detectARSystemB_Click(object sender, EventArgs e)
        {
            arSystem = new ArduinoSystem();
            if (!arSystem.HasPort)
            {
                MessageBox.Show("Please connect the arduino.");
                systemConnectedCB.Checked = false;
            }
            else
            {
                systemConnectedCB.Checked = true;
                MessageBox.Show("The system is connected to: " + arSystem.GetPortName());
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
