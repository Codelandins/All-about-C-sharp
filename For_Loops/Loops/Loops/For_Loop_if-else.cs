using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class For_Loop_if_else : Form
    {
        public For_Loop_if_else()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int one = 1;
            int number;
            number = Convert.ToInt32(textBox1.Text);
            //for (int i = 0; i <= 100; i++)
            //{ 
            //    if (i % 3 == 0) 
            //    { 
            //        listBox1.Items.Add(i);
            //    }
            //}

            //for (int i = 0;i <= 100;i++) 
            //{ 
            //    if (i % 5 == 0 && i % 6 == 0)
            //    {
            //        listBox1.Items.Add(i);
            //    }

            //}
            //number = Convert.ToInt16(textBox1.Text);
            //for (int i = 0; i <= number; i++)
            //{
            //    listBox1.Items.Add(i);   
            //}
            //for (int i = 1; i <= number; i++)
            //{
            //    one *= i;             
            //}
            //listBox1.Items.Add(one);
            for (int i = number; i >= 1; i--)
            {
                one = one * i;
                
            }
            listBox1.Items.Add(one);
            label1.Text = $"{number}! = {one}";
        }
    }
}
