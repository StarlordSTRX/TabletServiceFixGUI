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

namespace TabletServiceFixGUI
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

        }

        private void apply_Click(object sender, EventArgs e)
        {
            string path = "settings.txt";
            StreamWriter sw = new StreamWriter(path);
            if (textBox1.Text != "")
            {
                sw.WriteLine("serviceToRestart:" + textBox1.Text);
            }
             /* RIPPLE
            if (killRipple.Checked == true){
                sw.WriteLine("killRipple:yes");
            }
            else {
                sw.WriteLine("killRipple:no");
            }
            */
            sw.Close();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
