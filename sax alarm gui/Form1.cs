using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sax_alarm_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void Form1_Load(object sender, EventArgs e)
       {
                currenttime.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
       }

        private void Alarmset_Click(object sender, EventArgs e)
        {
            this.Hide();
            string z = DateTime.Today.ToString("yyyy");
            int year = short.Parse(z);
            DateTime datere;
            try
            {
                int day = Convert.ToInt32(daybox.Text);
                int second = Convert.ToInt32(secondbox.Text);
                int hour = Convert.ToInt32(hourbox.Text);
                int minute = Convert.ToInt32(minutebox.Text);
                int month = Convert.ToInt32(monthbox.Text);
                int tabs = Convert.ToInt32(tabbox.Text);
                datere = new DateTime(year, month, day, hour, minute, second);
                MessageBox.Show("your alarm was set if the program seems to be frozen dont worry its usually not!", "its working move along", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (true)
                {
                    
                    if (DateTime.Now >= datere)
                    {
                        this.Show();
                        for (int a = 1; a <= tabs; a++)
                        {
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            startInfo.FileName = "cmd.exe";
                            startInfo.Arguments = @"/C start https://www.youtube.com/watch?v=G1IbRujko-A";
                            process.StartInfo = startInfo;
                            process.Start();
                            
                        }
                        this.Close();
                        break;
                        
                   
                    }
                    
                }
            }
            catch
            {
                this.Show();
                //int oogshhsg = 23;
                while (true)
                {
                    MessageBox.Show("UwU you commited a fuckywucky time to get in the foreverbox!!!! uwu", "woopsie doopsie!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("UwU you commited a fuckywucky time to get in the foreverbox!!!! uwu", "woopsie doopsie!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //oogshhsg--;
                }
            }
        }
        
        private void currenttime_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
