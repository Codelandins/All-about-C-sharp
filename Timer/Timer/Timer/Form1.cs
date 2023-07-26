using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //This private void says to user that
            //"What do you want to be happened  when timer pass the interval value once"
            //Interval is adjusted to "1000" which means 1 second.
            number++;
            label1.Text = number.ToString();

            switch (number) 
            {
                case 5: this.BackColor = Color.Violet; pictureBox1.Visible = true; break;               
                case 25: this.BackColor = Color.LavenderBlush; pictureBox1.Visible = false; break;
                case 45: this.BackColor = Color.Orange; break;
                case 65: number = 0; break;
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
