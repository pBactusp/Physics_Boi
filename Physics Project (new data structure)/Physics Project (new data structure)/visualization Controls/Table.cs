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
    public partial class Table : UserControl
    {
        DataTable dataTable;
        List<NamedList> NamedLists;
        List<int> lastIndex;
        int longestList;


        public Table()
        {
            InitializeComponent();

            dataTable = new DataTable();
            displayGRVE.DataSource = dataTable;


            NamedLists = new List<NamedList>();
            lastIndex = new List<int>();
        }


        public void Add_NamedList(NamedList namedList)
        {
            NamedLists.Add(namedList);
            lastIndex.Add(0);

            if (namedList.Count > longestList)
                longestList = namedList.Count;

            Update2();
        }
        public void Remove_NamedList(NamedList namedList)
        {
            NamedLists.Remove(namedList);
            Find_LongestList();
            Update2();
        }
        public void RemoveAt_NamedList(int index)
        {
            NamedLists.RemoveAt(index);
            Find_LongestList();
            Update2();
        }


        private void Find_LongestList()
        {
            longestList = 0;

            foreach (NamedList nl in NamedLists)
                if (nl.Count > longestList)
                    longestList = nl.Count;
        }


        public void Update2()
        {
            dataTable.Clear();

            object[] tempRowValues = new object[NamedLists.Count];

            for (int i = dataTable.Columns.Count; i < NamedLists.Count; i++)
            {
                if (dataTable.Columns.Contains(NamedLists[i].Name))
                    dataTable.Columns.Add(NamedLists[i].Name + " 2#");
                else
                    dataTable.Columns.Add(NamedLists[i].Name);

            }

            for (int i = dataTable.Rows.Count; i < longestList; i++)
            {
                for (int g = 0; g < NamedLists.Count; g++)
                    tempRowValues[g] = i < NamedLists[g].Count ? (object)NamedLists[g].Value[i] : null;

                dataTable.Rows.Add(tempRowValues);
            }


            displayGRVE.Refresh();
        }



    }
}
