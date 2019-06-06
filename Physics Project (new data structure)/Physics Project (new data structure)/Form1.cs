using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Physics_Project__new_data_structure_
{
    public partial class Form1 : Form
    {
        Sensor_Manager sensor_Manager;
        List<Window_Grapher> Graphers = new List<Window_Grapher>();
        bool cd = false; // "Collecting Data"


        public Form1()
        {
            InitializeComponent();

            Init_ArduinoSystem();
            Init_Sensor_Manager();


            // Create fake data
            float[] tempFloatArr1 = new float[8] { -12, -2, 3, 4.6f, 9.1f, 13, 15.3f, 50 };
            float[] tempFloatArr2 = new float[8] { 0, -2, 3, 2.4f, 9.1f, 4, 2.7f, -50 };
            float[] tempFloatArr3 = new float[8] { -3, -1, 4, 9, 15.1f, 20, 24, 61 };
            float[] tempFloatArr4 = new float[8] { 0, -2, 3, 2.4f, 9.1f, 4, 2.7f, 3 };


            RunData fakeRun = new RunData();

            DataList fakeDataList = new DataList("Fakex1_Y", "Fake1_X");

            for (int i = 0; i < tempFloatArr1.Length; i++)
                fakeDataList.Add_Data(tempFloatArr2[i], tempFloatArr1[i]);
            fakeRun.AllData.Add(fakeDataList);

            fakeDataList = new DataList("Fakex2_Y", "Fake2_X");

            for (int i = 0; i < tempFloatArr1.Length; i++)
                fakeDataList.Add_Data(tempFloatArr4[i], tempFloatArr3[i]);
            fakeRun.AllData.Add(fakeDataList);

            GlobalData.All_Runs.Add(fakeRun);
        }


        public void Init_ArduinoSystem()
        {
            GlobalData.ArduinoSystem = new ArduinoSystem();

            if (arduinoSystem_Control.AutoDetect)
            {
                if (!GlobalData.ArduinoSystem.HasPort)
                {
                    arduinoSystem_Control.Connected = false;
                    MessageBox.Show("Please connect the arduino.");
                }
                else
                {
                    arduinoSystem_Control.Connected = true;
                    MessageBox.Show("The system is connected to: " + GlobalData.ArduinoSystem.GetPortName());
                }
            }

        }
        public void Init_Sensor_Manager()
        {
            sensor_Manager = new Sensor_Manager();
            sensor_Manager.Show();
        }




        private void arduinoSystem_Control_button_Click(object sender, EventArgs e)
        {
            Init_ArduinoSystem();
        }

        private void startBU_Click(object sender, EventArgs e)
        {
            GlobalData.ArduinoSystem.ClearBuffer();

            if (!GlobalData.ArduinoSystem.HasPort)
            {
                GlobalData.ArduinoSystem = new ArduinoSystem();

                if (!GlobalData.ArduinoSystem.HasPort)
                {
                    MessageBox.Show("Please connect the arduino.");
                    return;
                }
            }

            if (!sensor_Manager.ChangesApplied)
            {
                MessageBox.Show("Please apply the changes in the Sensor Manager.");
                return;
            }


            cd = true; // cd = "Collecting Data"

            startBU.Enabled = false;
            stopBU.Enabled = true;

            NewRun();
        }


        public void NewRun()
        {

            //tempGrapher.RealTimeMode = true;

            int updateInterval = 2;
            int sensorNum = 0;
            foreach (Sensor sensor in sensor_Manager.Sensors)
                if (sensor.Type != 0)
                    sensorNum++;

            updateInterval *= sensorNum;
;


            BackgroundWorker bgw = new BackgroundWorker();
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.ProgressChanged += Bgw_ProgressChanged;
            bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw.DoWork += (obj, ea) => DataCollectLoop(GlobalData.ArduinoSystem, GlobalData.Next_RunData, sensor_Manager.Sensors, bgw, updateInterval);
            bgw.RunWorkerAsync();
        }

        private void DataCollectLoop(ArduinoSystem ars, RunData ret, Sensor[] sensors, BackgroundWorker bgw, int updateEvery = 2)
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

                    switch (sensors[sensorIndex].Type)
                    {
                        case 1:
                            data *= 0.017f;
                            break;


                        default:
                            break;
                    }

                    ret.AllData[sensors[sensorIndex].RunData_Index].Value_Y.Add_Value(data);
                    ret.AllData[sensors[sensorIndex].RunData_Index].Value_X.Add_Value(time / 1000);


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

            GlobalData.All_Runs.Add(GlobalData.Next_RunData);
            GlobalData.Next_RunData = new RunData();
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            foreach (Window_Grapher gr in Graphers)
                gr.Update2();
            //tempGrapher.Update2();
            //tempTable.Update2();
        }
        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //tempGrapher.RealTimeMode = false;
            //tempGrapher.Update2();
            //tempTable.Update2();
        }

        private void openGrapherBU_Click(object sender, EventArgs e)
        {
            Window_Grapher w_g = new Window_Grapher();
            Graphers.Add(w_g);
            w_g.Show();
        }

        private void openTableBU_Click(object sender, EventArgs e)
        {
            Window_Table w_t = new Window_Table();
            w_t.Show();
        }

        private void openDataManagerBU_Click(object sender, EventArgs e)
        {
            DataManager dm = new DataManager();
            dm.Show();
        }

        private void stopBU_Click(object sender, EventArgs e)
        {
            cd = false;
            startBU.Enabled = true;
            stopBU.Enabled = false;
        }
    }
}
