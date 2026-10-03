using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace range_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtinput.Text, out number))
            {
                if (number >= 1 && number <= 10)
                {
                    lblrangedecision.Text = "Number is in the valid range.";
                }
                else
                {
                    lblrangedecision.Text = "Number is out of range.";
                }
            }
            else
            {
                lblrangedecision.Text = "Please enter a valid integer.";
            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtoutput1.Clear();
            lblrangedecision.Text = "";
            txtinput.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
