using System;
using System.CodeDom.Compiler;
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
    public partial class Loop_Introduction : Form
    {
        public Loop_Introduction()
        {
            InitializeComponent();
        }
        //int i;
        private void button1_Click(object sender, EventArgs e)
        {
            //for (i = 1; i <= 10; i++)
            //{
            //listBox1.Items.Add(i.ToString());

            //Initialization: i = 1
            //This step initializes a variable(i in this case) to a starting value.
            //Here, i is set to 1 as the initial value.

            //Condition: i <= 10
            //This step defines a condition that is checked before each iteration of the loop.
            //If the condition evaluates to true, the loop continues executing; if it evaluates to false,
            //the loop terminates.In this example, the loop will continue as long as i is less than or equal to 10.

            //Iteration: i++           
            //This step updates the value of the loop variable(i in this case) after each iteration.Here,
            //i++ increments the value of i by 1 in each iteration.
            //So, in this specific example, the for loop executes the code block inside
            //the loop body(listBox1.Items.Add(i.ToString());) ten times, with i taking on the values
            //from 1 to 10.As a result, the numbers from 1 to 10 are added as string items to the listBox1 control.
            //}

            for (int i = 0; i <= 20; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consecutive_Number_Sums x = new Consecutive_Number_Sums();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            For_Loop_if_else ff = new For_Loop_if_else();
            ff.Show();
        }
    }
}
