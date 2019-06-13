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
    public partial class DataList_Selecter : Form
    {
        public DataList Selected_DataList;
        public NamedList Selected_NamedList;

        public bool DataListIsSelected = false;


        public DataList_Selecter()
        {
            InitializeComponent();

            allRuns_Control.Node_MouseDoubleClick += AllRuns_Control_Node_MouseDoubleClick;

            allRuns_Control.Show_NamedLists = showNamedListCHEBO.Checked;
            Selected_NamedList = null;
            allRuns_Control.Update2();
        }


        private void AllRuns_Control_Node_MouseDoubleClick(object sender, EventArgs e)
        {
            if (allRuns_Control.Selected_TreeNode.Tag != null)
            {
                if (allRuns_Control.Selected_TreeNode.Tag.GetType().Name == "NamedList")
                {
                    Selected_NamedList = (NamedList)allRuns_Control.Selected_TreeNode.Tag;
                    Selected_DataList = (DataList)allRuns_Control.Selected_TreeNode.Parent.Tag;

                    DataListIsSelected = true;
                }
                else if (allRuns_Control.Selected_TreeNode.Tag.GetType().Name == "DataList" ||
                    allRuns_Control.Selected_TreeNode.Tag.GetType().Name == "Variable")
                {
                    Selected_NamedList = null;
                    Selected_DataList = (DataList)allRuns_Control.Selected_TreeNode.Tag;

                    DataListIsSelected = true;
                }
                else
                    DataListIsSelected = false;
            }
            else
                DataListIsSelected = false;


            /*
            TreeNode root_parent = allRuns_Control.Selected_TreeNode;
            List<int> indexes = new List<int>();

            while (root_parent.Parent != null)
            {
                indexes.Insert(0, root_parent.Index);
                root_parent = root_parent.Parent;
            }
            indexes.Insert(0, root_parent.Index);


            if (indexes[0] == 0)
            {
                if (indexes.Count > 2)
                {
                    Selected_DataList = GlobalData.All_Runs[indexes[1]].AllData[indexes[2]];

                    int i = 3;
                    while (i < indexes.Count)
                    {
                        Selected_DataList = Selected_DataList.Children[indexes[i]];
                        i++;
                    }

                    DataListIsSelected = true;
                }
            }
            else if (indexes[0] == 1)
            {
                if (indexes.Count > 1)
                {
                    Selected_DataList = GlobalData.Next_RunData.AllData[indexes[1]];

                    int i = 2;
                    while (i < indexes.Count)
                    {
                        Selected_DataList = Selected_DataList.Children[indexes[i]];
                        i++;
                    }

                    DataListIsSelected = true;
                }
            }
            */
            if (DataListIsSelected)
                Close();

        }

        private void selectBU_Click(object sender, EventArgs e)
        {
            if (allRuns_Control.Selected_TreeNode.Tag != null)
            {
                if (allRuns_Control.Selected_TreeNode.Tag.GetType().Name == "NamedList")
                {
                    Selected_NamedList = (NamedList)allRuns_Control.Selected_TreeNode.Tag;
                    Selected_DataList = (DataList)allRuns_Control.Selected_TreeNode.Parent.Tag;

                    DataListIsSelected = true;
                }
                else if (allRuns_Control.Selected_TreeNode.Tag.GetType().Name == "DataList" ||
                    allRuns_Control.Selected_TreeNode.Tag.GetType().Name == "Variable")
                {
                    Selected_NamedList = null;
                    Selected_DataList = (DataList)allRuns_Control.Selected_TreeNode.Tag;

                    DataListIsSelected = true;
                }
                else
                    DataListIsSelected = false;
            }
            else
                DataListIsSelected = false;

            if (DataListIsSelected)
                Close();
        }

        private void cancelBU_Click(object sender, EventArgs e)
        {
            DataListIsSelected = false;
            Close();
        }

        private void showNamedListCHEBO_CheckedChanged(object sender, EventArgs e)
        {
            allRuns_Control.Show_NamedLists = showNamedListCHEBO.Checked;
            Selected_NamedList = null;
            allRuns_Control.Update2();
        }
    }
}
