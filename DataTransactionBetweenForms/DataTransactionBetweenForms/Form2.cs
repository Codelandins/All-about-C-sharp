using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTransactionBetweenForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string message;      //We have to make this structure public to
        public string m1;           //be accessible from other forms.
        public string m2;
        public string m3;

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(m1);
            comboBox1.Items.Add(m2);
            comboBox1.Items.Add(m3);
            label1.Text = message;
        }
    }
}
