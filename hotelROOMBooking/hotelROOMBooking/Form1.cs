using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelROOMBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bubtncalculate_Click(object sender, EventArgs e)
        {
           
        {
            string guestName = txtguestname.Text;
            string roomType = txtroomtype.Text;

            int numberOfNights;
            decimal pricePerNight;

            if (!int.TryParse(txtnights.Text, out numberOfNights) ||
                !decimal.TryParse(txtPriceNight.Text, out pricePerNight))
            {
                MessageBox.Show("Please enter valid numbers for nights and price per night.");
                return;
            }

            // Calculate subtotal
            decimal subTotal = numberOfNights * pricePerNight;

            // Service tax 10%
            decimal serviceTax = subTotal * 0.10m;

            // Discount
            decimal discount = 7;

            if (numberOfNights > 5)
            {
                discount = subTotal * 0.15m;
            }

            // Calculate total
            decimal totalAmount = subTotal + serviceTax - discount;

            // Display results
            lblsevicetax.Text = serviceTax.ToString("C");
            lbldiscount.Text = discount.ToString("C");
            lbltotalamoun.Text = totalAmount.ToString("C");
        }
    }
    }
}
