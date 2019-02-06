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
    public partial class AllRunsTreeView : Form
    {
        public NamedList Selected_NamedList;

        public AllRunsTreeView()
        {
            InitializeComponent();
            Update2();
        }


        private void Update2()
        {
            tv.Nodes.Clear();

            TreeNode tempTreeNode;
            for (int i = 0; i < GlobalData.allRuns.Count; i++)
            {
                tempTreeNode = new TreeNode("Run #" + (i + 1).ToString());
                foreach (NamedList namedList in GlobalData.allRuns[i].AllData)
                    tempTreeNode.Nodes.Add(namedList.Name);

                tv.Nodes.Add(tempTreeNode);
            }
            tv.Update();
            tv.Refresh();
        }

        private void selectBU_Click(object sender, EventArgs e)
        {
            if (tv.SelectedNode.Parent != null)
            {
                Selected_NamedList = GlobalData.allRuns[tv.SelectedNode.Parent.Index].AllData[tv.SelectedNode.Index];
                Close();
            }

        }

        private void tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (tv.SelectedNode.Parent != null)
            {
                Selected_NamedList = GlobalData.allRuns[tv.SelectedNode.Parent.Index].AllData[tv.SelectedNode.Index];
                Close();
            }

        }
    }
}
