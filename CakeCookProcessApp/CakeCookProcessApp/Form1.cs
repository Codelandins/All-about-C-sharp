using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeCookProcessApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value += 2;

            if (progressBar1.Value % 4 == 0)
            {
                label1.BackColor = Color.GreenYellow;
            }
            else
            {
                label1.BackColor = Color.Plum;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 2;
            if (progressBar2.Value % 4 == 0)
            {
                label2.BackColor = Color.GreenYellow;
            }
            else
            {
                label2.BackColor = Color.Plum;
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 2;
            if (progressBar3.Value % 4 == 0)
            {
                label3.BackColor = Color.GreenYellow;
            }
            else
            {
                label3.BackColor = Color.Plum;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 2;
            if (progressBar4.Value % 4 == 0)
            {
                label4.BackColor = Color.GreenYellow;
            }
            else
            {
                label4.BackColor = Color.Plum;
            }
            if (progressBar4.Value == 100)
            {
                timer3.Stop();
                timer4.Stop();
                MessageBox.Show("Cake is ready to destroy!");
            }
        }
    }
}
