using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fillthedata()
        {
            textBox1.Text = "Ozlem";
            textBox2.Text = "SARI";
            textBox3.Text = "Bir";
            textBox4.Text = "Tas";
            textBox5.Text = "tir";
            pictureBox1.Visible = true;

        }

        private void delete()            //Do not return anything. That is why it is void. It is a method or function
        {
            textBox1.Text = " ";
            textBox1.Text = " ";
            textBox1.Text = " ";
            textBox1.Text = " ";
            textBox1.Focus();
        }

        void colour()
        { 
            textBox1.BackColor = Color.DarkGreen;
            textBox2.BackColor = Color.YellowGreen;
            textBox3.BackColor = Color.Red;
            textBox4.BackColor = Color.Blue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colour();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fillthedata();
        }
    }
}
