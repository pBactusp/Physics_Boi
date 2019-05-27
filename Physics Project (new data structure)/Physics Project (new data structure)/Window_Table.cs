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
    public partial class Window_Table : Form
    {
        public Window_Table()
        {
            InitializeComponent();
        }

        private void addBU_Click(object sender, EventArgs e)
        {
            DataList_Selecter dl_s = new DataList_Selecter();
            dl_s.ShowDialog();

            if (dl_s.DataListIsSelected)
            {
                DataList temp_dl = dl_s.Selected_DataList;
                table.Add_NamedList(temp_dl.Value_Y);
                table.Add_NamedList(temp_dl.Value_X);
                table.Update2();
            }

        }


    }
}
