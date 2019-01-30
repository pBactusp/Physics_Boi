using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Physics_Project
{
    public static class GlobalData
    {
        public static string[] SensorTypes = new string[]
        {
            "Empty",
            "Ultrasonic"
        };

        public static string[] DataNames = new string[]
        {
            "",
            "Distance"
        };

        public static List<string>[] MeasurmentsNames = new List<string>[]
        {
            new List<string>() { "" },
            new List<string>() { "m", "cm", "mm" }
        };



        public static Color ClearColor { get { return Color.FromArgb(0, 0, 0, 0); } }
    }
}
