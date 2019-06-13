using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Physics_Project__new_data_structure_
{
    public partial class SensorProperties_Control : UserControl
    {
        public event EventHandler Unit_Changed = delegate { };
        public event EventHandler Frequency_Changed = delegate { };


        public SensorProperties_Control()
        {
            InitializeComponent();
        }


        public void Set(Sensor sensor)
        {
            dataNameLA.Text = GlobalData.DataNames[sensor.Type];

            unitCOBO.Items.Clear();
            foreach (string s in GlobalData.MeasurmentsNames[sensor.Type])
                unitCOBO.Items.Add(s);
            unitCOBO.SelectedIndex = sensor.Units;

            frequencyNUPDO.Value = (decimal)sensor.SampleRate;
        }


        private void unitCOBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Unit_Changed(unitCOBO.SelectedIndex, e);
        }
        private void frequencyNUPDO_ValueChanged(object sender, EventArgs e)
        {
            Frequency_Changed((float)frequencyNUPDO.Value, e);
        }
    }
}
