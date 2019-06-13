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
    public partial class ConstantList_Control : UserControl
    {
        public List<Constant> Constants;

        public ConstantList_Control()
        {
            InitializeComponent();
        }


        public void Update2()
        {
            mainLIBO.Items.Clear();

            int longest_name_length = 0;
            foreach (Constant constant in Constants)
                if (constant.Name.Length > longest_name_length)
                    longest_name_length = constant.Name.Length;

            string tempName;
            foreach (Constant constant in Constants)
            {
                tempName = constant.Name;
                for (int i = constant.Name.Length; i < longest_name_length; i++)
                    tempName += " ";
                tempName += " | " + constant.Value;

                mainLIBO.Items.Add(tempName);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainLIBO.SelectedIndex > 0 && mainLIBO.SelectedIndex < Constants.Count)
            {
                Constants.RemoveAt(mainLIBO.SelectedIndex);
                Update2();
            }
        }
    }
}
