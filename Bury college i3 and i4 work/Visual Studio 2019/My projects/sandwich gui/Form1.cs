using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sandwich_gui
{
    public partial class Form1 : Form
    {

        float totalcost = 0.00f;
        float itemcost = 0.00f;

        public Form1()
        {
            InitializeComponent();
        }

        private void Coldhamandcheese_Click(object sender, EventArgs e)
        {
            itemcost = 2.50f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("Cold ham and cheese £2.50");
            price.Text = $"£{totalcost}";
                }

        private void Hottuna_Click(object sender, EventArgs e)
        {
            itemcost = 3.50f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("Hot tuna £3.50");
            price.Text = $"£{totalcost}";

        }

        private void Hotchicken_Click(object sender, EventArgs e)
        {
            itemcost = 3.50f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("Hot chicken £3.50");
            price.Text = $"£{totalcost}";
        }

        private void Hothamandcheese_Click(object sender, EventArgs e)
        {
            itemcost =32.50f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("hot ham and cheese £3.50");
            price.Text = $"£{totalcost}";
        }

        private void Coldchicken_Click(object sender, EventArgs e)
        {
            itemcost = 2.50f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("Cold chicken £2.50");
            price.Text = $"£{totalcost}";
        }

        private void Coldtuna_Click(object sender, EventArgs e)
        {
            itemcost = 2.50f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("Cold tuna £2.50");
            price.Text = $"£{totalcost}";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            itemcost = 1.50f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("water £1.50");
            price.Text = $"£{totalcost}";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            itemcost = 1.50f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("coke £1.50");
            price.Text = $"£{totalcost}";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            itemcost = 1.50f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("apple juice £1.50");
            price.Text = $"£{totalcost}";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            itemcost = 2.00f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("tea £2.00");
            price.Text = $"£{totalcost}";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            itemcost = 2.00f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("Coffee £2.00");
            price.Text = $"£{totalcost}";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            itemcost = 2.00f;
            totalcost = totalcost + itemcost;
            receipt.Items.Add("Hot Chocolate £2.00");
            price.Text = $"£{totalcost}";
        }
    }
}
