using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integers
{
    public partial class Double_Variables : Form
    {
        public Double_Variables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double number;
            //number = 4.25;
            //label1.Text = number.ToString();
            ////////////////////////////////////////////////////////
            //double exam1, exam2, exam3, avg;
            //exam1 = 67;
            //exam2 = 74;
            //exam3 = 89;
            //avg = (exam1 + exam2 + exam3) / 3;
            //label1.Text = avg.ToString(".00"); //Once we fill the paranthases with something like this
            //We constrain the label1.text with these digits, result
            //will be 76.67
            /////////////////////////////////////////////////////////
            double x;
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = x.ToString();
        }
    }
}
