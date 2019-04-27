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
            "Ultrasonic (Distance)",
            "Microphone",
            "Force",
            "Temperature",
            "InfraRed (Distance)"
        };

        public static string[] DataNames = new string[]
        {
            "Null",
            "Distance",
            "Voltage",
            "Force",
            "Newton",
            "Degrees",
            "Distance"
        };

        public static List<string>[] MeasurmentsNames = new List<string>[]
        {
            new List<string>() { "" },
            new List<string>() { "m", "cm", "mm" },
            new List<string>() { "v" },
            new List<string>() { "N" },
            new List<string>() { "c", "f" },
            new List<string>() { "m", "cm", "mm" }
        };



        public static Color ClearColor { get { return Color.FromArgb(0, 0, 0, 0); } }
    }
}
