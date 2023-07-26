using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sequences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] people = { "Ozlem", "Mehmet", "Asli", "Murat" };
        private void button1_Click(object sender, EventArgs e)
        {

            foreach (string i in people)
            {
                listBox1.Items.Add(i);
            }

            //Loops above and below are doing the exact same thing as a result!!!!

            for (int k = 0; k <= 3; k++)
            {
                listBox1.Items.Add(people[k]);
            }

            //declaring two different kind of sequnce types 
            double[] numbers = { 0.2, 3.4, 5.7, 10.3, 3.5 };
            char[] characters = { 'a', 'w', 'h', 't', 'y' };


        }
    }
}
