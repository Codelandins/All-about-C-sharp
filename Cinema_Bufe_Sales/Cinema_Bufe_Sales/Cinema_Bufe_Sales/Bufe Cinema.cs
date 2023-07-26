using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Bufe_Sales
{
    public partial class Form1 : Form
    {
        //Cinema bufe, Products: Tea, Water, Popcorn, Ticket
        //Save them to the list
        public Form1()
        {
            InitializeComponent();
        }

        int money_in_till = 0;    //Here is global area. 

        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, water, tea, ticket, total;
            popcorn = Convert.ToInt16(txtPopcorn.Text);
            water = Convert.ToInt16(txtWater.Text);
            tea = Convert.ToInt16(txtTea.Text);
            ticket = Convert.ToInt16(txtTicket.Text);

            total = popcorn * 4 + tea * 2 + ticket * 8 + water * 1;
            lblTotal.Text = "Total: $" + total.ToString();

            money_in_till += total;    //money_in_till = money_in_till + total; , money_in_till++
            lblTill.Text = "Till: $" + money_in_till.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTea.Clear();
            txtTicket.Clear();
            txtWater.Clear();
            txtPopcorn.Clear();
            txtPopcorn.Focus();
        }
    }
}
