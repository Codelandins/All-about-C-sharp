using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] symbols = { "a", "b", "c", "d", "e", "f", "g" };
            string[] symbols2 = { "+", "-", "*", "-", "=", "/", "$" };
            int s1,s2,s3;
            Random rn = new Random();
            s1 = rn.Next(symbols.Length);
            s2 = rn.Next(symbols2.Length);
            s3 = rn.Next(0,11);
            label1.Text = symbols[s1].ToString() + symbols2[s2].ToString() + s3.ToString();
           
        }
    }
}
