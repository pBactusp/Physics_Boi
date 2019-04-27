using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Physics_Project
{
    public static class GlobalData
    {
        public static List<RunData> allRuns;

        public static string[] SensorTypes = new string[]
        {
            "Empty",
            "Ultrasonic",
            "Microphone",
            "Force",
            "Temperature"
        };

        public static string[] DataNames = new string[]
        {
            "Null",
            "Distance",
            "Voltage",
            "Force",
            "Newton",
            "Celsius"
        };

        public static List<string>[] MeasurmentsNames = new List<string>[]
        {
            new List<string>() { "" },
            new List<string>() { "m", "cm", "mm" },
            new List<string>() { "v" },
            new List<string>() { "N" },
            new List<string>() { "c" }
        };



        public static Color ClearColor { get { return Color.FromArgb(0, 0, 0, 0); } }
    }
}
