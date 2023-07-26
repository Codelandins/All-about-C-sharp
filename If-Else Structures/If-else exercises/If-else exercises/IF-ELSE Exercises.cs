using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_else_exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int exam1, exam2, project;
            double result;
            string status;
            exam1 = Convert.ToInt16(textBox1.Text);
            exam2 = Convert.ToInt16(textBox2.Text);
            project = Convert.ToInt16(textBox3.Text);
            result = exam1 * 0.3 + exam2 * 0.3 + project * 0.4;           
            if (result > 70)
            {
                status = "Succsessfull!";
            }
            else 
            {
                status = "Unsuccesfull!";
            }
            label6.Text = status;
            label5.Text = result.ToString();
        }
    }
}
