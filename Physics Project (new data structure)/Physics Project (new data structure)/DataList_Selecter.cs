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
        public bool DataListIsSelected = false;

        public DataList_Selecter()
        {
            InitializeComponent();

            allRuns_Control.Node_MouseDoubleClick += AllRuns_Control_Node_MouseDoubleClick;
        }

        private void AllRuns_Control_Node_MouseDoubleClick(object sender, EventArgs e)
        {
            if (allRuns_Control.Selected_TreeNode.Level == 1)
            {
                if (allRuns_Control.Selected_TreeNode.Parent.Index == 1)
                    Selected_DataList = GlobalData.Next_RunData.AllData[allRuns_Control.Selected_TreeNode.Index];
                DataListIsSelected = true;
            }
            else if (allRuns_Control.Selected_TreeNode.Level == 2)
            {
                if (allRuns_Control.Selected_TreeNode.Parent.Parent.Index == 0)
                    Selected_DataList = GlobalData.All_Runs[allRuns_Control.Selected_TreeNode.Parent.Index].AllData[allRuns_Control.Selected_TreeNode.Index];
                else if (allRuns_Control.Selected_TreeNode.Parent.Parent.Index == 1)
                    Selected_DataList = GlobalData.Next_RunData.AllData[allRuns_Control.Selected_TreeNode.Parent.Index].Children[allRuns_Control.Selected_TreeNode.Index];
                DataListIsSelected = true;
            }
            else if (allRuns_Control.Selected_TreeNode.Level == 3)
            {
                Selected_DataList = GlobalData.All_Runs[allRuns_Control.Selected_TreeNode.Parent.Parent.Index].AllData[allRuns_Control.Selected_TreeNode.Parent.Index].Children[allRuns_Control.Selected_TreeNode.Index];
                DataListIsSelected = true;
            }

            if (DataListIsSelected)
                Close();

        }

        private void selectBU_Click(object sender, EventArgs e)
        {
            if (allRuns_Control.Selected_TreeNode.Level == 1)
            {
                if (allRuns_Control.Selected_TreeNode.Parent.Index == 1)
                    Selected_DataList = GlobalData.Next_RunData.AllData[allRuns_Control.Selected_TreeNode.Index];
                DataListIsSelected = true;
            }
            else if (allRuns_Control.Selected_TreeNode.Level == 2)
            {
                if (allRuns_Control.Selected_TreeNode.Parent.Parent.Index == 0)
                    Selected_DataList = GlobalData.All_Runs[allRuns_Control.Selected_TreeNode.Parent.Index].AllData[allRuns_Control.Selected_TreeNode.Index];
                else if (allRuns_Control.Selected_TreeNode.Parent.Parent.Index == 1)
                    Selected_DataList = GlobalData.Next_RunData.AllData[allRuns_Control.Selected_TreeNode.Parent.Index].Children[allRuns_Control.Selected_TreeNode.Index];
                DataListIsSelected = true;
            }
            else if (allRuns_Control.Selected_TreeNode.Level == 3)
            {
                Selected_DataList = GlobalData.All_Runs[allRuns_Control.Selected_TreeNode.Parent.Parent.Index].AllData[allRuns_Control.Selected_TreeNode.Parent.Index].Children[allRuns_Control.Selected_TreeNode.Index];
                DataListIsSelected = true;
            }

            if (DataListIsSelected)
                Close();
        }

        private void cancelBU_Click(object sender, EventArgs e)
        {
            DataListIsSelected = false;
            Close();
        }
    }
}
