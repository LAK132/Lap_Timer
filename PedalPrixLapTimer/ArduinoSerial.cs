using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace PedalPrixLapTimer
{
    //Exception classes
    public class ArduinoSerialException: Exception
    {
        public ArduinoSerialException() 
        {
        }

        public ArduinoSerialException(string message)
            : base(message)
        {
        }
    }

    public class ArduinoSerialSendException : Exception
    {
        public ArduinoSerialSendException()
        {
        }

        public ArduinoSerialSendException(string message)
            : base(message)
        {
        }
    }

    public class ArduinoSerialReadException : Exception
    {
        public ArduinoSerialReadException()
        {
        }

        public ArduinoSerialReadException(string message)
            : base(message)
        {
        }
    }

    public class ArduinoSerialEchoException : Exception
    {
        public ArduinoSerialEchoException()
        {
        }

        public ArduinoSerialEchoException(string message)
            : base(message)
        {
        }
    }

    public class ArduinoSerialOpenException : Exception
    {
        public ArduinoSerialOpenException()
        {
        }

        public ArduinoSerialOpenException(string message)
            : base(message)
        {
        }
    }

    public class ArduinoSerialSetupException : Exception
    {
        public ArduinoSerialSetupException()
        {
        }

        public ArduinoSerialSetupException(string message)
            : base(message)
        {
        }
    }

    public class ArduinoSerialNotSetupException : Exception
    {
        public ArduinoSerialNotSetupException()
        {
        }

        public ArduinoSerialNotSetupException(string message)
            : base(message)
        {
        }
    }

    //main class
    class ArduinoSerial
    {
        private static string port; //Port number to use
        private static int baud; //Baud rate to use
        private static string echo; //The echo code to use
        private static string trigger; //The trigger code
        private static bool isSetUp = false; //Whether or not the connection has been set up yet
        public static SerialPort serialPort = new SerialPort(); //The serial port object to use
        private static int readTimeout = 1000;
        private static int writeTimeout = 4000;

        private static ArduinoSerialOpenException errOpen = new ArduinoSerialOpenException("Failed to open and send message over serial port");
        private static ArduinoSerialSetupException errSetup = new ArduinoSerialSetupException("Already set up");
        private static ArduinoSerialEchoException errEcho = new ArduinoSerialEchoException("Wrong echo code recieved");
        private static ArduinoSerialSendException errSend = new ArduinoSerialSendException("Failed to send message");
        private static ArduinoSerialNotSetupException errNotSetup = new ArduinoSerialNotSetupException("Not set up");
        private static ArduinoSerialReadException errRead = new ArduinoSerialReadException("Failed to read serial");

        //Set up the serial connection
        public bool setup(string portIn, int baudIn, string echoIn, string triggerIn)
        {
            if (!isSetUp)
            {
                port = portIn;
                baud = baudIn;
                echo = echoIn;
                trigger = triggerIn;
                //serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                if (serialPort.IsOpen)
                {
                    try
                    {
                        serialPort.Close();
                        serialPort.PortName = port;
                        serialPort.BaudRate = baud;
                        serialPort.WriteTimeout = writeTimeout;
                        serialPort.ReadTimeout = readTimeout;
                    }
                    catch
                    {
                        throw errOpen;
                    }
                }
                else
                {
                    serialPort.PortName = port;
                    serialPort.BaudRate = baud;
                    serialPort.WriteTimeout = writeTimeout;
                    serialPort.ReadTimeout = readTimeout;
                }

                try
                {
                    serialPort.Open();
                }
                catch
                {
                    throw errOpen;
                }

                try
                {
                    serialPort.WriteLine(echo);
                }
                catch
                {
                    throw errSend;
                }

                try
                {
                    if (serialPort.ReadLine() == "echo")
                    {
                        isSetUp = true;
                        return true;
                    }
                    else
                    {
                        isSetUp = false;
                        throw errEcho;
                    }
                }
                catch
                {
                    throw errRead;
                }
            }
            else
            {
                throw errSetup;
            }
        }

        //Triggered event
        //public event EventHandler HasTriggered;

        /*private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //if(serialPort.ReadLine() == trigger)
                //{
                    //Triggered(EventArgs.Empty);
                //}
            }
            catch
            {
                throw errRead;
            }
        }*/

        /*protected virtual void Triggered(EventArgs e)
        {
            EventHandler handler = HasTriggered;
            if (handler != null)
            {
                handler(this, e);
            }
        }*/

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
                    throw errSend;
                }
            }
            else
            {
                throw errNotSetup;
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
                }
                catch
                {
                    throw errSend;
                }
                try
                {
                    return serialPort.ReadLine();
                }
                catch
                {
                    throw errRead;
                }
            }
            else
            {
                throw errNotSetup;
            }
        }

        //Converts the given int to a string via a char
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

        //Converts the given string to an int via a char
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

        //Close the serial port
        public void disconnect()
        {
            try 
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    isSetUp = false;
                }
            }
            catch
            {
                throw errOpen;
            }
        }
    }
}
