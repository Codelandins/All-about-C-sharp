using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BubbleTea Taro = new BubbleTea();
            Taro.ice_level = 3;
            Taro.sugar_level = 0;
            Taro.size = "Large";
            Taro.toppings = "Chese foam";

            listView1.Items.Add(Taro.ice_level + " " + Taro.sugar_level + " " + Taro.size + " " + Taro.toppings);

        }
    }
}