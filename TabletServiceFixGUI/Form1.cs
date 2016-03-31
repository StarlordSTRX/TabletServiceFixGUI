using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ServiceProcess;

namespace TabletServiceFixGUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            loadServiceName();
           

        }
            
        string serviceName = "AdobeARMservice";
        
        int timeoutMilliseconds = 8000;

        private void restart_Click(object sender, EventArgs e)
        {
            loadServiceName();
            serviceName = textBox1.Text;
            ServiceController service = new ServiceController(serviceName);
            

            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                // count the rest of the timeout
                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);

                status.ForeColor = Color.Green;
                status.Text = "SUCCESS";
                timerSeconds.Start();
            }
            catch
            {

                status.ForeColor = Color.Red;
                status.Text = "ERROR";
                timerSeconds.Start();
            }
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            if (timerSeconds.Interval > 2) {
                timerSeconds.Stop();
                timerSeconds.Interval = 2000;
                status.ForeColor = Color.Gray;
                status.Text = "IDLE";
            }
        }

        private void lbl_settings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        public void loadServiceName() {
            string path = "settings.txt";
            
            try
            {
                StreamReader sr = new StreamReader(path);
                string read = sr.ReadToEnd();
                    string[] readEnd = read.Split(':');
                    sr.Close();
                    //string[] serviceRestart = readEnd[0].Split(':');
                    //string[] killRipples = readEnd[1].Split(':');
                    
                textBox1.Text = readEnd[1];
                //if (killRipples[1] == "yes") { 
                    //KillRipples
                    //KillRipples();
                //}
                
            }
            catch
            {
                textBox1.Text = serviceName;
            }
        
        }

        private void credits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        //KILL RIPPLES
        /*
        public void KillRipples() {
            string serviceName2 = "TabletInputService";
            ServiceController service = new ServiceController(serviceName2);
            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            }
            catch
            {
                MessageBox.Show("Ripples was not killed");
            }
        }
        */

    }
}
