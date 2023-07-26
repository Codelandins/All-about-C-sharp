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
    public partial class FortuneGame : Form
    {
        public FortuneGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1,5);
            int num2 = rnd.Next(1, 5);
            int num3 = rnd.Next(1, 5);
            int num4 = rnd.Next(1, 5);
            label1.Text = num1.ToString();
            label2.Text = num2.ToString();
            label3.Text = num3.ToString();
            label4.Text = num4.ToString();

            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            { 
                textBox1.BackColor= Color.Red;
            }
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }
    }
}
