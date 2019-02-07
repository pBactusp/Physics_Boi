using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics_Project
{
    public partial class SetVariables : Form
    {
        public SetVariables()
        {
            InitializeComponent();
        }
        public SetVariables(List<NamedVariable> AllConstants, List<string> AllCommands)
        {
            InitializeComponent();
            this.AllConstants = AllConstants;
            this.AllCommands = AllCommands;
        }


        public List<NamedVariable> AllConstants;
        public List<string> AllCommands;

        static BinTreeNode<string> BuildTreeOfParser(String str)
        {
            BinTreeNode<string> tr = null;
            int Brackets = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ')')
                    Brackets++;
                if (str[i] == '(')
                    Brackets--;
                if (str[i] == '+' && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    if (i != 0)
                        tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                    else
                        tr.SetLeft(BuildTreeOfParser("0"));
                }
                else
                    if (str[i] == '-' && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    if (i != 0)
                        tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                    else
                        tr.SetLeft(BuildTreeOfParser("0"));
                }
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ')')
                    Brackets++;
                if (str[i] == '(')
                    Brackets--;
                if (str[i] == '*' && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                }
                else
                    if (str[i] == '/' && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                }
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ')')
                    Brackets++;
                if (str[i] == '(')
                    Brackets--;
                if (str[i] == '^' && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                }
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ')')
                    Brackets++;
                if (str[i] == '(')
                    Brackets--;
                if (i < str.Length - 3 && str.Substring(i, 3) == "cos" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "sin" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "tan" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "sec" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "csc" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "cot" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 6 && str.Substring(i, 3) == "arcsin" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 6 && str.Substring(i, 3) == "arccos" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "abs" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "log" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                    tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                }
            }

            if (tr == null && str[0] != '(')
            {
                tr = new BinTreeNode<string>(str);
            }
            if (str[0] == '(' && tr == null)
            {
                return BuildTreeOfParser(str.Substring(1, str.Length - 2));
            }

            return tr;
        }
        static string CleanDef(string str)
        {
            string CleanedDef = "";
            int Brackets = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    Brackets++;
                    CleanedDef += '(';
                }
                else if (str[i] == ')')
                {
                    Brackets--;
                    if (Brackets == -1)
                        return "$Error$";
                    CleanedDef += ')';
                }
                else if (str[i] == '{' || str[i] == '[')
                {
                    CleanedDef += '(';
                    Brackets++;
                }
                else if (str[i] == '}' || str[i] == ']')
                {
                    CleanedDef += ')';
                    Brackets--;
                    if (Brackets == -1)
                        return "$Error$";
                }
                else if (str[i] != ' ')
                {
                    CleanedDef += str[i];
                }

            }
            if (Brackets != 0)
            {
                return "$Error$";
            }

            return CleanedDef;
        }

        public string PrintInOrder(BinTreeNode<string> t, string Print)
        {
            if (t != null)
            {
                return PrintInOrder(t.GetLeft(), Print) + t.GetInfo().ToString() + PrintInOrder(t.GetRight(), Print);
            }
            return "";
        }
        public double CalculateTreeOfParser(BinTreeNode<string> t)
        {
            if (t != null)
                if (t.GetInfo() == "+")
                    return CalculateTreeOfParser(t.GetLeft()) + CalculateTreeOfParser(t.GetRight());
                else if (t.GetInfo() == "-")
                    return CalculateTreeOfParser(t.GetLeft()) - CalculateTreeOfParser(t.GetRight());
                else if (t.GetInfo() == "*")
                    return CalculateTreeOfParser(t.GetLeft()) * CalculateTreeOfParser(t.GetRight());
                else if (t.GetInfo() == "/")
                    return CalculateTreeOfParser(t.GetLeft()) / CalculateTreeOfParser(t.GetRight());
                else if (t.GetInfo() == "^")
                    return Math.Pow(CalculateTreeOfParser(t.GetLeft()), CalculateTreeOfParser(t.GetRight()));
                else if (t.GetInfo() == "cos")
                    return Math.Cos(CalculateTreeOfParser(t.GetRight()));
                else if (t.GetInfo() == "sin")
                    return Math.Sin(CalculateTreeOfParser(t.GetRight()));
                else if (t.GetInfo() == "tan")
                    return Math.Tan(CalculateTreeOfParser(t.GetRight()));
                else if (t.GetInfo() == "sec")
                    return 1 / Math.Cos(CalculateTreeOfParser(t.GetRight()));
                else if (t.GetInfo() == "csc")
                    return 1 / Math.Sin(CalculateTreeOfParser(t.GetRight()));
                else if (t.GetInfo() == "cot")
                    return 1 / Math.Tan(CalculateTreeOfParser(t.GetRight()));
                else if (t.GetInfo() == "arcsin")
                    return Math.Asin(CalculateTreeOfParser(t.GetRight()));
                else if (t.GetInfo() == "arccos")
                    return Math.Acos(CalculateTreeOfParser(t.GetRight()));
                else if (t.GetInfo() == "arctan")
                    return Math.Atan(CalculateTreeOfParser(t.GetRight()));
                else if (t.GetInfo() == "log")
                    return Math.Log(CalculateTreeOfParser(t.GetRight()), CalculateTreeOfParser(t.GetLeft()));
                else if (t.GetInfo() == "abs")
                    return Math.Abs(CalculateTreeOfParser(t.GetRight()));
                else if (t.GetInfo() == "pi")
                    return Math.PI;
                else if (t.GetInfo() == "e")
                    return Math.E;
                else for (int i = 0; i < GlobalData.allVariables.Count; i++)
                    {
                        if (GlobalData.allVariables[i].Name == t.GetInfo())
                            return CalculateTreeOfParser(BuildTreeOfParser(CleanDef(GlobalData.allVariables[i].Def)));
                    }
            else for (int i = 0; i < AllConstants.Count; i++)
                {
                    if (AllConstants[i].Name == t.GetInfo())
                        return CalculateTreeOfParser(BuildTreeOfParser(CleanDef(AllConstants[i].Def)));
                }
            return double.Parse(t.GetInfo());
        }

        // עדיין צריך להוסיף את האפשרות לשים סוגריים בשם של משתנה וקומנד ריק
        private void button1_Click(object sender, EventArgs e)
        {
            string def = CleanDef(DefOfNewVariable.Text);
            string name = NameOfNewVariable.Text;

            bool isVar = false, error = false, canSkip = false;

            #region Name Errors
            if(char.IsLetter(name[0]) == false)
            {
                MessageBox.Show("Variables must start with a letter");
                error = true;
            }
            if (!error)
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == ' ')
                    {
                        MessageBox.Show("Names can not contain spaces");
                        error = true;
                        break;
                    }
                }
            if (!error)
                for (int i = 0; i < GlobalData.allVariables.Count; i++)
                {
                    if(GlobalData.allVariables[i].Name == name)
                    {
                        MessageBox.Show("A variable with the same name already exists");
                        error = true;
                        break;
                    }
                }
            if (!error)
                for (int i = 0; i < AllConstants.Count; i++)
                {
                    if (AllConstants[i].Name == name)
                    {
                        MessageBox.Show("A constant with the same name already exists");
                        error = true;
                        break;
                    }
                }
            if (!error)

                for (int i = 0; i < AllCommands.Count; i++)
                {
                    if (AllCommands[i] == name.ToLower()) 
                    {
                        MessageBox.Show("A command with the same name already exists");
                        error = true;
                        break;
                    }
                }
#endregion

            if (def == "$Error$" && !error)
            {
                MessageBox.Show("The equation is mathematically incorrect");
            }
            else if (!error && (def[0] == '*' || def[0] == '/' || def[0] == '^'))
            {
                MessageBox.Show("The equation is mathematically incorrect");
            }
            else if (!error && (def[def.Length - 1] == '*' || def[def.Length - 1] == '/' || def[def.Length - 1] == '^' 
                            || def[def.Length - 1] == '-' || def[def.Length - 1] == '+'))
            {
                MessageBox.Show("The equation is mathematically incorrect");
            }
            else if (!error)
            {
                for (int i = 0; i < def.Length; i++)
                {
                    if (char.IsLetter(def[i]))
                    {
                        int j = 1;
                        while (true)
                        {
                            if (i + j == def.Length || def[i + j] == '+' || def[i + j] == '-' || def[i + j] == '*'
                                || def[i + j] == '/' || def[i + j] == '^' || def[i + j] == '(' || def[i + j] == ')')
                            {
                                break;
                            }
                            j++;
                        }
                        for (int k = 0; k < GlobalData.allVariables.Count; k++)
                        {
                            if (GlobalData.allVariables[k].Name == def.Substring(i, j))
                            {
                                isVar = true;
                                canSkip = true;
                                break;
                            }
                        }
                        if (!canSkip)
                        {
                            for (int k = 0; k < AllConstants.Count; k++)
                            {
                                if (AllConstants[k].Name == def.Substring(i, j))
                                {
                                    canSkip = true;
                                    break;
                                }
                            }
                            if (!canSkip)
                            {
                                for (int k = 0; k < AllCommands.Count; k++)
                                {
                                    if (AllCommands[k] == def.Substring(i, j).ToLower())
                                    {
                                        if (i+j == def.Length || def[i+j] != '(')
                                        {
                                            MessageBox.Show("The equation is mathematically incorrect");
                                            error = true;
                                            canSkip = true;
                                            break;
                                        }
                                        canSkip = true;
                                        break;
                                    }
                                }
                            }
                        }
                        if (!canSkip)
                        {
                            MessageBox.Show("The definition contains unknown symbols");
                            error = true;
                            break;
                        }
                        canSkip = false;
                        i += j - 1;
                    }
                    else if ((def[i] == '+' || def[i] == '-' || def[i] == '*' || def[i] == '/' || def[i] == '^' || def[i] == '(') &&
                        (def[i+1] == '+' || def[i+1] == '-' || def[i+1] == '*' || def[i+1] == '/' || def[i+1] == '^' || def[i+1] == ')'))
                    {
                        if (def[i] != '(' || def[i+1] != '-')
                        {
                            MessageBox.Show("The equation is mathematically incorrect");
                            error = true;
                            break;
                        }
                    }
                    else if(!char.IsNumber(def[i]) && def[i] != '+' && def[i] != '-' && def[i] != '*' && def[i] != '/' 
                        && def[i] != '^' && def[i] != '(' && def[i] != ')')
                    {
                        MessageBox.Show("The definition contains unknown symbols");
                        error = true;
                        break;
                    }
                }
                if (!error)
                {
                    NamedVariable a = new NamedVariable(name, int.Parse(def)); //////////////////////////////////////////////////////////
                    if (isVar)
                    {
                        GlobalData.allVariables.Add(a);
                        VariablesLB.Items.Add(name + " = " + CleanDef(def));
                    }
                    else // is const
                    {
                        AllConstants.Add(a);
                        ConstantsLB.Items.Add(name + " = " + CleanDef(def));
                    }

                }
            }

        }

        private void SetVariables_Load(object sender, EventArgs e)
        {
            VariablesLB.Items.Add("Variables:");
            VariablesLB.Items.Add("");
            ConstantsLB.Items.Add("Constants:");
            ConstantsLB.Items.Add("");
            CommandsLB.Items.Add("Commands:");
            CommandsLB.Items.Add("");

            for (int i = 0; i < GlobalData.allVariables.Count; i++)
            {
                VariablesLB.Items.Add(GlobalData.allVariables[i].Name);
            }
            for (int i = 0; i < AllConstants.Count; i++)
            {
                ConstantsLB.Items.Add(AllConstants[i].Name);
            }
            for (int i = 0; i < AllCommands.Count; i++)
            {
                CommandsLB.Items.Add(AllCommands[i]);
            }
        }
    }
}
