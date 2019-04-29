using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Physics_Project
{
    public partial class SensorSetup : Form
    {
        public Sensor[] Sensors = new Sensor[6];
        float divisionDistance { get { return selectionPA.Width / Sensors.Length; } }
        ArduinoSystem ars;

        Bitmap bm;
        Graphics bmGraphics;

        int selectedDivision = 0;

        public SensorSetup(ArduinoSystem arduino_system)
        {
            InitializeComponent();

            ars = arduino_system;
            for (int i = 0; i < Sensors.Length; i++)
                Sensors[i] = new Sensor(0, i);


            bm = new Bitmap(selectionPA.Width, selectionPA.Height);
            selectionPA.BackgroundImage = bm;


            bmGraphics = Graphics.FromImage(bm);
            DrawDivisions(bmGraphics);



            sensorTypeLIBO.Items.AddRange(GlobalData.SensorTypes);
            sensorTypeLIBO.SelectedIndex = Sensors[selectedDivision].Type;

        }



        public void DrawDivisions(Graphics g)
        {
            g.Clear(GlobalData.ClearColor);

            g.FillEllipse(new SolidBrush(Color.Yellow), selectedDivision * divisionDistance, 0, divisionDistance, selectionPA.Height);

            for (int i = 1; i < Sensors.Length; i++)
                g.DrawLine(Pens.Black, divisionDistance * i, 0, divisionDistance * i, selectionPA.Height);

            selectionPA.Refresh();

            tabsTACO.Controls.Clear();
            tabsTACO.Controls.Add(CreateMeasurmantsTabPage());
        }

        public TabPage CreateMeasurmantsTabPage()
        {
            int index_y = 5;
            TabPage ret = new TabPage("Measurements");

            Label tempLabel = new Label();
            tempLabel.Text = GlobalData.DataNames[Sensors[selectedDivision].Type];
            tempLabel.Location = new Point(5, index_y);

            ComboBox tempCOBO = new ComboBox();
            foreach (string s in GlobalData.MeasurmentsNames[Sensors[selectedDivision].Type])
                tempCOBO.Items.Add(s);
            tempCOBO.SelectedIndex = 0;
            tempCOBO.Location = new Point(tempLabel.Size.Width + 5, index_y);
            tempCOBO.SelectedIndexChanged += TempCOBO_SelectedIndexChanged;


            ret.Controls.Add(tempLabel);
            ret.Controls.Add(tempCOBO);


            index_y = tempCOBO.Size.Height + 5;

            Label freqLabel = new Label();
            freqLabel.Text = "Frequency";
            freqLabel.Location = new Point(5, index_y);

            TextBox tempTEBO = new TextBox();
            tempTEBO.Text = Sensors[selectedDivision].SampleRate.ToString();
            tempTEBO.Location = new Point(freqLabel.Size.Width + 5, index_y);
            tempTEBO.TextChanged += TempTEBO_TextChanged;

            
            ret.Controls.Add(freqLabel);
            ret.Controls.Add(tempTEBO);

            return ret;
        }

        private void TempTEBO_TextChanged(object sender, EventArgs e)
        {
            TextBox tempTEBO = (TextBox)sender;
            if (float.TryParse(tempTEBO.Text, out float parsed))
                Sensors[selectedDivision].SampleRate = float.Parse(tempTEBO.Text);
            else if (tempTEBO.Text != "")
                tempTEBO.Text = Sensors[selectedDivision].SampleRate.ToString();
        }

        private void TempCOBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox tempCOBO = (ComboBox)sender;
            Sensors[selectedDivision].Measurement = tempCOBO.SelectedIndex;
        }

        private void selectionPA_MouseClick(object sender, MouseEventArgs e)
        {
            selectedDivision = (int)(e.X / divisionDistance);

            DrawDivisions(bmGraphics);
            sensorTypeLIBO.SelectedIndex = Sensors[selectedDivision].Type;

            //MessageBox.Show(selectedDivision.ToString());
        }

        private void sensorTypeLIBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sensors[selectedDivision].SetType(sensorTypeLIBO.SelectedIndex);
            DrawDivisions(bmGraphics);
            //MessageBox.Show(Sensors[selectedDivision].Type.ToString());
        }



    }
}
