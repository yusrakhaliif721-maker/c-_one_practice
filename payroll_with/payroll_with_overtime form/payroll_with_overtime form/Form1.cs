using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_with_overtime_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double hours;
            double payrate;
            double grosspay;
            hours =double.Parse(txtHourse.Text);
            payrate = double.Parse(txtHourlyPay.Text);
            if (hours <= 40)
            {
                grosspay = hours * payrate;
            }
            else
            {
                double overtimeHours;
                double overtimePay;

                overtimeHours = hours - 40;
                overtimePay = overtimeHours * payrate * 1.5;

                grosspay = (40 * payrate) + overtimePay;
            }

            lblGrosss.Text = grosspay.ToString("C");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtHourse.Clear();
            txtHourlyPay.Clear();
            lblGrosss.Text = "";
            txtHourse.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

