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
    public partial class Variables_Exercises : Form
    {
        public Variables_Exercises()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname;
            int exam1, exam2, project;
            double avg;
            name = textBox1.Text;
            surname = textBox2.Text;
            exam1 = Convert.ToInt16(textBox4.Text);
            exam2 = Convert.ToInt16(textBox3.Text);
            project = Convert.ToInt16(textBox6.Text);
            avg = (exam1 + exam2 + project) / 3;
            listBox1.Items.Add(name + " " + surname + " " + avg);
            
        }
    }
}
