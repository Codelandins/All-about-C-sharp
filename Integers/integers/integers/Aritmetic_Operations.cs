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
    public partial class Aritmetic_Operations : Form
    {
        public Aritmetic_Operations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2, summation, multiplication, division, difference;
            number1 = Convert.ToInt16(textBox1.Text);
            number2 = Convert.ToInt16(textBox2.Text);
            summation = number1 + number2;
            multiplication = number1 * number2;
            division = number1 / number2;
            difference = number2 - number1;

            MessageBox.Show($"Summation: {summation} \nMultiplication: {multiplication}\nDivision: {division}\nDifference: {difference}");
            //label3.Text = "Summation:" + summation;
            //label3.Text = summation.ToString();

        }
    }
}
