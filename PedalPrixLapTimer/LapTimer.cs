using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
using PedalPrixLapTimer;

namespace PedalPrixLapTimer
{
    public partial class Form1 : Form
    {
        ArduinoSerial car1 = new ArduinoSerial();
        //ArduinoSerial car2 = new ArduinoSerial();
        //ArduinoSerial car3 = new ArduinoSerial();
        Stopwatch swRace = new Stopwatch();     // Used to time total race time
        Stopwatch swLap = new Stopwatch();      // Used to time each lap
        TimeSpan lapTime;
        TimeSpan pitTime;
        TimeSpan raceTime;
        public int totalLaps = 0;
        public int riderLaps = 0;
        public bool inPits = false;
        string[] riderDataBase = new string[10] { "", "", "", "", "", "", "", "", "", "" };
        int RDB = 0;
        int RAI = 0;
        int LVI = 0;
        delegate void LapCallback();

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public Form1()
        {
            car1.hasTriggered += new PedalPrixLapTimer.ArduinoSerial.Triggered(car1_Lapped);
            InitializeComponent();
            _Form1 = this;
            buttonPitOut.Enabled = false;
            button_Reset.Enabled = false;
            button_Pause.Enabled = false;
            buttonLap.Enabled = false;
            buttonPitIn.Enabled = false;
            CenterToScreen();
            //MessageBox.Show("Program Writen By Lucas Kleiss");
        }

        public static Form1 _Form1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            textBoxCurrentRider.Text = riderDataBase[LVI];
            swLap.Start();
            swRace.Start();
            button_Reset.Enabled = false;
            button_Start.Enabled = false;
            buttonPitOut.Enabled = false;
            button_Reset.Enabled = false;
            button_Pause.Enabled = true;
            buttonLap.Enabled = true;
            buttonPitIn.Enabled = true;
        }

        // Happens every 100 milliseconds when timer1 ticks
        // Used to update form with new time

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update lap time
            if (swLap.IsRunning) // If timer is running update form otherwise do nothing
            {
                TimeSpan tsLap = swLap.Elapsed;                // declare new variable to hold the time elapsed since start of lap

                // Update current lap time 
                if (inPits) // Vehicle is on race track 
                {
                                    // Convert tsLap from Timespan type to string type so it can be displayed on form
                    textBoxPitTime.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", tsLap.Hours, tsLap.Minutes, tsLap.Seconds, tsLap.Milliseconds / 10);
                }
                // Vehicle is in pits
                else
                {
                    textBoxLapTime.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", tsLap.Hours, tsLap.Minutes, tsLap.Seconds, tsLap.Milliseconds / 10); 
                }
                textBoxRiderLaps.Text = riderLaps.ToString();
                textBoxTotalLaps.Text = totalLaps.ToString();
               
            }

            // Update race time
            if (swRace.IsRunning) // If timer is running update form otherwise do nothing
            {
                TimeSpan tsRace = swRace.Elapsed;                // declare new variable to hold the time elapsed since start of race

                    // Convert tsLap from Timespan type to string type so it can be displayed on form
                    textBoxRaceTime.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", tsRace.Hours, tsRace.Minutes, tsRace.Seconds, tsRace.Milliseconds / 10);
            }

        }

        private void button_Pause_Click(object sender, EventArgs e)
        {
            swLap.Stop();
            swRace.Stop();
            TimeSpan ts = swLap.Elapsed;
            button_Reset.Enabled = true;
            button_Start.Enabled = true;
            buttonLap.Enabled = false;
            buttonPitIn.Enabled = false;
            buttonPitOut.Enabled = false;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            textBoxLapTime.Text = elapsedTime;
            button_Pause.Enabled = false;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            // reset lap time
            TimeSpan ts = swLap.Elapsed;
            swLap.Reset();
            swRace.Reset();
            
            // Format and display the TimeSpan value.
            ts = TimeSpan.Zero;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            textBoxLapTime.Text = elapsedTime;
            textBoxRaceTime.Text = elapsedTime;

            textBoxCurrentRider.Clear();
            textBoxRiderLaps.Clear();
            textBoxTotalLaps.Clear();

            riderLaps = 0;
            totalLaps = 0;
        }

        private void buttonLap_Click(object sender, EventArgs e)
        {
            //TimeSpan ts = swLap.Elapsed;
            ////Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //swLap.Reset();
            //swLap.Start();
            //riderLaps++;     // increment the number of laps
            //totalLaps++;     // increment the total laps of the race
            //richTextBox1.AppendText(System.Environment.NewLine + totalLaps + " ,\t" + riderLaps + " ,\t" + riderDataBase[LVI] + " ,\t" + elapsedTime);//---------------------------------------------
            //richTextBox1.SelectionStart = richTextBox1.Text.Length;     // Scroll to end of list
            //richTextBox1.ScrollToCaret();
            lap();
        }

        public void lap()
        {
            if (this.richTextBox1.InvokeRequired)
            {
                LapCallback d = new LapCallback(lap);
                this.Invoke(d, new object[] { });
            }
            else
            {
                TimeSpan ts = swLap.Elapsed;
                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                swLap.Reset();
                swLap.Start();
                riderLaps++;     // increment the number of laps
                totalLaps++;     // increment the total laps of the race
                richTextBox1.AppendText(System.Environment.NewLine + totalLaps + " ,\t" + riderLaps + " ,\t" + riderDataBase[LVI] + " ,\t" + elapsedTime);
                richTextBox1.SelectionStart = richTextBox1.Text.Length;     // Scroll to end of list
                richTextBox1.ScrollToCaret();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //richTextBox1.SaveFile();

 
           // Create a SaveFileDialog to request a path and file name to save to.
           SaveFileDialog saveFile1 = new SaveFileDialog();

           // Initialize the SaveFileDialog to specify the RTF extension for the file.
           saveFile1.DefaultExt = "*.rtf";
           saveFile1.Filter = "RTF Files|*.rtf";

           // Determine if the user selected a file name from the saveFileDialog.
           if(saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
              saveFile1.FileName.Length > 0) 
           {
              // Save the contents of the RichTextBox into the file.
              richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
           }


        }

        private void textBoxRider_TextChanged(object sender, EventArgs e)
        {
            //riderLaps = 0;
        }

        private void comboBoxRider_SelectedIndexChanged(object sender, EventArgs e)
        {
         /* //int currentRider;
            //String lastRider;
            if (lastRider == comboBoxRider.Text)
            {       
            }
            else
            {
                lastRider = comboBoxRider.Text;
            }
            currentRider = riderLaps;
            riderLaps = 0; */
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(" , " + textBoxComment.Text);
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();

        }
         
        private void buttonPitIn_Click(object sender, EventArgs e)
        {
            TimeSpan ts = swLap.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            swLap.Reset();
            swLap.Start();
            // Increment total time
            riderLaps++;     // increment the number of laps
            totalLaps++;
            richTextBox1.AppendText(System.Environment.NewLine + totalLaps + " ,\t" + riderLaps + " ,\t" + riderDataBase[LVI] + " ,\t" + elapsedTime + " ,\tPit in ,\t " );
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            textBoxLapTime.Text = elapsedTime;
            textBoxLapTime.Clear();
            buttonPitIn.Enabled = false;
            buttonPitOut.Enabled = true;
            buttonLap.Enabled = false;
            inPits = true;
        }

        private void buttonPitOut_Click(object sender, EventArgs e)
        {
            LVI++;
            textBoxCurrentRider.Text = riderDataBase[LVI];
            TimeSpan ts = swLap.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            swLap.Reset();
            swLap.Start();
            // increment total time
            richTextBox1.AppendText(System.Environment.NewLine + totalLaps + " ,\t" + riderLaps + " ,\t" + riderDataBase[LVI] + " ,\t" + elapsedTime + " ,\tPit out ,\t");//--------------------------------------
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            textBoxPitTime.Text = elapsedTime;
            buttonPitIn.Enabled = true;
            buttonPitOut.Enabled = false;
            buttonLap.Enabled = true;
            inPits = false;
            textBoxPitTime.Clear();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            comboBoxNextRider.Items.Add(textBoxRiderName.Text);
            textBoxRiderName.Clear();
            comboBoxNextRider.SelectedIndex = (RDB);
            RDB++;
        }

        private void buttonAddAsNext_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(comboBoxNextRider.Text);
            riderDataBase[RAI] = (comboBoxNextRider.Text);
            RAI++;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            
            if(textBoxInternet.Text.Contains("http://"))
            {
                Navigate(textBoxInternet.Text);
            }
            else if (textBoxInternet.Text.Contains("https://"))
            {
                Navigate(textBoxInternet.Text);
            }
            else if (textBoxInternet.Text.Contains("ftp://"))
            {
                Navigate(textBoxInternet.Text);
            }
            else if (textBoxInternet.Text.Contains("ftps://"))
            {
                Navigate(textBoxInternet.Text);
            }
            else
            {
                Navigate("http://www.google.com/search?q=" + textBoxInternet.Text);
            }
        }

        private void Navigate(String address)
        {
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }

            catch (System.UriFormatException)
            {
                MessageBox.Show("URL Unavalible");
                return;
            }
        }

        //Arduino code
        private void car1_Lapped()
        {
            if (buttonLap.Enabled)
            {
                lap();
            }
        }

        private void buttonSerialConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(car1.setup(comboBoxComPort.Text, Convert.ToInt16(comboBoxBaudRate.Text), textBoxEchoCode.Text, textBoxTriggerCode.Text))
                {
                    MessageBox.Show("Succesfully Connected");
                }
            }
            catch(ArduinoSerialOpenException)
            {
                MessageBox.Show("Failed to open serial port");
            }
            catch (ArduinoSerialSendException)
            {
                MessageBox.Show("Failed to write to serial port");
            }
            catch (ArduinoSerialEchoException)
            {
                MessageBox.Show("Failed to receive or received incorrect echo code serial port");
            }
            catch (ArduinoSerialReadException)
            {
                MessageBox.Show("Failed to read from serial port");
            }
            catch (ArduinoSerialSetupException)
            {
                MessageBox.Show("Already setup/connected");
            }
            catch
            {
                MessageBox.Show("Invalid Parameters");
            }
        }

        private void buttonSerialDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                car1.disconnect();
            }
            catch
            {

            }
        }

        private void comboBoxComPort_DropDown(object sender, EventArgs e)
        {
            comboBoxComPort.Items.Clear();
            try
            {
                comboBoxComPort.Items.AddRange(SerialPort.GetPortNames());
            }
            catch
            {
                MessageBox.Show("Failed to get port names");
            }
        }

        /*
        private void car2_Lapped(object sender, EventArgs e)
        {

        }

        private void car3_Lapped(object sender, EventArgs e)
        {

        }
        */
    }
}