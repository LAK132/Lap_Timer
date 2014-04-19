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

        public static bool setup(string portIn, int baudIn, string echoIn)
        {
            echo = echoIn;
            if (!isSetUp)
            {
                port = portIn;
                baud = baudIn;
                echo = echoIn;
                serialPort.PortName = port;
                serialPort.BaudRate = baud;

                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
                
                serialPort.WriteLine(echo);

                if (serialPort.ReadLine() == echo)
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

        //converts the given int to a string via a char
        public static string intToString(int convert)
        {
            if (convert <= 126 && convert >= 32)
            {
                char convertCh = (char)convert;
                return convertCh.ToString();
            }
            else
            {
                return null;
            }
        }

        //converts the given string to an int via a char
        public static int[] stringToInt(string convert)
        {
            int stringLength = convert.Length;
            int[] intArray = { 0 };
            char[] charArray = { (char)0 };

            for(int i = 0; i <= stringLength; i++)
            {
                charArray[i] = Convert.ToChar(convert[i]);
                if (Convert.ToInt16(charArray[i]) <= 126 && Convert.ToInt16(charArray[i]) >= 32)
                {
                    intArray[i] = Convert.ToInt16(charArray[i]);
                }
                else
                {
                    int[] a = { 0 };
                    return a;
                }
            }

            return intArray;
        }
    }
}
