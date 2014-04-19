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
        private static string trigger; //The trigger code
        private static bool isSetUp = false; //Whether or not the connection has been set up yet
        private static SerialPort serialPort = new SerialPort(); //The serial port object to use
        private static object sender;

        private static ArgumentException err1 = new ArgumentException("Failed to open and send message over serial port");
        private static ArgumentException err2 = new ArgumentException("Already set up");
        private static ArgumentException err3 = new ArgumentException("Wrong echo code recieved");
        private static ArgumentException err4 = new ArgumentException("Failed to send message");
        private static ArgumentException err5 = new ArgumentException("Not set up");
        private static ArgumentException err6 = new ArgumentException("Serial read timeout");
        private static ArgumentException err7 = new ArgumentException("Failed to send and/or receive");
        private static ArgumentException err8 = new ArgumentException("Failed to read serial");

        //Set up the serial connection
        public bool setup(object senderIn, string portIn, int baudIn, string echoIn, string triggerIn)
        {
            echo = echoIn;
            if (!isSetUp)
            {
                sender = senderIn;
                port = portIn;
                baud = baudIn;
                echo = echoIn;
                trigger = triggerIn;
                serialPort.PortName = port;
                serialPort.BaudRate = baud;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }

                try
                {
                    serialPort.Open();
                    serialPort.WriteLine(echo);
                }
                catch
                {
                    throw err1;
                }

                try
                {
                    if (serialPort.ReadLine() == echo)
                    {
                        isSetUp = true;
                        return true;
                    }
                    else
                    {
                        isSetUp = false;
                        throw err3;
                    }
                }
                catch
                {
                    throw err6;
                }
            }
            else
            {
                throw err2;
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if(serialPort.ReadLine() == trigger)
                {
                    Triggered(EventArgs.Empty);
                }
            }
            catch
            {
                throw err8;
            }
        }

        protected virtual void Triggered(EventArgs e)
        {
            EventHandler handler = HasTriggered;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        //Send a message to the arduino
        public static bool sendMsg(string message)
        { 
            if(isSetUp)
            {
                try
                {
                    serialPort.WriteLine(message);
                    return true;
                }
                catch
                {
                    throw err4;
                }
            }
            else
            {
                throw err5;
            }
        }

        //Send and receive from arduino
        public static string askMsg(string message)
        {
            if (isSetUp)
            {
                try
                {
                    serialPort.WriteLine(message);
                    return serialPort.ReadLine();
                }
                catch
                {
                    throw err7;
                }
            }
            else
            {
                throw err5;
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

        //Lapped event
        public event EventHandler HasTriggered;
    }
}
