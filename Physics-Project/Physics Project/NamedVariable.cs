using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Project
{
    public class NamedVariable
    {
        string _Def;
        string _Name;
        int _Type; // 0 = variable, 1 = constant, 2 = command
        double _Value;
        List<NamedList> _Contains;
        BinTreeNode<string> _TreeOfDef;

        public NamedVariable(string name, string def, int type, List<NamedList> Contains, BinTreeNode<string> TreeOfDef) // variable
        {
            _Name = name;
            _Def = def;
            _Type = type;
            _Contains = Contains;
            _TreeOfDef = TreeOfDef;
        }
        public NamedVariable(string name, double value, int type) // constant
        {
            _Name = name;
            _Value = value;
            _Type = type;
        }
        public NamedVariable(string name, int type) // command
        {
            _Name = name;
            _Type = type;
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Def
        {
            get { return _Def; }
            set { _Def = value; }
        }
        public BinTreeNode<string> TreeOfDef
        {
            get { return _TreeOfDef; }
            set { _TreeOfDef = value; }
        }
        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        public Double Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        public List<NamedList> Contains
        {
            get { return _Contains; }
            set { _Contains = value; }
        }

        public double CalculateVariable(BinTreeNode<string> t, int m)
        {
            bool IsTrue = false;
            if (t != null)
            {
                if (t.GetInfo() == "+")
                    return CalculateVariable(t.GetLeft(), m) + CalculateVariable(t.GetRight(), m);
                else if (t.GetInfo() == "-")
                    return CalculateVariable(t.GetLeft(), m) - CalculateVariable(t.GetRight(), m);
                else if (t.GetInfo() == "*")
                    return CalculateVariable(t.GetLeft(), m) * CalculateVariable(t.GetRight(), m);
                else if (t.GetInfo() == "/")
                    return CalculateVariable(t.GetLeft(), m) / CalculateVariable(t.GetRight(), m);
                else if (t.GetInfo() == "^")
                    return Math.Pow(CalculateVariable(t.GetLeft(), m), CalculateVariable(t.GetRight(), m));
                else if (t.GetInfo() == "cos")
                    return Math.Cos(CalculateVariable(t.GetRight(), m));
                else if (t.GetInfo() == "sin")
                    return Math.Sin(CalculateVariable(t.GetRight(), m));
                else if (t.GetInfo() == "tan")
                    return Math.Tan(CalculateVariable(t.GetRight(), m));
                else if (t.GetInfo() == "sec")
                    return 1 / Math.Cos(CalculateVariable(t.GetRight(), m));
                else if (t.GetInfo() == "csc")
                    return 1 / Math.Sin(CalculateVariable(t.GetRight(), m));
                else if (t.GetInfo() == "cot")
                    return 1 / Math.Tan(CalculateVariable(t.GetRight(), m));
                else if (t.GetInfo() == "arcsin")
                    return Math.Asin(CalculateVariable(t.GetRight(), m));
                else if (t.GetInfo() == "arccos")
                    return Math.Acos(CalculateVariable(t.GetRight(), m));
                else if (t.GetInfo() == "arctan")
                    return Math.Atan(CalculateVariable(t.GetRight(), m));
                else if (t.GetInfo() == "log")
                    return Math.Log(CalculateVariable(t.GetRight(), m), CalculateVariable(t.GetLeft(), m));
                else if (t.GetInfo() == "abs")
                    return Math.Abs(CalculateVariable(t.GetRight(), m));
                else
                {
                    for (int i = 0; i < GlobalData.allVariables.Count; i++)
                    {
                        if (GlobalData.allVariables[i].Name == t.GetInfo())
                        {
                            IsTrue = true;
                            if (GlobalData.allVariables[i].Type == 0)
                            {
                                return CalculateVariable(GlobalData.allVariables[i].TreeOfDef, m);
                            }
                            else if (GlobalData.allVariables[i].Type == 1)
                            {
                                return GlobalData.allVariables[i].Value;
                            }
                        }
                    }
                    for (int i = 0; i < GlobalData.allRuns.Count; i++)
                    {
                        for (int j = 0; j < GlobalData.allRuns[i].AllData.Count; j++)
                        {
                            if (GlobalData.allRuns[i].AllData[j].Name == t.GetInfo())
                            {
                                return GlobalData.allRuns[i].AllData[j][m];
                            }
                        }
                    }
                    if (!IsTrue)
                        return double.Parse(t.GetInfo());
                }
            }
            return 0;
        }

        public List<double> GetListOfVariable(NamedVariable variable)
        {
            List<double> list = new List<double>();
            List<int> length = new List<int>();

            for (int i = 0; i < variable.Contains.Count; i++)
            {
                length.Add(variable.Contains[i].Count);
            }
            int min = length.Min();

            for (int m = 0; m < min; m++)
            {
                list.Add(CalculateVariable(variable.TreeOfDef, m));
            }

            return list;
        }
    }
}
