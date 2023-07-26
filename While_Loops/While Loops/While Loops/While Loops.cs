using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //When we are using while loops in the code, we usually need a variable called "counter"
            //in the programming field. This value is "i" here. :)
            //int i = 1;
            //while (i <= 5) 
            //{ 
            //    listBox1.Items.Add("Ozlemin uykusu var");
            //    listBox2.Items.Add(i);
            //    i++;
            //}
            int i = Convert.ToInt16(textBox1.Text);
            int y = 1;
            int sum = 0;
            while (i >= y)
            {               
                sum += y;
                y++;
            }
            label1.Text = sum.ToString();
        }
    }
}
