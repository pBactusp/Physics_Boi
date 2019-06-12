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
    public partial class Sensor_Manager : Form
    {
        public Sensor[] Sensors = new Sensor[6];

        public bool IsShown;
        public bool ChangesApplied = false;

        private int selectedDivision = 0;
        private float divisionDistance { get { return selectionPA.Width / Sensors.Length; } }
        private Bitmap bm;
        private Graphics bmGraphics;


        public Sensor_Manager()
        {
            InitializeComponent();

            Clear_Sensors();

            bm = new Bitmap(selectionPA.Width, selectionPA.Height);
            bmGraphics = Graphics.FromImage(bm);
            selectionPA.BackgroundImage = bm;

            DrawDivisions(bmGraphics);

            sensorTypeLIBO.Items.AddRange(GlobalData.SensorTypes);
            sensorTypeLIBO.SelectedIndex = Sensors[selectedDivision].Type;

            sensorProperties_Control.Set(Sensors[selectedDivision]);
        }


        public void Clear_Sensors()
        {
            for (int i = 0; i < Sensors.Length; i++)
                Sensors[i] = new Sensor(0, i);
        }

        public void ApplyChanges()
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

            GlobalData.Next_RunData.AllData.Clear();

            int index = 0;
            for (int i = 0; i < Sensors.Length; i++)
                if (Sensors[i].Type != 0)
                {
                    Sensors[i].RunData_Index = index;
                    DataList tempDataList = new DataList(GlobalData.DataNames[Sensors[i].Type] + " (" + GlobalData.MeasurmentsNames[Sensors[i].Type][Sensors[i].Units] + ")", "Time (s)");
                    GlobalData.Next_RunData.AllData.Add(tempDataList);
                    string s = "sensor," + Sensors[i].Type + "," + i + "," + Sensors[i].SampleRate;
                    GlobalData.ArduinoSystem.SendCommand(s);

                    index++;
                }


            ChangesApplied = true;
            applyBU.Enabled = false;
        }

        private void DrawDivisions(Graphics g)
        {
            g.Clear(GlobalData.ClearColor);


            g.FillRectangle(new SolidBrush(Color.Blue), divisionDistance * selectedDivision, 0, divisionDistance, selectionPA.Height);

            Size targetSize = new Size((int)divisionDistance, selectionPA.Height);
            for (int i = 0; i < Sensors.Length; i++)
            {
                g.DrawImage(Get_Scaled(GlobalData.SensorImages[Sensors[i].Type], targetSize), new PointF(i * divisionDistance, 0));
                g.DrawLine(Pens.Black, divisionDistance * i, 0, divisionDistance * i, selectionPA.Height);
            }

            selectionPA.Refresh();

            //tabsTACO.Controls.Clear();
            //tabsTACO.Controls.Add(CreateMeasurmantsTabPage());
        }

        private Bitmap Get_Scaled(Bitmap bitmap, Size size)
        {
            float scale = Math.Min((float)size.Width / (float)bitmap.Width, (float)size.Height / (float)bitmap.Height);

            return new Bitmap(bitmap, (int)(bitmap.Width * scale), (int)(bitmap.Height * scale));
        }


        private void selectionPA_MouseClick(object sender, MouseEventArgs e)
        {
            selectedDivision = (int)(e.X / divisionDistance);

            DrawDivisions(bmGraphics);
            sensorTypeLIBO.SelectedIndex = Sensors[selectedDivision].Type;
        }

        private void sensorTypeLIBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sensors[selectedDivision] = new Sensor(sensorTypeLIBO.SelectedIndex, selectedDivision);
            DrawDivisions(bmGraphics);
            sensorProperties_Control.Set(Sensors[selectedDivision]);

            ChangesApplied = false;
            applyBU.Enabled = true;
        }


        private void sensorProperties_Control_Unit_Changed(object sender, EventArgs e)
        {
            Sensors[selectedDivision].Units = (int)sender;
            ChangesApplied = false;
            applyBU.Enabled = true;
        }

        private void sensorProperties_Control_Frequency_Changed(object sender, EventArgs e)
        {
            Sensors[selectedDivision].SampleRate = (float)sender;
            ChangesApplied = false;
            applyBU.Enabled = true;
        }

        private void applyBU_Click(object sender, EventArgs e)
        {
            if (GlobalData.ArduinoSystem != null &&
                GlobalData.ArduinoSystem.HasPort)
                ApplyChanges();
            else
            {
                GlobalData.ArduinoSystem = new ArduinoSystem();

                if (!GlobalData.ArduinoSystem.HasPort)
                    MessageBox.Show("Please connect the arduino.");
            }
        }

        private void Sensor_Manager_Shown(object sender, EventArgs e)
        {
            IsShown = true;
        }
        private void Sensor_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsShown = false;
            Hide();
            e.Cancel = true;
        }


    }





    public class Sensor
    {
        int _Type;
        public int Type { get { return _Type; } }
        public int ConnectionNumber;
        public int Units;
        public float SampleRate;

        public int RunData_Index;

        public Sensor(int type, int connection_num)
        {
            _Type = type;
            ConnectionNumber = connection_num;
            Units = 0;
            SampleRate = GlobalData.RecommendedFrequency[Type];
        }


        public void SetType(int type)
        {
            _Type = type;
        }
    }
}
