using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchAmongForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
                                    //Form 2 is a new class and in order to reach it's attirbutes,
                                    //we have to create a "object" like
                                    // With this structure here, we litteraly did the same thing as we did 
                                    // in the "class" structures.
            frm.Show();
        }
    }
}
