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
    public partial class ArduinoSystem_Control : UserControl
    {
        public bool AutoDetect
        {
            get { return autoDetectSystemCHBO.Checked; }
            set { autoDetectSystemCHBO.Checked = value; }
        }
        public bool Connected
        {
            get { return systemConnectedCHBO.Checked; }
            set { systemConnectedCHBO.Checked = value; }
        }

        public event EventHandler button_Click = delegate { };

        public ArduinoSystem_Control()
        {
            InitializeComponent();
        }

        private void detectSystemBU_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

    }
}
