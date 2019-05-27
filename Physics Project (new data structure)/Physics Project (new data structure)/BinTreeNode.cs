using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Physics_Project__new_data_structure_
{
    public static class BinTreeCommand
    {
        public static char[] Commands = new char[]
        {
            '+',
            '-',
            '*',
            '/',
            '^'
        };

        private static bool IsWrappedWithBrackets(string s)
        {
            if (s.Length < 2)
                return false;

            if (s[0] != '(' || s[s.Length - 1] != ')')
                return false;

            int bracketsCounter = 0;

            for (int i = 1; i < s.Length - 1; i++)
            {
                if (s[i] == '(')
                    bracketsCounter++;
                else if (s[i] == ')')
                    bracketsCounter--;

                if (bracketsCounter < 0)
                    return false;
            }

            return true;
        }

        public static void MakeTree(BinTreeNode<string> tree)
        {
            short bracketsCounter = 0;
            string s;
            string tempS = tree.GetInfo();

            if (IsWrappedWithBrackets(tempS))
            {
                tempS = tempS.Substring(1, tempS.Length - 2);
                tree.SetInfo(tempS);
            }


            for (int i = 0; i < tempS.Length; i++)
            {
                if (tempS[i] == '(')
                    bracketsCounter++;
                else if (tempS[i] == ')')
                    bracketsCounter--;

                else if (bracketsCounter == 0)
                {
                    s = "";
                    s += tempS[i];

                    if (s == "+" || s == "-")
                    {
                        if (i == 0)
                        {
                            tempS = '0' + tempS;
                            i++;
                        }

                        tree.SetLeft(new BinTreeNode<string>(tempS.Substring(0, i)));
                        MakeTree(tree.GetLeft());
                        tree.SetRight(new BinTreeNode<string>(tempS.Substring(i + 1)));
                        MakeTree(tree.GetRight());

                        tree.SetInfo(s);
                        i = tempS.Length;
                        tempS = s;
                    }
                }
            }

            for (int i = 0; i < tempS.Length; i++)
            {
                if (tempS[i] == '(')
                    bracketsCounter++;
                else if (tempS[i] == ')')
                    bracketsCounter--;

                else if (bracketsCounter == 0)
                {
                    s = "";
                    s += tempS[i];

                    if (s == "*" || s == "/" || s == "^")
                    {
                        tree.SetLeft(new BinTreeNode<string>(tempS.Substring(0, i)));
                        MakeTree(tree.GetLeft());
                        tree.SetRight(new BinTreeNode<string>(tempS.Substring(i + 1)));
                        MakeTree(tree.GetRight());

                        tree.SetInfo(s);
                        i = tempS.Length;
                    }


                    else if (tempS.Length > i + 3)
                    {
                        s = tempS.Substring(i, 3);

                        if (s == "sin" || s == "cos" || s == "tan" || s == "abs" || s == "log")
                        {
                            tree.SetLeft(new BinTreeNode<string>(tempS.Substring(i + 3)));
                            MakeTree(tree.GetLeft());

                            tree.SetInfo(s);
                            i = tempS.Length;
                        }
                        else if (s == "max" || s == "min" || s == "pow")
                        {
                            int g = i + 3;
                            for (; g < tempS.Length && tempS[g] != ','; g++) ;

                            tree.SetLeft(new BinTreeNode<string>(tempS.Substring(i + 4, g - i - 4)));
                            MakeTree(tree.GetLeft());
                            tree.SetRight(new BinTreeNode<string>(tempS.Substring(g + 1)));
                            MakeTree(tree.GetRight());

                            tree.SetInfo(s);
                            i = tempS.Length;
                        }


                        else if (tempS.Length > i + 4)
                        {
                            s = tempS.Substring(i, 4);

                            if (s == "sqrt")
                            {
                                tree.SetLeft(new BinTreeNode<string>(tempS.Substring(i + 4)));
                                MakeTree(tree.GetLeft());

                                tree.SetInfo(s);
                                i = tempS.Length;
                            }
                        }
                    }




                }
            }
        }

        public static void MakeTree_2(BinTreeNode<string> tree)
        {
            short bracketsCounter = 0;
            string s;
            string tempS = tree.GetInfo();

            if (IsWrappedWithBrackets(tempS))
            {
                tempS = tempS.Substring(1, tempS.Length - 2);
                tree.SetInfo(tempS);
            }

            for (int i = 0; i < tempS.Length; i++)
            {
                if (tempS[i] == '(')
                    bracketsCounter++;
                else if (tempS[i] == ')')
                    bracketsCounter--;

                else if (bracketsCounter == 0)
                {
                    s = "";
                    s += tempS[i];

                    if (s == "+" || s == "-")
                    {
                        if (i == 0)
                        {
                            tempS = '0' + tempS;
                            i++;
                        }

                        tree.SetLeft(new BinTreeNode<string>(tempS.Substring(0, i)));
                        MakeTree_2(tree.GetLeft());
                        tree.SetRight(new BinTreeNode<string>(tempS.Substring(i + 1)));
                        MakeTree_2(tree.GetRight());

                        tree.SetInfo(s);
                        i = tempS.Length;
                        tempS = s;
                    }
                }
            }

            for (int i = 0; i < tempS.Length; i++)
            {
                if (tempS[i] == '(')
                    bracketsCounter++;
                else if (tempS[i] == ')')
                    bracketsCounter--;

                s = "";
                s += tempS[i];

                if (s == "*" || s == "/" || s == "^")
                {
                    tree.SetLeft(new BinTreeNode<string>(tempS.Substring(0, i)));
                    MakeTree_2(tree.GetLeft());
                    tree.SetRight(new BinTreeNode<string>(tempS.Substring(i + 1)));
                    MakeTree_2(tree.GetRight());

                    tree.SetInfo(s);
                    i = tempS.Length;
                }
                else if (tempS.Length > i + 3)
                {
                    s = tempS.Substring(i, 3);

                    if (s == "sin" || s == "cos" || s == "tan" || s == "abs" || s == "log")
                    {
                        tree.SetLeft(new BinTreeNode<string>(tempS.Substring(i + 3)));
                        MakeTree_2(tree.GetLeft());

                        tree.SetInfo(s);
                        i = tempS.Length;
                    }
                    else if (s == "max" || s == "min" || s == "pow")
                    {
                        int g = i + 3;
                        for (; g < tempS.Length && tempS[g] != ','; g++) ;

                        tree.SetLeft(new BinTreeNode<string>(tempS.Substring(i + 4, g - i - 4)));
                        MakeTree_2(tree.GetLeft());
                        tree.SetRight(new BinTreeNode<string>(tempS.Substring(g + 1)));
                        MakeTree_2(tree.GetRight());

                        tree.SetInfo(s);
                        i = tempS.Length;
                    }
                    else if (tempS.Length > i + 4)
                    {
                        s = tempS.Substring(i, 4);

                        if (s == "sqrt")
                        {
                            tree.SetLeft(new BinTreeNode<string>(tempS.Substring(i + 4)));
                            MakeTree_2(tree.GetLeft());

                            tree.SetInfo(s);
                            i = tempS.Length;
                        }

                        if (tempS.Length >= i + 8)
                        {
                            s = tempS.Substring(i, 6);

                            if (s == "parent")
                            {
                                s = tempS.Substring(i, 8);

                                tree.SetLeft(new BinTreeNode<string>(tempS.Substring(i + 8)));
                                if (tree.GetLeft().GetInfo() == "")
                                    tree.GetLeft().SetInfo("0");
                                MakeTree_2(tree.GetLeft());

                                tree.SetInfo(s);
                                i = tempS.Length;
                            }
                        }
                    }
                }


            }


        }


        public static float Solve(float x, float y, BinTreeNode<string> tree)
        {
            switch (tree.GetInfo())
            {
                case "parent.x":
                    return x;

                case "parent.y":
                    return y;

                case "+":
                    return Solve(x, y, tree.GetLeft()) + Solve(x, y, tree.GetRight());

                case "-":
                    return Solve(x, y, tree.GetLeft()) - Solve(x, y, tree.GetRight());
                case "*":
                    return Solve(x, y, tree.GetLeft()) * Solve(x, y, tree.GetRight());

                case "/":
                    return Solve(x, y, tree.GetLeft()) / Solve(x, y, tree.GetRight());

                case "^":
                    return (float)Math.Pow(Solve(x, y, tree.GetLeft()), Solve(x, y, tree.GetRight()));

                case "sin":
                    return (float)Math.Sin(Solve(x, y, tree.GetLeft()));

                case "cos":
                    return (float)Math.Cos(Solve(x, y, tree.GetLeft()));

                case "tan":
                    return (float)Math.Tan(Solve(x, y, tree.GetLeft()));

                case "abs":
                    return (float)Math.Abs(Solve(x, y, tree.GetLeft()));

                case "max":
                    return (float)Math.Max(Solve(x, y, tree.GetLeft()), Solve(x, y, tree.GetRight()));

                case "min":
                    return (float)Math.Min(Solve(x, y, tree.GetLeft()), Solve(x, y, tree.GetRight()));

                case "pow":
                    return (float)Math.Pow(Solve(x, y, tree.GetLeft()), Solve(x, y, tree.GetRight()));

                case "sqrt":
                    return (float)Math.Sqrt(Solve(x, y, tree.GetLeft()));



                default:
                    return float.Parse(tree.GetInfo());
            }
        }

        public static float Solve_DataList(DataList parent, int index, BinTreeNode<string> tree)
        {
            switch (tree.GetInfo())
            {
                case "parent.x":
                    return parent.Value_X.Value[index + (int)Solve_DataList(parent, index, tree.GetLeft())];

                case "parent.y":
                    return parent.Value_Y.Value[index + (int)Solve_DataList(parent, index, tree.GetLeft())];


                case "+":
                    return Solve_DataList(parent, index, tree.GetLeft()) + Solve_DataList(parent, index, tree.GetRight());

                case "-":
                    return Solve_DataList(parent, index, tree.GetLeft()) - Solve_DataList(parent, index, tree.GetRight());
                case "*":
                    return Solve_DataList(parent, index, tree.GetLeft()) * Solve_DataList(parent, index, tree.GetRight());

                case "/":
                    return Solve_DataList(parent, index, tree.GetLeft()) / Solve_DataList(parent, index, tree.GetRight());

                case "^":
                    return (float)Math.Pow(Solve_DataList(parent, index, tree.GetLeft()), Solve_DataList(parent, index, tree.GetRight()));

                case "sin":
                    return (float)Math.Sin(Solve_DataList(parent, index, tree.GetLeft()));

                case "cos":
                    return (float)Math.Cos(Solve_DataList(parent, index, tree.GetLeft()));

                case "tan":
                    return (float)Math.Tan(Solve_DataList(parent, index, tree.GetLeft()));

                case "abs":
                    return (float)Math.Abs(Solve_DataList(parent, index, tree.GetLeft()));

                case "max":
                    return (float)Math.Max(Solve_DataList(parent, index, tree.GetLeft()), Solve_DataList(parent, index, tree.GetRight()));

                case "min":
                    return (float)Math.Min(Solve_DataList(parent, index, tree.GetLeft()), Solve_DataList(parent, index, tree.GetRight()));

                case "pow":
                    return (float)Math.Pow(Solve_DataList(parent, index, tree.GetLeft()), Solve_DataList(parent, index, tree.GetRight()));

                case "sqrt":
                    return (float)Math.Sqrt(Solve_DataList(parent, index, tree.GetLeft()));



                default:
                    return float.Parse(tree.GetInfo());
            }
        }


    }


    public class BinTreeNode<T>
    {

        private BinTreeNode<T> left;
        private T info;
        private BinTreeNode<T> right;


        public BinTreeNode(T x)
        {
            this.left = null;
            this.info = x;
            this.right = null;
        }
        public BinTreeNode(BinTreeNode<T> left, T x, BinTreeNode<T> right)
        {
            this.left = left;
            this.info = x;
            this.right = right;
        }

        public T GetInfo()
        {
            return this.info;
        }
        public void SetInfo(T x)
        {
            this.info = x;
        }
        public BinTreeNode<T> GetLeft()
        {
            return this.left;
        }
        public BinTreeNode<T> GetRight()
        {
            return this.right;
        }
        public void SetLeft(BinTreeNode<T> tree)
        {
            this.left = tree;
        }
        public void SetRight(BinTreeNode<T> tree)
        {
            this.right = tree;
        }
        public override string ToString()
        {
            return this.info.ToString();
        }


    }
}
