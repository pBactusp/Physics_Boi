using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Physics_Project
{
    public class ArduinoSystem
    {
        #region Properties
        // Private
        //
        private SerialPort Port;
        private byte[] bufferF = new byte[12];
        //
        // Public
        //
        public bool HasPort = false;
        public bool HasData = false;
        //
        #endregion

        private byte[] buffer_1B = new byte[1];
        private byte[] buffer_5BCommand = new byte[5];


        public ArduinoSystem()
        {
            SetComPort();
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Port.BytesToRead > 0)
                HasData = true;
        }

        #region Methods
        // Public
        //
        /// <summary>
        /// <para>Send a command with up to 4 arguments to the system.</para>
        /// </summary>
        /// <param name="commandNum"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <param name="arg3"></param>
        /// <param name="arg4"></param>
        public void SendCommand(int commandNum, int arg1 = 0, int arg2 = 0, int arg3 = 0, int arg4 = 0)
        {
            buffer_5BCommand[0] = (byte)commandNum;
            buffer_5BCommand[1] = (byte)arg1;
            buffer_5BCommand[2] = (byte)arg2;
            buffer_5BCommand[3] = (byte)arg3;
            buffer_5BCommand[4] = (byte)arg4;

            Port.Write(buffer_5BCommand, 0, 5);
            //Port.Write(new byte[] { 48, 48, 48, 48, 48 }, 0, 5);


        }
        //
        /// <summary>
        /// <para>Send 1 byte to the system.</para>
        /// </summary>
        /// <param name="arg"></param>
        public void SendCommand_1B(int arg)
        {
            buffer_1B[0] = (byte)arg;
            Port.Write(buffer_1B, 0, 1);
        }
        //
        public void SendSensor(params Sensor[] sensors)
        {
            SendCommand(5, sensors.Length);

            foreach (Sensor sensor in sensors)
            {
                /*byte[] tempBuffer = new byte[]
                    {
                        Convert.ToByte(sensor.Type),
                        Convert.ToByte(sensor.Con.digPin1),
                        Convert.ToByte(sensor.Con.digPin2),
                        Convert.ToByte(sensor.Con.digPin3),
                        Convert.ToByte(sensor.Con.interruptPin),
                        Convert.ToByte(sensor.Con.anPin1),
                        Convert.ToByte(sensor.Con.anPin2)
                    };
                Port.Write(tempBuffer, 0, tempBuffer.Length);*/


                int byteCounter = 0;
                while ((byteCounter + 1) * 255 < sensor.SampleRate)
                    byteCounter++;

                byte[] tempBuffer = new byte[] { (byte)sensor.Type, (byte)sensor.ConnectionNumber, (byte)byteCounter, (byte)(sensor.SampleRate - byteCounter * 255) };
                Port.Write(tempBuffer, 0, tempBuffer.Length);
                
            }

        }
        //
        /// <summary>
        /// <para>Read data from port as a string.</para>
        /// </summary>
        /// <returns></returns>
        public string ReadPortString()
        {
            int count = Port.BytesToRead;
            string ret = "";
            while (count > 0)
            {
                ret += Convert.ToChar(Port.ReadByte());
                count--;
            }
            HasData = false;
            return ret;
        }
        //
        /// <summary>
        /// <para>Read data from port as a float.</para>
        /// </summary>
        /// <returns></returns>
        public float ReadPortFloat()
        {
            Thread.Sleep(20);
            byte[] buffer = new byte[Port.BytesToRead];

            Port.Read(buffer, 0, buffer.Length);

            HasData = false;

            return float.Parse(Encoding.ASCII.GetString(buffer));
        }

        public void ReadPort_TimeAndData(ref float data, ref float time)
        {
            string[] sBuffer = Port.ReadLine().Split(',');

            data = float.Parse(sBuffer[0]);
            time = float.Parse(sBuffer[1]);

            if (Port.BytesToRead == 0)
                HasData = false;
        }

        //
        /// <summary>
        /// <para>Open the serial port.</para>
        /// </summary>
        public void PortOpen()
        {
            Port.Open();
        }
        //
        /// <summary>
        /// <para>Close the serial port.</para>
        /// </summary>
        public void PortClose()
        {
            Port.Close();
        }
        //
        #endregion

        private void SetComPort()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                Port = new SerialPort(port, 9600);
                if (DetectArduino())
                {
                    Port.PortName = port;
                    HasPort = true;
                    Port.DataReceived += Port_DataReceived;
                    break;
                }
                else
                    HasPort = false;
            }
        }
        private bool DetectArduino()
        {
            try
            {
                if (!Port.IsOpen)
                    Port.Open();
                SendCommand(9);
                Thread.Sleep(1000); ////////////////////////////////////////

                string debug_s = ReadPortString();
                if (debug_s.Contains("boi"))
                {
                    Port.Close();
                    return true;
                }

                Port.Close();
                return false;
            }
            catch
            {
                return false;
            }
        }


        public string GetPortName()
        {
            return Port.PortName;
        }

    }
}
