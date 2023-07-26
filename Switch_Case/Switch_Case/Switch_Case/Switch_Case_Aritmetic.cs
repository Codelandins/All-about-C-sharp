using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Switch_Case
{
    public partial class Switch_Case_Aritmetic : Form
    {
        public Switch_Case_Aritmetic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2;
            string symbol = textBox3.Text;
            number1 = Convert.ToInt16(textBox1.Text);
            number2 = Convert.ToInt16(textBox2.Text);

            switch (symbol)
            {
                case "+": MessageBox.Show($"Summation of {number1}, {number2} = {number1 + number2}"); break;
                case "-": MessageBox.Show($"Subtraction of {number1}, {number2} = {number1 - number2}"); break;
                case "*": MessageBox.Show($"Multiplaction of {number1}, {number2} = {number1 * number2}"); break;
                case "/": MessageBox.Show($"Division of {number1}, {number2} = {number1 / number2}"); break;
                case "%": MessageBox.Show($"Mode of {number1}, {number2} = {number1 % number2}"); break;
            }
        }
    }
}
