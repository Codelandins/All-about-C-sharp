using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_While
{
    public partial class DoWhile : Form
    {
        public DoWhile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 18;
            do
            {
                listBox1.Items.Add("Hello Jupiter!");
                i++;
            }                                   // Do comes first "while" comes second. That's why
                                                // The code in "Do" section works first and because of
                                                // equation above(i = 18), while loop will not executed.
            while (i <= 10);
        }
    }
}
