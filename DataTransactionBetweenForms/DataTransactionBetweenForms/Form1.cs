using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTransactionBetweenForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.message = textBox1.Text;
            

            frm.m1 = textBox2.Text;
            frm.m2 = textBox3.Text;
            frm.m3 = textBox4.Text;
            frm.Show();
            this.Hide();
        }
    }
}
