using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour = 0, minute = 0, second = 0, timezone = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            label3.Text = second.ToString("00.");
            if (second == 59) 
            {
                minute++;
                label2.Text = minute.ToString("00.") + ":";
                second = 0;
                if (minute == 59)
                { 
                    hour++;                    
                    label1.Text = hour.ToString("00.") + ":";
                    minute = 0;
                    if (hour == (12)) 
                    {
                        if (timezone == 0)
                        {
                            label4.Text = "p.m";
                            timezone++;
                        }
                        else
                        {
                            label4.Text = "a.m";
                            timezone--;
                        }
                        hour = 0;
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
