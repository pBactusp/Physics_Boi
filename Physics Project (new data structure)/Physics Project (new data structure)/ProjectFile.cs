using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Physics_Project__new_data_structure_
{
    public class ProjectFile
    {
        string _path;


        public string SaveAs(string path)
        {
            _path = path;

            if (!File.Exists(_path))
                File.Create(_path).Close();


            return Save();
        }

        public string Save()
        {
            if (File.Exists(_path))
            {
                File.WriteAllText(_path, ToString());
                return "The file has been saved";
            }
            else
                return "The file could not be found";
        }

        public string GetName()
        {
            return Path.GetFileNameWithoutExtension(_path);
        }

        /// <summary>
        /// 
        /// Parses as:
        /// #ALL_RUNS
        /// All_Runs[0]
        /// All_Runs[1]
        /// #ENDALL_RUNS
        /// #NEXT_RUNDATA
        /// Next_RunData
        /// #ENDNEXT_RUNDATA
        /// 
        /// </summary>
        public override string ToString()
        {
            string data = "";

            foreach (RunData runData in GlobalData.All_Runs)
                data += Parse_RunData(runData);

            return data;
        }

        public string Load(string path)
        {
            _path = path;
            if (File.Exists(_path))
            {
                GlobalData.All_Runs.Clear();

                string text = File.ReadAllText(_path);
                int start,
                    stop;

                while (text.Contains("#RUN"))
                {
                    start = text.IndexOf("#RUN") + 6;
                    stop = text.IndexOf("#ENDRUN");

                    GlobalData.All_Runs.Add(Read_RunData(text.Substring(start, stop - start)));
                    text = text.Substring(stop + 9);
                }

                return "The file has been loaded successfully";
            }
            else
                return "The file could not be found";
        }









        /// <summary>
        /// 
        /// Parse as:
        /// #RUN
        /// AllData[0]
        /// AllData[1]
        /// #ENDRUN
        /// 
        /// </summary>
        /// <param name="runData"></param>
        /// <returns></returns>
        private string Parse_RunData(RunData runData)
        {
            string ret = "";

            ret += "#RUN" + Environment.NewLine;
            if (runData.AllData.Count > 0)
            {
                for (int i = 0; i < runData.AllData.Count - 1; i++)
                    ret += Parse_DataList(runData.AllData[i]) + Environment.NewLine;

                ret += Parse_DataList(runData.AllData[runData.AllData.Count - 1]);
            }
            ret += "#ENDRUN" + Environment.NewLine;

            return ret;
        }

        /// <summary>
        /// 
        /// Parse as:
        /// Visible|Color
        /// -Value_Y
        /// -Value_X
        /// --Child[0]
        /// --Child[1]
        /// 
        /// </summary>
        /// <param name="dataList"></param>
        /// <returns></returns>
        private string Parse_DataList(DataList dataList)
        {
            string ret = "";

            ret += dataList.Visible.ToString() + "|";
            ret += dataList.LineColor.Name + Environment.NewLine;
            ret += "-" + Parse_NamedList(dataList.Value_Y) + Environment.NewLine;
            ret += "-" + Parse_NamedList(dataList.Value_X) + Environment.NewLine;


            if (dataList.Children.Count > 0)
            {
                ret += "{" + Environment.NewLine;
                for (int i = 0; i < dataList.Children.Count - 1; i++)
                    ret += Parse_DataList(dataList.Children[i]); // + Environment.NewLine;

                ret += Parse_DataList(dataList.Children[dataList.Children.Count - 1]);
                ret += "}" + Environment.NewLine;
            }


            return ret;
        }

        /// <summary>
        /// Parse as:
        /// Name|Min|Max|Values{}
        /// </summary>
        /// <param name="namedList"></param>
        /// <returns></returns>
        private string Parse_NamedList(NamedList namedList)
        {
            string ret = "";

            ret += namedList.Name + "|";
            ret += namedList.MinVal + "|"
                + namedList.MaxVal + "|"; ;

            if (namedList.Value.Count > 0)
            {
                for (int i = 0; i < namedList.Value.Count; i++)
                    ret += namedList.Value[i] + ",";

                ret = ret.Substring(0, ret.Length - 1);
            }


            return ret;
        }


        private RunData Read_RunData(string rData)
        {
            RunData ret = new RunData();

            string[] dLists = rData.Split(new string[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.None);

            //List<string> dlists = new List<string>();
            //int bracketsCounter;


            foreach (string dlist in dLists)
                ret.AllData.Add(Read_DataList(dlist));

            return ret;
        }

        private DataList Read_DataList(string dList)
        {
            string[] lines = dList.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            string[] visibleColor = lines[0].Split('|');

            DataList ret = new DataList();
            ret.Visible = bool.Parse(visibleColor[0]);
            ret.LineColor = Color.FromName(visibleColor[1]);
            ret.Value_Y = Read_NamedList(lines[1].Substring(1));
            ret.Value_X = Read_NamedList(lines[2].Substring(1));

            if (lines.Length > 3 && lines[3] == "{")
            {
                int start = 4,
                    stop = start + 3;
                int bracketsCounter;
                string childString;

                while (stop < lines.Length)
                {
                    childString = "";
                    for (int i = 0; i < 3; i++)
                        childString += lines[start + i] + Environment.NewLine;

                    if (lines[stop] == "{")
                    {
                        childString += lines[stop] + Environment.NewLine;

                        bracketsCounter = 1;
                        while (bracketsCounter != 0)
                        {
                            stop++;
                            if (lines[stop] == "{")
                                bracketsCounter++;
                            else if (lines[stop] == "}")
                                bracketsCounter--;
                            childString += lines[stop] + Environment.NewLine;
                        }
                    }

                    ret.Children.Add(new Variable(Read_DataList(childString)));

                    start = stop + 1;
                    stop = start + 3;
                }

            }

            return ret;
        }

        private NamedList Read_NamedList(string nList)
        {
            string[] buff = nList.Split('|');

            string[] values = buff[3].Split(',');

            NamedList ret = new NamedList(buff[0]);
            ret.MinVal = float.Parse(buff[1]);
            ret.MaxVal = float.Parse(buff[2]);

            for (int i = 0; i < values.Length; i++)
                ret.Add_Value(float.Parse(values[i]));

            return ret;
        }



    }


}
