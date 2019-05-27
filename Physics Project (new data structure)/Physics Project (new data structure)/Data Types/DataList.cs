using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Physics_Project__new_data_structure_
{
    public class NamedList
    {
        public string Name;
        public List<float> Value;
        public float MinVal;
        public float MaxVal;


        public NamedList(string name)
        {
            Name = name;
            Value = new List<float>();

            MinVal = 100000;
            MaxVal = -100000;
        }
        public NamedList(string name, NamedList namedList)
        {
            Name = name;
            Value = new List<float>(namedList.Value);

            MinVal = 100000;
            MaxVal = -100000;
        }

        public int Count { get { return Value.Count; } }


        public void Add_Value(float value)
        {
            if (value > MaxVal)
                MaxVal = value;
            else if (value < MinVal)
                MinVal = value;

            Value.Add(value);
        }

    }



    public class DataList
    {
        public bool Visible = true;
        public Color LineColor;

        public NamedList Value_X;
        public NamedList Value_Y;
        public List<Variable> Children;


        public DataList()
        {
            Visible = true;

            Value_Y = new NamedList("");
            Value_X = new NamedList("");
            Children = new List<Variable>();
        }
        public DataList(string name_vy, string name_vx)
        {
            Visible = true;

            Value_Y = new NamedList(name_vy);
            Value_X = new NamedList(name_vx);

            Children = new List<Variable>();
        }
        public DataList(string name_vy, string name_vx, DataList dataList)
        {
            Visible = true;

            Value_Y = new NamedList(name_vy, dataList.Value_Y);
            Value_X = new NamedList(name_vx, dataList.Value_X);

            Children = new List<Variable>();
        }


        public string Get_FullName()
        {
            return Value_Y.Name + " / " + Value_X.Name;
        }
        public virtual void Add_Data(float value_y, float value_x)
        {
            Value_Y.Add_Value(value_y);
            Value_X.Add_Value(value_x);
        }


        public override string ToString()
        {
            string s_y = "";
            string s_x = "";

            int i = 0;
            while (i < Value_X.Count)
            {
                s_y += Value_Y.Value[i];
                s_x += Value_X.Value[i];

                i++;
                if (i < Value_X.Count)
                    s_y += ",";
                s_x += ",";
            }

            return s_y + "/n" + s_x;
        }


    }





    public class Variable : DataList
    {
        private BinTreeNode<string> function;

        public Variable()
        {
            Visible = true;

            Value_Y = new NamedList("generic_y");
            Value_X = new NamedList("generic_x");

            Children = new List<Variable>();
        }
        public Variable(string name_vy, string name_vx)
        {
            Visible = true;

            Value_Y = new NamedList(name_vy);
            Value_X = new NamedList(name_vx);

            Children = new List<Variable>();
        }

        public void Set_Function(BinTreeNode<string> function)
        {
            this.function = function;
        }

        //public Variable(string name, DataList dataList)
        //{
        //    Name = name;

        //    Value = new List<float>(dataList.Value);
        //    TimeStamp = new List<float>(dataList.TimeStamp);
        //    Children = new List<Variable>();
        //}


        //public override void Add_Data(float value, float timeStamp = -1)
        //{
        //    value = function.Solve(value)

        //    if (value > maxVal)
        //        maxVal = value;
        //    else if (value < minVal)
        //        minVal = value;

        //    Value.Add(value);
        //    TimeStamp.Add(timeStamp);
        //}
    }


    public class Constant
    {
        public string Name;
        public float Value;


        public Constant(string name, float value)
        {
            Name = name;
            Value = value;
        }
    }


}
