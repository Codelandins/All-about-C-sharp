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
    public partial class Integers : Form
    {
        public Integers()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string edge1, edge2;
           
            int perimeter, area, edge1, edge2;
            edge1 = Convert.ToInt16(textBox1.Text);
            edge2 = Convert.ToInt16(textBox2.Text);
            //"Convert" command let the textbox value turn into a integer data type here
            //
            
            area = edge2 * edge1;
            perimeter = 2 * edge2 + edge1;
            label5.Text = area.ToString();
            label6.Text = perimeter.ToString();
            pictureBox1.Width = edge1;
            pictureBox1.Height = edge2;

            //int number;
            //number = 56;
            //label1.Text = number.ToString();        // ToString expression is a METHOD and
            //                                        // it is illustrated with a pink color cube
            //                                        //which means it has to have paranthesis at the end
            //label1.Text = Convert.ToString(number); // They are all same
            //label1.Text = $"{number}";



            //int edge, area, perimeter;
            //edge = 10;
            //area = edge * edge;
            //perimeter = edge * 4;
            //label1.Text = "Area:" + area; //Once there is a string expression in a parameter
            //                              //Integer data type does not have to be converted to a string type


        }

        public void button2_Click(object sender, EventArgs e)
        {
            

            Aritmetic_Operations aritmetic_Operations = new Aritmetic_Operations();

            aritmetic_Operations.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Double_Variables double_Variables = new Double_Variables();
            double_Variables.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Variables_Exercises variables_Exercises = new Variables_Exercises();
            variables_Exercises.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Char_Variable char_Variables = new Char_Variable();
            char_Variables.Show();  
        }
    }
}
