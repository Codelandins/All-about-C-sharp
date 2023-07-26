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
    public partial class Char_Variable : Form
    {
        public Char_Variable()
        {
            InitializeComponent();
        }
        //"Char" store one character place in the memory
        //"String" place way more than "char"
        //With "Char" we use ' something ' one quote we will use.
        //"CHAR" = "CHARacter
    
    private void button1_Click(object sender, EventArgs e)
        {
            //char takim;
            //takim = 'g';
            //label1.Text = takim.ToString();
            //////////////////////////////////////////////////////////////
            char ders;
            ders = Convert.ToChar(textBox1.Text);
            label1.Text = ders.ToString();
        }
    }
    
}
