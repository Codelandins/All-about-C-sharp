using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Book"].Points.AddXY("Izmir", 5);
            chart1.Series["Book"].Points.AddXY("Istanbul", 8);
            chart1.Series["Book"].Points.AddXY("Ankara", 14);
        }
    }
}
