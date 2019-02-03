using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Physics_Project
{
    public class Sensor
    {
        int _Type;
        public int Type { get { return _Type; } }
        public int ConnectionNumber;
        public Connection Con;
        public int Measurement = 0;
        public float SampleRate = 300;
        public float SampleRate_Seconds
        {
            get { return 16000000 / SampleRate; }
        }

        public Sensor(int type, int connection_num, float sample_rate = 300)
        {
            _Type = type;
            ConnectionNumber = connection_num;
            Con = new Connection(connection_num);
            Measurement = 0;
            SampleRate = sample_rate;
        }
        public Sensor(int type, Connection connection, float sample_rate = 300)
        {
            _Type = type;
            Con = new Connection(connection);
            Measurement = 0;
            SampleRate = sample_rate;
        }


        public void SetType(int type)
        {
            _Type = type;
        }
    }



    public struct Connection
    {
        public int digPin1;
        public int digPin2;
        public int digPin3;
        public int interruptPin;
        
        public int anPin1;
        public int anPin2;


        public Connection(int connection_num)
        {
            switch (connection_num)
            {
                // Interrupt Pins: 2, 3, 18, 19, 20, 21
                case 0:
                    digPin1 = 4;
                    digPin2 = 5;
                    digPin3 = 6;
                    interruptPin = 2;

                    anPin1 = 0;
                    anPin2 = 1;
                    break;

                case 1:
                    digPin1 = 7;
                    digPin2 = 8;
                    digPin3 = 9;
                    interruptPin = 3;

                    anPin1 = 2;
                    anPin2 = 3;
                    break;

                case 2:
                    digPin1 = 10;
                    digPin2 = 11;
                    digPin3 = 12;
                    interruptPin = 18;

                    anPin1 = 4;
                    anPin2 = 5;
                    break;

                case 3:
                    digPin1 = 13;
                    digPin2 = 14;
                    digPin3 = 15;
                    interruptPin = 19;

                    anPin1 = 6;
                    anPin2 = 7;
                    break;

                case 4:
                    digPin1 = 23;
                    digPin2 = 24;
                    digPin3 = 25;
                    interruptPin = 20;

                    anPin1 = 8;
                    anPin2 = 9;
                    break;

                case 5:
                    digPin1 = 26;
                    digPin2 = 27;
                    digPin3 = 28;
                    interruptPin = 21;

                    anPin1 = 10;
                    anPin2 = 11;
                    break;

                default:
                    digPin1 = -1;
                    digPin2 = -1;
                    digPin3 = -1;
                    interruptPin = -1;

                    anPin1 = -1;
                    anPin2 = -1;
                    break;
            }
        }
        public Connection(Connection connection)
        {
            digPin1 = connection.digPin1;
            digPin2 = connection.digPin2;
            digPin3 = connection.digPin3;
            interruptPin = connection.interruptPin;

            anPin1 = connection.anPin1;
            anPin2 = connection.anPin2;
        }


        public override bool Equals(object obj)
        {
            if (!(obj is Connection))
            {
                return false;
            }

            var connection = (Connection)obj;
            return digPin1 == connection.digPin1 &&
                   digPin2 == connection.digPin2 &&
                   digPin3 == connection.digPin3 &&
                   interruptPin == connection.interruptPin &&
                   anPin1 == connection.anPin1 &&
                   anPin2 == connection.anPin2;
        }
    }


}





