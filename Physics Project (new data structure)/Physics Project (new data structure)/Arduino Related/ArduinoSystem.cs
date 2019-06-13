using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Physics_Project__new_data_structure_
{
    public class ArduinoSystem
    {
        #region Properties
        // Private
        //
        private const int SERIAL_RATE = 1000000;
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
        public bool SendCommand(string command)
        {
            Port.Write(command);

            string ok = Port.ReadLine();

            // For Debug:
            //
            //if (!ok.Contains("ok"))
            //{
            //    MessageBox.Show("Error at SendCommand! | command = " + command + " | ok = " + ok);
            //    return false;
            //}

            return true;
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
        /// <summary>
        /// <para>Read data from port as a string.</para>
        /// </summary>
        /// <returns></returns>
        public string ClearBuffer()
        {
            return Port.ReadExisting();
        }
        //
        public string ReadLine()
        {
            string s = Port.ReadLine();
            return s;
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

        public void ReadPort_TimeAndData(ref int index, ref float data, ref float time)
        {
            string s = ReadLine();


            string[] sBuffer = s.Split(',');

            index = int.Parse(sBuffer[0]);
            data = float.Parse(sBuffer[1]);
            time = float.Parse(sBuffer[2]);

            if (Port.BytesToRead == 0)
                HasData = false;



        }

        //
        /// <summary>
        /// <para>Open the serial port.</para>
        /// </summary>
        public void PortOpen()
        {
            if (!Port.IsOpen)
            {
                Port.Open();
                //Thread.Sleep(1000);
            }
        }
        //
        /// <summary>
        /// <para>Close the serial port.</para>
        /// </summary>
        public void PortClose()
        {
            if (Port.IsOpen)
                Port.Close();
        }
        //
        #endregion

        private void SetComPort()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                Port = new SerialPort(port, SERIAL_RATE);
                if (DetectArduino())
                {
                    Port.PortName = port;
                    HasPort = true;
                    Port.DataReceived += Port_DataReceived;
                    PortOpen();
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
                PortOpen();

                if (SendCommand("marco"))
                {
                    PortClose();
                    return true;
                }

                PortClose();
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
