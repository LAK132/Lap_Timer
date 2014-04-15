using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace PedalPrixLapTimer
{
    class ArduinoSerial
    {
        private static string port; //Port number to use
        private static int baud; //Baud rate to use
        private static string echo; //The echo code to use
        private static bool isSetUp = false; //Whether or not the connection has been set up yet
        private static SerialPort serialPort = new SerialPort(); //The serial port object to use

        public static bool setup(string port, int baud, string echoCode)
        {
            string echo = "";
            if (!isSetUp)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }

                if (echo == echoCode)
                {
                    isSetUp = true;
                    return true;
                }
                else
                {
                    isSetUp = false;
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public static bool sendMsg(string message)
        {
            if(isSetUp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string askMsg(string message)
        {
            if (isSetUp)
            {
                return "";
            }
            else
            {
                return "";
            }
        }
    }
}
