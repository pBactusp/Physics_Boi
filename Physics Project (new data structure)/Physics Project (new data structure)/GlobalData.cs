using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Physics_Project__new_data_structure_
{
    public static class GlobalData
    {
        public static Color ClearColor = Color.FromArgb(0, 0, 0, 0);

        public static List<Constant> All_Constants = new List<Constant>();
        public static List<Variable> All_Variables = new List<Variable>();
        public static List<RunData> All_Runs = new List<RunData>();

        public static RunData Next_RunData = new RunData();

        public static ArduinoSystem ArduinoSystem;
        //public static List<Grapher> All_Graphers = new List<Grapher>();

        public static string[] All_ParserCommands = new string[]
        {
            "sin",
            "cos",
            "tan",
            "abs",
            "pow",
            "max",
            "min",
            "sqrt"
        };
        
        
        public static Bitmap[] SensorImages = new Bitmap[]
        {
            new Bitmap(@"D:\C#\Physics Project\Physics_Boi\Physics Project (new data structure)\Physics Project (new data structure)\Assets\Sensor Images\Empty.png"),
            new Bitmap(@"D:\C#\Physics Project\Physics_Boi\Physics Project (new data structure)\Physics Project (new data structure)\Assets\Sensor Images\Empty.png"),
            new Bitmap(@"D:\C#\Physics Project\Physics_Boi\Physics Project (new data structure)\Physics Project (new data structure)\Assets\Sensor Images\Empty.png"),
            new Bitmap(@"D:\C#\Physics Project\Physics_Boi\Physics Project (new data structure)\Physics Project (new data structure)\Assets\Sensor Images\Empty.png"),
            new Bitmap(@"D:\C#\Physics Project\Physics_Boi\Physics Project (new data structure)\Physics Project (new data structure)\Assets\Sensor Images\Empty.png"),
            new Bitmap(@"D:\C#\Physics Project\Physics_Boi\Physics Project (new data structure)\Physics Project (new data structure)\Assets\Sensor Images\Empty.png"),
            new Bitmap(@"D:\C#\Physics Project\Physics_Boi\Physics Project (new data structure)\Physics Project (new data structure)\Assets\Sensor Images\Empty.png"),
            new Bitmap(@"D:\C#\Physics Project\Physics_Boi\Physics Project (new data structure)\Physics Project (new data structure)\Assets\Sensor Images\Empty.png"),
            new Bitmap(@"D:\C#\Physics Project\Physics_Boi\Physics Project (new data structure)\Physics Project (new data structure)\Assets\Sensor Images\Empty.png"),
            new Bitmap(@"D:\C#\Physics Project\Physics_Boi\Physics Project (new data structure)\Physics Project (new data structure)\Assets\Sensor Images\Empty.png")
        };
        
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

        public static float[] RecommendedFrequency = new float[]
        {
            0,
            30,
            300,
            100,
            2,
            100
        };
        


    }



    public class RandomColor
    {
        private Color[] warmColors = new Color[]
        {
        Color.Coral,
        Color.DarkRed,
        Color.DarkOrange,
        Color.Brown,
        Color.Fuchsia,
        Color.Red,
        Color.Chocolate,
        Color.IndianRed,
        Color.Tomato,
        Color.Firebrick,
        Color.DeepPink,
        Color.Magenta,
        Color.Violet
        };
        private Color[] coolColors = new Color[]
        {
        Color.Blue,
        Color.Purple,
        Color.BlueViolet,
        Color.LightSeaGreen,
        Color.MediumOrchid,
        Color.Navy,
        Color.DarkGreen,
        Color.Green,
        Color.DarkViolet,
        Color.DarkSlateGray,
        Color.SteelBlue,
        Color.Teal,
        Color.DodgerBlue
        };

        private int[] timesUsedWarm;
        private int[] timesUsedCool;
        private int leastTimesUsed;

        private Random tempRandom = new Random();


        public RandomColor()
        {
            timesUsedWarm = new int[warmColors.Length];
            timesUsedCool = new int[coolColors.Length];
            leastTimesUsed = 0;
        }

        public Color GetColor(bool cool = true, bool colorIsUdes = true)
        {
            int[] timesUsed;
            if (cool)
                timesUsed = timesUsedCool;
            else
                timesUsed = timesUsedWarm;


            List<int> usableColors = new List<int>();

            for (int i = 0; i < timesUsed.Length; i++)
                if (timesUsed[i] == leastTimesUsed)
                    usableColors.Add(i);

            int chosenColorIndex = usableColors[tempRandom.Next(usableColors.Count)];

            if (usableColors.Count == 1)
                leastTimesUsed++;

            timesUsed[chosenColorIndex]++;

            if (cool)
                return coolColors[chosenColorIndex];
            else
                return warmColors[chosenColorIndex];

        }


    }



}
