using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usage_of_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        
        public void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int num1, num2, num3;
            num1 = rnd.Next(0, 100);
            num2 = rnd.Next(0, 100);
            num3 = rnd.Next(0, 100);
            label1.Text = num1.ToString();
            label2.Text = num2.ToString();
            label3.Text = num3.ToString();
            counter++;
            if (num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0)
            {
                int[] nums = {num1,num2,num3};
                listBox1.Items.Add($"{num1}, {num2}, {num3}");
            }
            if (counter == 10)
            { 
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FortuneGame frtn = new FortuneGame();
            frtn.Show();
        }
    }
}
