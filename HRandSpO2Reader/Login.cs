using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRandSpO2Reader
{
    
    public partial class Login : Form
    {
        private string baseUrl;
        private static HttpClient httpClient;


        public Login()
        {
            baseUrl = "http://localhost:5000";
            httpClient = new HttpClient();
            InitializeComponent();
        }
        
       

        int k = 1;
    
     

        private async void button1_Click(object sender, EventArgs e)
        {
            //URL
            string requestUri = this.baseUrl + "/api/User/Login";
            //Httpcontent
            string content = JsonConvert.SerializeObject(new { Tckn = textBox1.Text, Password = textBox2.Text, SourceSystem = "desktop" });
            var buffer = System.Text.Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //Send Http Request
            var responseStream = await httpClient.PostAsync(requestUri, byteContent);
            
            if (responseStream.IsSuccessStatusCode == true)
            {
                MessageBox.Show("Your are success!");
               
              (this.Owner as Form1).resultToolStripMenuItem.Enabled = true;
               (this.Owner as Form1).serialPortsToolStripMenuItem.Enabled = true;
                (this.Owner as Form1).loginToolStripMenuItem.Text = "Logout";
                (this.Owner as Form1).loginToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
                this.Close();
                


               
            }
            else 
            {
                MessageBox.Show("Your pasword or name are wrong");

                k++;
                if (3 < k)
                {
                    MessageBox.Show("You have tried three times!\nYou can't access the program.");
                    Application.Exit();

                }


            }
          

        }
    }
}
