using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;
using System.Web.Script.Serialization;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace HRandSpO2Reader
{
    public partial class Form1 : Form
    {
        int maksm = 600, minm = 0;
        private bool acsessState;
        private string dataStorage;
        private bool buttonCheck;
        public delegate void AddDataDelegate(String myString,int methodType);
        public AddDataDelegate myDelegate;
        private static HttpClient httpClient;
        private string baseUrl;


        public Form1()
        {
            baseUrl = "http://localhost:5000";
            httpClient = new HttpClient();
            InitializeComponent();
            
        }

      
        public void SetButtonCheck(bool buttonState)
        {
            buttonCheck = buttonState;
        }
        public bool GetButtonCheck()
        {
            return buttonCheck;
        }
        public void SetDataStorage(string data)
        {
            dataStorage += data;
        }
        public string GetDataStorage()
        {
            return dataStorage;
        }
        public void RemoveFromDataStorage(int startIndex, int lengthToRemove)
        {
            dataStorage = dataStorage.Remove(startIndex, lengthToRemove);
           
        }
        public void CleanDataStorege()
        {
            dataStorage = "";
        }
        public void AddDataMethod(String myString,int methodType)
        {
            if(methodType == 1)
            {
                rawTextBox.AppendText(myString);
            } 
            else if(methodType == 2)
            {
                rawTextBox.Text.Remove(0,9000);
            }
            
            
        }
     
        private void serialReciever(object sender,SerialDataReceivedEventArgs e)
        {
            if (this.GetButtonCheck() == true)
            {
                string data = serialPort1.ReadExisting();
                this.SetDataStorage(data);
                rawTextBox.Invoke(this.myDelegate, new Object[] { data, 1 });
            }
          


        }
        
        private  void SerialPortListenDefault()
        {
            serialPort1.DataReceived+= new SerialDataReceivedEventHandler(serialReciever);
            
           
           

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer5.Start();
            this.myDelegate = new AddDataDelegate(AddDataMethod);
            this.dataStorage = "";
                  
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer2.Stop();
            
            double counter = 0;
            double maxSpo = 0;
            double minSpo1 = 262123;
            double minSpo2 = 262123;
            double maxCount = 0;
            double minSpoCount1 = 0;
            double minSpoCount2 = 0;
            double maxHr = 0;
            double minHr1 = 262123;
            double minHr2 = 262123;
            double maxCountHr = 0;
            double minCountHr1 = 0;
            double minCountHr2 = 0;
            double maxHrFirstPeak = 0;
            double maxCountHrFirstPeak =0;
                double spoDC;
                double hrDC;
                double r;
                double heartRate;
                double totHr=0;
                double totR = 0;

                string pattern = @"(?:(?'h'h\d+)|(?'s's\d+)){2}";
            RegexOptions options = RegexOptions.Multiline;
            string sampleList = this.GetDataStorage();
                int i = 0;

                foreach (Match match in Regex.Matches(sampleList, pattern, options))
                {
                    counter++;
                    
                    GroupCollection groups = match.Groups;

                    int spo = Convert.ToInt32((groups["s"].Value.Trim('s')));
                    int hr = Convert.ToInt32((groups["h"].Value.Trim('h')));
                    maksm++;
                    minm++;

                    if (counter > (50 + (i * 200)) && counter < (100 + (i * 200)))
                    {
                        if (spo < minSpo1)
                        {
                            minSpo1 = spo;
                            minSpoCount1 = counter;
                        }
                        if (hr < minHr1)
                        {
                            minHr1 = hr;
                            minCountHr1 = counter;
                        }
                        if (hr > maxHrFirstPeak)
                        {
                            maxHrFirstPeak = hr;
                            maxCountHrFirstPeak = counter;
                        }
                    }
                    if (counter > (150 + (i * 200)) && counter < (200 + (i * 200)))
                    {
                        if (spo > maxSpo)
                        {
                            maxSpo = spo;
                            maxCount = counter;
                        }
                        if (hr > maxHr)
                        {
                            maxHr = hr;
                            maxCountHr = counter;
                        }
                        if (spo < minSpo2)
                        {
                            minSpo2 = spo;
                            minSpoCount2 = counter;
                        }
                        if (hr < minHr2)
                        {
                            minHr2 = hr;
                            minCountHr2 = counter;
                        }
                    }
                    if (counter == 200 + (i * 200))
                    {
                         i++;
                         spoDC = (((minSpo2 - minSpo1) * (maxCount - minSpoCount1)) / (minSpoCount2 - minSpoCount1)) + minSpo1;
                         hrDC = (((minHr2 - minHr1) * (maxCountHr - minCountHr1)) / (minCountHr2 - minCountHr1)) + minHr1;
                         r = ((maxSpo - spoDC) / spoDC) / ((maxHr - hrDC) / hrDC);
                         heartRate = ((maxCountHr-maxCountHrFirstPeak)*(0.01156069)*60);
                        if(i<1)
                        {
                            totHr = heartRate;
                            totR = r;
                        }
                        else
                        {
                            totHr = (heartRate + totHr) / 2;
                            totR = (r + totR) / 2;
                        }
                        if (counter>1000)
                        {
                            if ((totHr!=0)&&(totR != 0)) {
                                hrResultLabel.Text += Convert.ToString(totHr);
                                spoResultLabel.Text += Convert.ToString(104 - (17 * totR));
                            }
                        }
                        maxSpo = 0;
                        minSpo1 = 262123;
                        minSpo2 = 262123;
                        maxCount = 0;
                        minSpoCount1 = 0;
                        minSpoCount2 = 0;
                        maxHr = 0;
                        minHr1 = 262123;
                        minHr2 = 262123;
                        maxCountHr = 0;
                        minCountHr1 = 0;
                        minCountHr2 = 0;
                        maxHrFirstPeak = 0;
                        maxCountHrFirstPeak = 0;

                    }
                    Debug.WriteLine("counter= " + counter);


                    // Debug.WriteLine("spoMin1: " + minSpo1 + " spoMin2: " + minSpo2 + " spoMax1: " + maxSpo + "############" + " counter: " + counter + " SpoMin1Count: " + minSpoCount1 + " SpoMin2Count: " + minSpoCount2 + " maxSpoCount " + maxCount);




                }
            }
            catch (System.OverflowException)
 
            {

            }
            
            
            // textBox2.Text += "spoDC=" + Convert.ToString(spoDC) + " minspo1=" + Convert.ToString(minSpo1) + " minspo1Point=" + Convert.ToString(minCount1) + " minSpo2=" + Convert.ToString(minSpo2) + " minspo2Point=" + Convert.ToString(minCount2) + " maxSpo=" + Convert.ToString(maxSpo) + " maxCountPoint=" + Convert.ToString(maxCount) + " hrDC=" + Convert.ToString(hrDC) + " minHr1=" + Convert.ToString(minHr1) + " minHr1Point=" + Convert.ToString(minCountHr1) + " minHr2=" + Convert.ToString(minHr2) + " minHr2Point=" + Convert.ToString(minCountHr2) + " maxHr=" + Convert.ToString(maxHr) + " maxHrPoint=" + Convert.ToString(maxCountHr) + " SpO2=%" + Convert.ToString(104 - (17 * r));
           

            
          

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            timer4.Start();
            timer1.Start();
            timer3.Start();

        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            
            max30102RawChart.ChartAreas[0].AxisX.Minimum = minm;
            max30102RawChart.ChartAreas[0].AxisX.Maximum = maksm;
            max30102RawChart.ChartAreas[0].AxisY.Minimum = 150000;
            max30102RawChart.ChartAreas[0].AxisY.Maximum = 210000;
            max30102RawChart.ChartAreas[0].AxisX.ScaleView.Zoom(minm, maksm);

            int counterChart = 0;
            
            string pattern = @"(?:(?'h'h\d+)|(?'s's\d+)){2}";
            RegexOptions options = RegexOptions.Multiline;
            string sampleList = this.GetDataStorage();
            foreach (Match match in Regex.Matches(sampleList, pattern, options))
            {

                counterChart++;
                
                GroupCollection groups = match.Groups;
            
                try
                {
                    try
                    { 
                    int spo = Convert.ToInt32((groups["s"].Value.Trim('s')));
                    int hr = Convert.ToInt32((groups["h"].Value.Trim('h')));
                    this.max30102RawChart.Series[0].Points.AddXY(maksm, spo);
                    this.max30102RawChart.Series[1].Points.AddXY(maksm, hr);
                    }
                    catch(System.FormatException)
                    { }
                }
                catch(System.OverflowException)
                {

                }
               
                maksm++;
                minm++;
            }

            Debug.WriteLine("counterChart= "+ counterChart);

        }

     

    
        private void serialPortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                form1PortPanel.Enabled = true;
            form1PortPanel.Visible = true;
            comPortcomboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comPortcomboBox.Items.AddRange(ports);    
            formMain2Panel.Enabled = false;
            



        }

      

        private void portOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (comPortcomboBox.Text == "" || boudRadescomboBox.Text == "" || dataBitsComboBox.Text == "" || parityBitcomboBox.Text == "" || stopBitcomboBox.Text == "")
                {
                    MessageBox.Show( "Please select all port settings!");
                }
                else
                {
                    try
                    {
                        serialPort1.PortName = comPortcomboBox.Text;


                        serialPort1.BaudRate = Convert.ToInt32(boudRadescomboBox.Text);
                        try
                        {
                            serialPort1.DataBits = Convert.ToInt32(dataBitsComboBox.Text);
                        }
                        catch (System.ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("Make sure the data bit matches the devices data bit!");

                        }
                        serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitcomboBox.Text);
                        serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), parityBitcomboBox.Text);
                        try
                        {
                            serialPort1.Open();
                        }
                        catch (System.IO.IOException)

                        {
                            MessageBox.Show("Make sure your com Port is right!");
                        }

                    }
                    catch (System.InvalidOperationException)
                    {
                        MessageBox.Show("You can not change to port when the port is open!");
                    }
                    if (serialPort1.IsOpen)
                    { portStateProgressBar.Value = 100; }
                    else
                    {
                        MessageBox.Show("Make sure you set the correct port selections! ");
                    }
                    
                   
                   
                    
               


                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Unauthorized Access");
            }
        }
       

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            picturePanel.Visible = true;
            DialogResult result = MessageBox.Show("Be carefull during sampling!\nMeasurements in the graphic should be similar to the example picture", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                DialogResult result1 = MessageBox.Show("Are your finger is on the SpO2 device?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    calculationLabel.Visible = true;
                    CleanDataStorege();
                    spoResultLabel.Text = "";
                    hrResultLabel.Text = "";
                    rawTextBox.Clear();
                    calculationProgressBar.Value = 0;
                    this.max30102RawChart.Series[0].Points.Clear();
                    this.max30102RawChart.Series[1].Points.Clear();

                    this.maksm = 600;
                    this.minm = 0;
                    bool buttonState = true;
                    this.SetButtonCheck(buttonState);
                    SerialPortListenDefault();
                    timer2.Start();
                    picturePanel.Visible = false;

                }
                else
                {
                    MessageBox.Show("Please place your finger on the SpO2 device\nThen press the (New Sample) button");
                    picturePanel.Visible = false;
                }
            }
            
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            form1PortPanel.Enabled = false;
            form1PortPanel.Visible = false;
            if(serialPort1.IsOpen)
            {
                formMain2Panel.Enabled = true;
            }
            
            
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            calculationProgressBar.Visible = true;
            calculationProgressBar.Value = calculationProgressBar.Value + 10;
            if (calculationProgressBar.Value == calculationProgressBar.Maximum)
            {
                bool sampleState = false;
                timer1.Stop();
                timer4.Stop();
                timer3.Stop();
                calculationLabel.Visible = false;


                SetButtonCheck(sampleState);
                DialogResult result2 = MessageBox.Show("If you could not consecutive systolics\nYou can do new measurement.\nDo you want new measurement? ", "Sucsess!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    calculationLabel.Visible = true;
                    CleanDataStorege();
                    spoResultLabel.Text = "";
                    hrResultLabel.Text = "";
                    rawTextBox.Clear();
                    calculationProgressBar.Value = 0;
                    this.max30102RawChart.Series[0].Points.Clear();
                    this.max30102RawChart.Series[1].Points.Clear();
                    this.maksm = 600;
                    this.minm = 0;
                    bool buttonState = true;
                    this.SetButtonCheck(buttonState);
                    SerialPortListenDefault();
                    timer2.Start();

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void portClose_Click(object sender, EventArgs e)
        {if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                
                portStateProgressBar.Value = 0;
            }
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm3 = new Login();
            Result frm2 = new Result();
            frm2.ShowDialog();
        }
        public DataSample Objectify(string spo2, string hr, string fullName, string idNumber, string gender, string dateOfBirth, string hesCode, string patientStory, string measrumentTime)
        {
            DataSample dataObject = new DataSample
            {
                guid = Guid.NewGuid(),
                measurementTime = measrumentTime,
                spo2 = spo2,
                hr = hr,
                fullName = fullName,
                idNumber = idNumber,
                gender = gender,
                dateOfBirth = dateOfBirth,
                hesCode = hesCode,
                patientStory = patientStory

            };
            return dataObject;
        }
        public void WriteJsonToFile(DataSample dataObject)
        {
            File.AppendAllText(@"C:\Users\ayber\source\repos\HRandSpO2Reader\measurements\measurements.json", dataObject.ToJSON(dataObject) + "|");
        }
        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (hrResultLabel.Text != "" && spoResultLabel.Text != "" && fullName.Text != "" && idNumber.Text != "" && comboGender.Text != "" && numericDay.Text != "" && numericMonth.Text != "" && numericYear.Text != "" && hesCode.Text != "" && patientStory.Text != "" )
            {
                string dateOfBirth = numericDay.Text + "-" + numericMonth.Text + "-" + numericYear.Text;

                //URL
                string requestUri = this.baseUrl + "/api/MedicalRecord/AddMedicalRecord";
                //Httpcontent
                string content = JsonConvert.SerializeObject(new { Spo2 = spoResultLabel.Text, Hr = hrResultLabel.Text, PatientStory = patientStory.Text, MeasurementDate = DateTime.Now, HesCode = hesCode.Text, Tckn = idNumber.Text });
                var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                //Send Http Request
                var responseStream = await httpClient.PostAsync(requestUri, byteContent);
                Stream stream = await responseStream.Content.ReadAsStreamAsync();
                Console.WriteLine(stream);

                DataSample data = Objectify(spoResultLabel.Text, hrResultLabel.Text, fullName.Text, idNumber.Text, comboGender.Text, dateOfBirth, hesCode.Text, patientStory.Text, DateTime.Now.ToString());
                WriteJsonToFile(data);
                MessageBox.Show("Successfully submitted!");
                hrResultLabel.Text = ""; spoResultLabel.Text = ""; fullName.Text = ""; idNumber.Text = ""; comboGender.Text = ""; numericDay.Text = ""; numericMonth.Text = ""; numericYear.Text = ""; hesCode.Text = ""; patientStory.Text = "";
                rawTextBox.Clear();
                CleanDataStorege();
                calculationProgressBar.Value = 0;

            }
            else
            {
                MessageBox.Show("Your submit was failed!\nPlease fill in the emty part!");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acsessState != true)
            {
                Login frm3 = new Login();
                frm3.Owner = this; 
                frm3.ShowDialog();
                acsessState = true;
            }
            else
            {
                loginToolStripMenuItem.Text = "Login";
                loginToolStripMenuItem.BackColor = System.Drawing.Color.Red;
                resultToolStripMenuItem.Enabled = false;
                serialPortsToolStripMenuItem.Enabled = false;
                acsessState = false;

            }
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            comPortcomboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comPortcomboBox.Items.AddRange(ports);
        }

        private void size(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            About frm4 = new About();
            frm4.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class DataSample
    {
        public Guid guid { get; set; }
        public string measurementTime { get; set; }
        public string spo2 { get; set; }
        public string hr { get; set; }
        public string fullName { get; set; }
        public string idNumber { get; set; }
        public string gender { get; set; }
        public string dateOfBirth { get; set; }
        public string hesCode { get; set; }
        public string patientStory { get; set; }


        public override string ToString()
        {
            return 
                  " guid: " + guid.ToString()
                + " measurementTime: " + measurementTime.ToString()
                + " spo2: " + spo2.ToString()
                + " hr: " + hr.ToString()
                + " fullName: " + fullName.ToString()
                + " idNumber: " + idNumber.ToString()
                + " gender: " + gender.ToString()
                + " dateOfBirth: " + dateOfBirth.ToString()
                + " hesCode: " + hesCode.ToString()
                + " patientStory: " + patientStory.ToString();
        }

        public string ToJSON(DataSample data)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                return serializer.Serialize(data);
            }
            catch
            {
                Debug.WriteLine("ToJson method have failed.");
                return "false";
            }
        }
    }
}

