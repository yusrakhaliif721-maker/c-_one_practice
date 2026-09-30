using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hi
{
    public partial class txtfood1 : Form
    {
        public txtfood1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating variables
            try
            {
                //variable
                String jestname=txtguestname.Text;
                String room = txtroom.Text;
                int nights = int.Parse(txtnights.Text);
                decimal price = decimal.Parse(txtpricenight.Text);
                //calculate
                decimal bookingcost= nights*price;
                // service text
                decimal servicetext = bookingcost* 0.10m;
                //discount
                decimal dicount= bookingcost * 0.05m;
                //calculate total
                decimal totalamount = bookingcost + servicetext -dicount;
                //desplay
                lblsevice.Text = servicetext.ToString();
                lbldiscoun.Text = dicount.ToString();
                lbltotal.Text = totalamount.ToString();





            }
             //qabo qaladka input lasoo galiyo
            catch {
                MessageBox.Show("plz try again invalid error");
            }
        }
    }
}
