using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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

            data += "#ALL_RUNS" + Environment.NewLine;
            foreach (RunData runData in GlobalData.All_Runs)
                data += Parse_RunData(runData);
            data += "#ENDALL_RUNS" + Environment.NewLine;

            data += "#NEXT_RUNDATA" + Environment.NewLine;
            data += Parse_RunData(GlobalData.Next_RunData) + Environment.NewLine;
            data += "#ENDNEXT_RUNDATA" + Environment.NewLine;

            return data;
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
            foreach (DataList dataList in runData.AllData)
                ret += Parse_DataList(dataList);
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

            foreach (Variable child in dataList.Children)
                ret += "-" + Parse_DataList(child) + Environment.NewLine;

            return ret;
        }

        /// <summary>
        /// Parse as:
        /// Name|Min,Max|Values{}
        /// </summary>
        /// <param name="namedList"></param>
        /// <returns></returns>
        private string Parse_NamedList(NamedList namedList)
        {
            string ret = "";

            ret += namedList.Name + "|";
            ret += namedList.MinVal + "|"
                + namedList.MaxVal + "|"; ;

            for (int i = 0; i < namedList.Value.Count; i++)
                ret += namedList.Value[i] + ",";

            ret.Remove(ret.Length - 2);

            return ret;
        }


    }


}
