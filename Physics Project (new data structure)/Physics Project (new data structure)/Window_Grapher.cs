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
    public partial class Window_Grapher : Form
    {
        public Window_Grapher()
        {
            InitializeComponent();
        }

        public void Update2()
        {
            grapher.Update2();
        }

        private void addBU_Click(object sender, EventArgs e)
        {
            NamedList_Selecter nl_s = new NamedList_Selecter();
            nl_s.ShowDialog();

            if (nl_s.HasSelectedLists)
            {
                DataList temp_dl = new DataList();
                temp_dl.Value_Y = nl_s.Selected_NamedList_Y;
                temp_dl.Value_X = nl_s.Selected_NamedList_X;
                grapher.Add_DataList(temp_dl);
                grapher.Update2();
            }
        }


    }

}
