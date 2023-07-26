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
    public partial class FRM1 : Form
    {
        //Switch - case is very popular among C# developers. If a coder wants to use numerous of
        //If - else cases then the coder use "switch - case" structure.
        public FRM1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt16(textBox1.Text);

            switch (month)                    
            {   
                               //The value that user type in the textbox1 is a number               
                               //And this number is kind a "key" like dictionaries in python
                               //switch(month) means that once the button is clicked, something
                               //will happen in the right side of case structure below
                               //if you type 1 in the textbox, case 1 will be activated.
                               //We open the case and do some operations inside untill
                               //the break point

                case 1: label1.Text = "January";break;
                case 2: label1.Text = "February";break;
                case 3: label1.Text = "March";break;
                case 4: label1.Text = "April"; break;
                case 5: label1.Text = "May"; break;
                case 6: label1.Text = "June"; break;
                case 7: label1.Text = "July"; break;
                case 8: label1.Text = "August"; break;
                case 9: label1.Text = "September"; break;
                case 10: label1.Text = "October"; break;
                case 11: label1.Text = "November"; break;
                case 12: label1.Text = "December"; break;
                default: label1.Text = "Wrong input!";break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string season = textBox2.Text.Trim();  //We use trim here due to prevent
                                                   //user to extra space spelling error
            switch (season)
            {
                case "Winter": label5.Text = "December, January, February"; break;
                case "Spring": label5.Text = "March, April, May"; break;
                case "Summer": label5.Text = "June, July, August"; break;
                case "Fall": label5.Text = "September, October, November"; break;
                default: label5.Text = "Wrong input!";break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Switch_Case_Aritmetic sw = new Switch_Case_Aritmetic();
            sw.Show();
        }
    }
}
