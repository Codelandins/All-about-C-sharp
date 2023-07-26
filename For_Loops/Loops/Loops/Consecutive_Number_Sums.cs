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
    public partial class Consecutive_Number_Sums : Form
    {
        public Consecutive_Number_Sums()
        {
            InitializeComponent();
        }
        int i;
        int ozlem;
        int total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (ozlem = 0; ozlem <= 100; ozlem += 2)
            { 
                listBox1.Items.Add(ozlem);
                total += ozlem;
            }
            label1.Text = total.ToString();

            //Prime number finder
            //for (i = 2; i <= 10; i++)
            //{
            //    for (int k = 2; k < i; k++)
            //    {
            //        if (i % k == 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            continue;
            //        }

            //    }
            //    listBox2.Items.Add(i);

            //}
            for (int i = 2; i <= 10; i++)
            {
                bool isPrime = true;

                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true) ;
                {
                    listBox2.Items.Add(i);
                }
            }
        }
    }
}
