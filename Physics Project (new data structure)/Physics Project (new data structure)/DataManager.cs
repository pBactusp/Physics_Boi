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
    public partial class DataManager : Form
    {
        DataList_Selecter dl_s;
        DataList Parent = null;


        public DataManager()
        {
            InitializeComponent();

            constCOLICO.Constants = GlobalData.All_Constants;
            constCOLICO.Update2();
        }


        private string GetValidFunc(string input, out bool functionIsValid)
        {
            functionIsValid = true;

            string ret = "";

            short bracketsCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (input[i] == '[' || input[i] == '{' || input[i] == '(')
                    {
                        bracketsCounter++;
                        ret += '(';
                    }
                    else if (input[i] == ']' || input[i] == '}' || input[i] == ')')
                    {
                        bracketsCounter--;
                        ret += ')';
                    }
                    else if (Char.IsLetter(input[i]))
                    {
                        bool isConstant = false;
                        string tempName = "";
                        int g;
                        for (g = 0; g + i < input.Length; g++)
                            if (Char.IsLetter(input[g + i]))
                                tempName += Char.ToLower(input[g + i]);
                            else
                                break;
                        g--;

                        foreach (Constant constant in GlobalData.All_Constants)
                            if (constant.Name == tempName)
                            {
                                ret += constant.Value;
                                isConstant = true;
                                break;
                            }
                        if (!isConstant)
                            ret += tempName;

                        i += g;
                    }
                    else if (Char.IsNumber(input[i]))
                        ret += input[i];
                    else if (input[i] == '.')
                        ret += input[i];
                    else if (BinTreeCommand.Commands.Contains(input[i]))
                        ret += input[i];
                }
            }

            if (bracketsCounter > 0)
            {
                MessageBox.Show("')' Missing.");
                functionIsValid = false;
            }
            else if (bracketsCounter < 0)
            {
                MessageBox.Show("'(' Missing.");
                functionIsValid = false;
            }
            if (ret.Length == 0)
            {
                functionIsValid = false;
            }

            return ret;
        }


        private bool InputIsValid()
        {
            bool funcIsValid = true;

            string name = variableNameTEBO.Text;
            BinTreeNode<string> function = new BinTreeNode<string>("");
            function.SetInfo(GetValidFunc(variableFunctionTEBO.Text, out funcIsValid));


            if (variableNameTEBO.Text == "")
            {
                MessageBox.Show("Please enter a valid name.");
                return false;
            }
            if (variableFunctionTEBO.Text == "" || !funcIsValid)
            {
                MessageBox.Show("Please enter a function.");
                return false;
            }
            if (Parent == null)
            {
                MessageBox.Show("Please select a parent DataList.");
                return false;
            }


            return true;
        }

        private bool NameIsValid(string name)
        {
            string lower_name = name.ToLower();
            foreach (Constant cons in GlobalData.All_Constants)
                if (lower_name == cons.Name.ToLower())
                    return false;
            foreach (RunData run in GlobalData.All_Runs)
                foreach (DataList dl in run.AllData)
                {
                    if (lower_name == dl.Value_X.Name.ToLower()
                        || lower_name == dl.Value_Y.Name.ToLower())
                        return false;

                    foreach (Variable chiled in dl.Children)
                        if (lower_name == chiled.Value_X.Name.ToLower()
                            || lower_name == chiled.Value_Y.Name.ToLower())
                            return false;
                }

            foreach (DataList dl in GlobalData.Next_RunData.AllData)
                if (lower_name == dl.Value_X.Name.ToLower()
                        || lower_name == dl.Value_Y.Name.ToLower())
                    return false;

            foreach (string command in GlobalData.All_ParserCommands)
                if (lower_name.Contains(command))
                    return false;

            return true;
        }


        private Point Get_Index_minmax(int min, int max, BinTreeNode<string> tree)
        {
            if (tree == null)
                return new Point(min, max);

            //Point ret = new Point(min, max);

            if (tree.GetInfo().Length > 6 && tree.GetInfo().Substring(0, 6) == "parent")
            {
                int info = (int)BinTreeCommand.Solve(0, 0, tree.GetLeft());
                if (info < min)
                    min = info;
                else if (info > max)
                    max = info;

                return new Point(min, max);
            }
            else
            {
                Point tempPoint1 = Get_Index_minmax(min, max, tree.GetLeft());
                Point tempPoint2 = Get_Index_minmax(min, max, tree.GetRight());

                return new Point(Math.Min(tempPoint1.X, tempPoint2.X), Math.Max(tempPoint1.Y, tempPoint2.Y));
            }



        }

        private void addVariableBU_Click(object sender, EventArgs e)
        {
            #region Error messages
            if (Parent == null)
            {
                MessageBox.Show("Please select a parent");
                return;
            }

            if (variableNameTEBO.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (variableNameTEBO.Text.Contains(" "))
            {
                MessageBox.Show("A name cannot contain a space.");
                return;
            }
            if (variableFunctionTEBO.Text == "")
            {
                MessageBox.Show("Please enter a function.");
                return;
            }
            if (!NameIsValid(variableNameTEBO.Text))
            {
                MessageBox.Show("This name already is being used or contains a command name.");
                return;
            }
            //if (!BinTreeCommand.IsWrappedWithBrackets(variableFunctionTEBO.Text))
            //{
            //    MessageBox.Show("'(' or ')' expected in the function.");
            //    return;
            //}
            #endregion

            bool functionIsValid = true;
            string validFunc = GetValidFunc(variableFunctionTEBO.Text, out functionIsValid);
            if (!functionIsValid)
            {
                MessageBox.Show("The function is invalid.");
                return;
            }

            BinTreeNode<string> tree = new BinTreeNode<string>(validFunc);
            BinTreeCommand.MakeTree_2(tree);

            Variable variable = new Variable(variableNameTEBO.Text, Parent.Value_X.Name);
            variable.Set_Function(tree);


            Point index_minmax = Get_Index_minmax(0, 0, tree);




            //for (int i = 0; i < validFunc.Length; i++)
            //{
            //    if (validFunc[i] == 'p' && validFunc.Length >= i + 8)
            //        if (validFunc.Substring(i, 6) == "parent")
            //        {
            //            i += 8;

            //            short bracketsCounter = 0;
            //            if (validFunc[i] == '(')
            //            {
                            
            //            }
            //        }
            //}

            for (int i = - index_minmax.X; i < Parent.Value_Y.Count - index_minmax.Y; i++)
                variable.Add_Data(BinTreeCommand.Solve_DataList(Parent, i, tree), Parent.Value_X.Value[i]);

            Parent.Children.Add(variable);


            variableNameTEBO.Text = "";
            variableFunctionTEBO.Text = "";
        }

        private void parentBU_Click(object sender, EventArgs e)
        {
            dl_s = new DataList_Selecter();
            dl_s.ShowDialog();

            if (dl_s.DataListIsSelected)
            {
                Parent = dl_s.Selected_DataList;

                parentBU.Text = Parent.Get_FullName();
                parentBU.Width = (int)(parentBU.Text.Length * parentBU.Font.Size);
            }
            else
                MessageBox.Show("No valid data was selected.");

        }

        private void constAddBU_Click(object sender, EventArgs e)
        {
            #region Error messages
            if (constNameTEBO.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (constNameTEBO.Text.Contains(" "))
            {
                MessageBox.Show("A name cannot contain a space.");
                return;
            }
            if (!NameIsValid(constNameTEBO.Text))
            {
                MessageBox.Show("This name already is being used or contains a command name.");
                return;
            }
            #endregion

            Constant cons = new Constant(constNameTEBO.Text, (float)constValueNUPDO.Value);

            GlobalData.All_Constants.Add(cons);
            constCOLICO.Update2();

            constNameTEBO.Text = "";
            constValueNUPDO.Value = 0;
        }


    }
}
