using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointStructure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int w1 = 29;
        int h1 = 52;
        int x = 336;
        int y = 220;
        int tim = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox3.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            label2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emergency button is activated. Crew will be with you very soon. Do NOT PANIC!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public void button5_Click(object sender, EventArgs e)
        {
            elevator();
            timer1.Start();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void elevator() 
        {
            Size pb2s = new Size();
            Point pb2p = new Point();
            pb2s.Width = w1;
            pb2s.Height = h1;
            pb2p.X = x;
            pb2p.Y = y;
            pictureBox2.Size = pb2s;
            pictureBox2.Location = pb2p;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x <= 16)
            {
                x = 16;
            }
            else
            {
                x -= 2;
            }


            if (w1 >= 525)
            {
                w1 = 525;
            }
            else
            {
                w1 += 3;
            }


            if (y <= 62)
            {

                y = 62;
            }
            else
            {
                y--;
            }


            if (h1 >= 509)
            {
                h1 = 509;
            }
            else
            {
                h1 += 3;
            }


            //w1 += 3;
            //x -= 2;
            //y--;
            //h1 += 3;
            elevator();
            tim++;
            label2.Text = tim.ToString();

            if (pictureBox12.BackColor == Color.GreenYellow && tim == 167)
            {   
                timer1.Stop();
                MessageBox.Show($"You have arrived the 1.floor!");
                
            }
            if (pictureBox13.BackColor == Color.GreenYellow && tim == 130)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 2.floor!");
            }
            if (pictureBox14.BackColor == Color.GreenYellow && tim == 92)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 3.floor!");
            }
            if (pictureBox5.BackColor == Color.GreenYellow && tim == 68)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 4.floor!");
            }
            if (pictureBox4.BackColor == Color.GreenYellow && tim == 53)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 5.floor!");
            }
            if (pictureBox3.BackColor == Color.GreenYellow && tim == 41)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 6.floor!");
            }
            if (pictureBox18.BackColor == Color.GreenYellow && tim == 33)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 7.floor!");
            }
            if (pictureBox19.BackColor == Color.GreenYellow && tim == 27)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 8.floor!");
            }
            if (pictureBox20.BackColor == Color.GreenYellow && tim == 23)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 9.floor!");
            }
            if (pictureBox6.BackColor == Color.GreenYellow && tim == 19)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 10.floor!");
            }
            if (pictureBox7.BackColor == Color.GreenYellow && tim == 16)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 11.floor!");
            }
            if (pictureBox8.BackColor == Color.GreenYellow && tim == 13)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 12.floor!");
            }
            if (pictureBox9.BackColor == Color.GreenYellow && tim == 11)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 13.floor!");
            }
            if (pictureBox10.BackColor == Color.GreenYellow && tim == 9)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 14.floor!");
            }
            if (pictureBox11.BackColor == Color.GreenYellow && tim == 7)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 15.floor!");
            }
            if (pictureBox15.BackColor == Color.GreenYellow && tim == 6)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 16.floor!");
            }
            if (pictureBox16.BackColor == Color.GreenYellow && tim == 5)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 17.floor!");
            }
            if (pictureBox17.BackColor == Color.GreenYellow && tim == 4)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 16.floor!");
            }

            if (pictureBox17.BackColor == Color.GreenYellow && tim == 3)
            {
                timer1.Stop();
                MessageBox.Show($"You have arrived the 18.floor!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button15.Enabled = true;
            button21.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button14.Enabled = true;
            button13.Enabled = true;
            button12.Enabled = true;
            button11.Enabled = true;
            button10.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;           
            pictureBox3.BackColor = Color.SeaShell;
            pictureBox4.BackColor = Color.SeaShell;
            pictureBox5.BackColor = Color.SeaShell;
            pictureBox6.BackColor = Color.SeaShell;
            pictureBox7.BackColor = Color.SeaShell;
            pictureBox8.BackColor = Color.SeaShell;
            pictureBox9.BackColor = Color.SeaShell;
            pictureBox10.BackColor = Color.SeaShell;
            pictureBox11.BackColor = Color.SeaShell;
            pictureBox12.BackColor = Color.SeaShell;
            pictureBox13.BackColor = Color.SeaShell;
            pictureBox14.BackColor = Color.SeaShell;
            pictureBox15.BackColor = Color.SeaShell;
            pictureBox16.BackColor = Color.SeaShell;
            pictureBox17.BackColor = Color.SeaShell;
            pictureBox18.BackColor = Color.SeaShell;
            pictureBox19.BackColor = Color.SeaShell;
            pictureBox20.BackColor = Color.SeaShell;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox4.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox5.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox12.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox13.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox14.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox18.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox19.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox20.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox6.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox7.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox8.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox9.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox10.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox11.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox15.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox16.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button21.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button16.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            pictureBox17.BackColor = Color.GreenYellow;
            btnGo.Enabled = true;
            
        }
    }
}
