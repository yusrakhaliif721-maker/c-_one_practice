using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
        {
            double weight, height, bmi;

            weight = Convert.ToDouble(txtWeight.Text);
            height = Convert.ToDouble(txtHeight.Text);

            bmi = weight / (height * height);

            rtbOutput.Text = "BMI = " + bmi.ToString("0.00");
        }
    }

        private void btnClear_Click(object sender, EventArgs e)
        {
        {
            txtWeight.Clear();
            txtHeight.Clear();
            rtbOutput.Clear();

            txtWeight.Focus();
        }
    }

        private void btnExit_Click(object sender, EventArgs e)
        {
        {
            Application.Exit();
        }
    }
    }
}
