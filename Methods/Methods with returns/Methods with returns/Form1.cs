using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods_with_returns
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        int sum(int n1, int n2)
        { 
            int s3 = n1 + n2;
            return s3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double k;
            double f;
            double c;

            k = Convert.ToDouble(textBox1.Text);
            f = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            

            label3.Text = multip(k, f, c).ToString();

            label1.Text = sum(6,7).ToString();
            label2.Text = sum(7,8).ToString();
 
        }

        double multip(double x, double y, double z)
        {           
            double result = x * y * z;          
            return result;
        }
    }
}
