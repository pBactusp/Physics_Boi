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
        public string Name;
        public NamedList vert;
        public NamedList hori;
        public DataSet DataSet;


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
                int before = (int)beforeNUPDO.Value,
                    after = (int)afterNUPDO.Value;


                DataSet = new DataSet();
                DataSet.Name = nameTEBO.Text;
                DataSet.Polynoms = new List<Polynom>();
                DataSet.DataX = new NamedList(hori.Name + " Smoothed(-" + before + ", +" + after + ")");
                DataSet.DataY = new NamedList(vert.Name + " Smoothed(-" + before + ", +" + after + ")");

                float avgX, avgY;

                for (int i = before; i < hori.Count - after; i++)
                {
                    avgX = 0;
                    avgY = 0;
                    if (before + 0 != 0)
                    {
                        for (int g = i - before; g < i + after; g++)
                        {
                            avgX += hori[g];
                            avgY += vert[g];
                        }

                        avgX /= (before + after);
                        avgY /= (before + after);

                        DataSet.DataX.Add(avgX);
                        DataSet.DataY.Add(avgY);
                    }
                    else
                    {
                        DataSet.DataX.Add(hori[i]);
                        DataSet.DataY.Add(vert[i]);
                    }

                    
                }


                Close();
            }
            else
            {
                MessageBox.Show("Please select data");
            }
        }
    }
}
