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
    public partial class NamedList_Selecter : Form
    {
        public NamedList Selected_NamedList_Y;
        public NamedList Selected_NamedList_X;

        public bool HasSelectedLists;

        public NamedList_Selecter()
        {
            InitializeComponent();
        }

        private void yBU_Click(object sender, EventArgs e)
        {
            DataList_Selecter dl_s = new DataList_Selecter();
            dl_s.ShowDialog();

            if (dl_s.DataListIsSelected)
            {
                if (dl_s.Selected_NamedList != null)
                {
                    Selected_NamedList_Y = dl_s.Selected_NamedList;
                    yBU.Text = Selected_NamedList_Y.Name;
                }
                else
                {
                    Selected_NamedList_Y = dl_s.Selected_DataList.Value_Y;
                    Selected_NamedList_X = dl_s.Selected_DataList.Value_X;

                    yBU.Text = Selected_NamedList_Y.Name;
                    xBU.Text = Selected_NamedList_X.Name;
                }
            }

        }
        private void xBU_Click(object sender, EventArgs e)
        {
            DataList_Selecter dl_s = new DataList_Selecter();
            dl_s.ShowDialog();

            if (dl_s.DataListIsSelected)
            {
                if (dl_s.Selected_NamedList != null)
                {
                    Selected_NamedList_X = dl_s.Selected_NamedList;
                    xBU.Text = Selected_NamedList_X.Name;
                }
                else if (dl_s.DataListIsSelected)
                {
                    Selected_NamedList_Y = dl_s.Selected_DataList.Value_Y;
                    Selected_NamedList_X = dl_s.Selected_DataList.Value_X;

                    yBU.Text = Selected_NamedList_Y.Name;
                    xBU.Text = Selected_NamedList_X.Name;
                }
            }

        }


        private void selectBU_Click(object sender, EventArgs e)
        {
            if (Selected_NamedList_Y != null &&
                Selected_NamedList_X != null)
            {
                HasSelectedLists = true;
                Close();
            }
            else
            {
                HasSelectedLists = false;
                MessageBox.Show("Please select two valid lists.");
            }
        }

        private void cancelBU_Click(object sender, EventArgs e)
        {
            HasSelectedLists = false;
            Close();
        }
    }

}
