using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;//for debug vision
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;//for json data
using System.Windows.Forms;
using System.Collections;//for array

namespace HRandSpO2Reader
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e)
        {
            deleteSelectedToolStripMenuItem.Enabled = true;
            deleteAllToolStripMenuItem.Enabled = true;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if(File.Exists(@"C:\Users\ayber\source\repos\HRandSpO2Reader\measurements\measurements.json"))
            { 


                string[] dataSampleList = ReadJsonFile();
                int i = 0;
                var serializer = new JavaScriptSerializer();
                while (dataSampleList[i] != "")
                {
                    DataSample json = (DataSample)serializer.Deserialize(dataSampleList[i], typeof(DataSample));
                    this.dataGridView1.Rows.Add(json.spo2, json.hr, json.measurementTime, json.fullName, json.idNumber, json.gender, json.hesCode, json.dateOfBirth, json.patientStory);
                   // Debug.WriteLine("data from file: " + json.ToString());
                   
                    i++;
                }
                  
            }
            else
            {
                deleteSelectedToolStripMenuItem.Enabled = false;
                deleteAllToolStripMenuItem.Enabled = false;

            }
        }
        public string[] ReadJsonFile()
        {
           
                string jsonString = File.ReadAllText(@"C:\Users\ayber\source\repos\HRandSpO2Reader\measurements\measurements.json");
                string[] datas = jsonString.Split('|');
                return datas;
         

        }
        public void WriteJsonToFile(DataSample dataObject)
        {
            File.AppendAllText(@"C:\Users\ayber\source\repos\HRandSpO2Reader\measurements\measurements.json", dataObject.ToJSON(dataObject) + "|");
        }

        public DataSample Objectify(string spo2, string hr, string fullName, string idNumber, string gender, string dateOfBirth, string hesCode, string patientStory,string measrumentTime)
        {
            DataSample dataObject = new DataSample
            {   guid = Guid.NewGuid(),
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
    
        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int c = this.dataGridView1.SelectedRows.Count;
                for (int b = 0; b < c; b++)
                {
                    var serializer = new JavaScriptSerializer();
                    int selectedRow = (this.dataGridView1.SelectedRows[0].Index);
                    try { 
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);}
                    catch(System.InvalidOperationException)
                    {
                        MessageBox.Show("You cannot delete a blank row!");
                    }
                    if (this.dataGridView1.Rows.Count == 1)
                    {
                        deleteSelectedToolStripMenuItem.Enabled = false;
                        deleteAllToolStripMenuItem.Enabled = false;

                    }
                    string[] dataSampleList = ReadJsonFile();
                    File.Delete(@"C:\Users\ayber\source\repos\HRandSpO2Reader\measurements\measurements.json");
                    int i = 0;
                    while (dataSampleList[i] != "")
                    {
                        DataSample json = (DataSample)serializer.Deserialize(dataSampleList[i], typeof(DataSample));
                        if (i == selectedRow)
                        {

                        }
                        else
                        {
                            WriteJsonToFile(json);
                        }
                        i++;
                    }
                }




            }

        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (this.dataGridView1.Rows.Count > 0)
            {
                int a = dataGridView1.Rows.Count;


                for (int i = 0; i < a - 1; i++)
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.Rows[0].Index);
                }
                File.Delete(@"C:\Users\ayber\source\repos\HRandSpO2Reader\measurements\measurements.json");
                deleteSelectedToolStripMenuItem.Enabled = false;
                deleteAllToolStripMenuItem.Enabled = false;
            }



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
