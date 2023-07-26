using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Countries country1 = new Countries();

            country1.Name = "Turkiye";
            country1.Continent = "Asia";
            country1.CapitalCity = "Ankara";
            country1.ECONOMY = 460;
            country1.RELIGIOUS = "muslim";
            country1.water_area = "Black sea";
            country1.population = 90000000;
            country1.relationships = "Good with Russia";
            country1.altitude = 8790;

            label1.Text = country1.Name;
            label2.Text = country1.Continent;
            label3.Text = country1.CapitalCity;
            label4.Text = "$" + country1.ECONOMY.ToString();
            label5.Text = country1.RELIGIOUS;
            label6.Text = country1.water_area;
            label10.Text = country1.population.ToString();
            label14.Text = country1.relationships;
            label15.Text = country1.altitude.ToString() + "km";

        }
    }
}
