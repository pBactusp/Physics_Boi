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
    public partial class DatasetSelector : Form
    {
        AllRunsTreeView tv;
        public NamedList vert;
        public NamedList hori;



        public DatasetSelector()
        {
            InitializeComponent();
        }

        private void verticalBU_Click(object sender, EventArgs e)
        {
            tv = new AllRunsTreeView();
            tv.ShowDialog();
            if (tv.Selected_NamedList != null)
            {
                vert = tv.Selected_NamedList;
                verticalBU.Text = vert.Name;
            }

        }

        private void horizontalBU_Click(object sender, EventArgs e)
        {
            tv = new AllRunsTreeView();
            tv.ShowDialog();
            if (tv.Selected_NamedList != null)
            {
                hori = tv.Selected_NamedList;
                horizontalBU.Text = hori.Name;
            }

        }


        private void selectBU_Click(object sender, EventArgs e)
        {
            if (vert != null && hori != null)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Please select data");
            }
        }
    }
}
