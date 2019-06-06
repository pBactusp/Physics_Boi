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
    public partial class AllRuns_Control : UserControl
    {
        public TreeNode Selected_TreeNode = null;
        public bool Show_NamedLists = false;

        public event EventHandler Node_MouseDoubleClick = delegate { };


        public AllRuns_Control()
        {
            InitializeComponent();

            Update2();
        }


        //private TreeNode CreateChildren(DataList dl)
        //{
        //    TreeNode allRunsNode = new TreeNode(name);

        //}


        private TreeNode MakeTree(DataList dataList)
        {
            TreeNode DataListNode = new TreeNode(dataList.Get_FullName());
            DataListNode.Tag = dataList;

            if (Show_NamedLists)
            {
                DataListNode.Nodes.Add(dataList.Value_Y.Name);
                DataListNode.Nodes[DataListNode.Nodes.Count - 1].Tag = dataList.Value_Y;
                DataListNode.Nodes.Add(dataList.Value_X.Name);
                DataListNode.Nodes[DataListNode.Nodes.Count - 1].Tag = dataList.Value_X;
            }

            foreach (Variable variable in dataList.Children)
            {
                DataListNode.Nodes.Add(MakeTree(variable));
                DataListNode.Nodes[DataListNode.Nodes.Count - 1].Tag = variable;
            }

            return DataListNode;
        }

        public void Update2()
        {
            mainTV.Nodes.Clear();

            TreeNode allRunsNode = new TreeNode("All Runs");
            for (int i = 0; i < GlobalData.All_Runs.Count; i++)
            {
                TreeNode tempTreeNode = new TreeNode("Run " + i + "#");
                foreach (DataList dataList in GlobalData.All_Runs[i].AllData)
                    tempTreeNode.Nodes.Add(MakeTree(dataList));
                //{
                //    TreeNode DataListNode = new TreeNode(dataList.Get_FullName());
                //    foreach (Variable variable in dataList.Children)
                //        DataListNode.Nodes.Add(variable.Get_FullName());

                    

                //    tempTreeNode.Nodes.Add(DataListNode);
                //}

                allRunsNode.Nodes.Add(tempTreeNode);
            }
            mainTV.Nodes.Add(allRunsNode);

            TreeNode nextRunNode = new TreeNode("Next Run");
            foreach (DataList dataList in GlobalData.Next_RunData.AllData)
            {
                TreeNode DataListNode = new TreeNode(dataList.Get_FullName());
                foreach (Variable variable in dataList.Children)
                    DataListNode.Nodes.Add(variable.Get_FullName());

                nextRunNode.Nodes.Add(DataListNode);
            }
            mainTV.Nodes.Add(nextRunNode);
        }

        private void mainTV_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Selected_TreeNode = e.Node;
            Node_MouseDoubleClick(sender, e);
        }

        private void mainTV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Selected_TreeNode = e.Node;
        }
    }


}
