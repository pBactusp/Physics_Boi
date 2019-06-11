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
    public partial class Winow_OpenProject : Form
    {
        public ProjectFile projectFile;


        public Winow_OpenProject()
        {
            InitializeComponent();
            projectFile = new ProjectFile();
        }

        private void newProBU_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = "txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                projectFile.SaveAs(sfd.FileName);
                Close();
            }
        }

        private void cancelBU_Click(object sender, EventArgs e)
        {
            projectFile = null;
            Close();
        }
    }

}
