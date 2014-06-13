using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Timers;

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
        public  static SerialPort serialPort = new SerialPort(); //The serial port object to use
        private static int readTimeout = 4000;
        private static int writeTimeout = 4000;
        public  static string serialRead = null;
        private static int timerCount = 0;
        private static string serialLine = null;
        private static Timer t = new Timer();
        private static bool timerElapsed = false;

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
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                t.Elapsed += new ElapsedEventHandler(timerTick);

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

                //try
                //{
                    if (serialReadLine() == "echo")
                    {
                        isSetUp = true;
                        return true;
                    }
                    else
                    {
                        isSetUp = false;
                        throw errEcho;
                    }
                //}
                //catch
                //{
                //    throw errRead;
                //}
            }
            else
            {
                throw errSetup;
            }
        }

        //Triggered event
        public delegate void Triggered();

        public event Triggered hasTriggered;

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string read = null;
                try
                {
                    read = serialPort.ReadLine();
                }
                catch
                {
                    read = null;
                }
                if(read == trigger)
                {
                    trig();
                }
                else if(read == "\n" || read == "\r" || read == "\n\r" || read == null)
                {

                }
                else
                {
                    serialReadLine(read);
                }
            }
            catch
            {
                isSetUp = false;
                serialPort.Close();
                throw errRead;
            }
        }

        protected virtual void trig()
        {
            if (hasTriggered != null)
            {
                hasTriggered();
            }
        }

        public static string serialReadLine()
        {
            string tempLine = "";
            if (serialRead != null)
            {
                tempLine = serialRead;
                serialRead = null;
                serialLine = null;
                return tempLine;
            }
            else
            {
                try
                {
                    t.Interval = readTimeout;
                    t.Start();
                    while(serialRead == null)
                    {
                        if (timerElapsed)
                        {
                            t.Stop();
                            timerElapsed = false;
                            throw errRead;
                        }
                    }
                    t.Stop();
                    timerElapsed = false;
                    if (serialRead != null)
                    {
                        tempLine = serialRead;
                        serialRead = null;
                        serialLine = null;
                        return tempLine;
                    }
                    else
                    {
                        throw errRead;
                    }
                }
                catch
                {
                    try
                    {
                        Task r = readLine();
                        r.Start();
                        r.Wait();
                        tempLine = serialLine;
                    }
                    catch
                    {
                        serialLine = "";
                        throw errRead;
                    }
                    serialRead = null;
                    serialLine = null;
                    return tempLine;
                }
            }
        }

        public static void serialReadLine(string set)
        {
            serialRead = set;
        }

        //Async tasks for reading serialPort
        static async Task readLine()
        {
            Task<string> m = readTheLine();
            serialLine = await m;
            return;
        }

        static async Task<string> readTheLine()
        {
            t.Interval = readTimeout;
            t.Start();
            while (serialRead == null)
            {
                if (timerElapsed)
                {
                    t.Stop();
                    timerElapsed = false;
                    throw errRead;
                }
            }
            if (serialRead != null)
            {
                t.Stop();
                return serialRead;
            }
            else
            {
                throw errRead;
            }
        }

        private static void timerTick(object source, ElapsedEventArgs e)
        {
            timerElapsed = true;
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
                    return serialReadLine();
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
                serialPort.Close();
                isSetUp = false;
            }
            catch
            {
                throw errOpen;
            }
        }
    }
}
