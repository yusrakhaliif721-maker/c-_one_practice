using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test__score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            {
                //read the three test score from the texbox
                double test11 = double.Parse(txtTest11.Text);
                double test2 = double.Parse(txtTest2.Text);
                double test3 = double.Parse(txtTest3.Text);
                //calculate the average of thee test score
                double average = (test11 + test2 + test3) / 3;
                //display the average
                lblAverage.Text = average.ToString("0.0");

                // Check the grade
                if (average >= 90)
                {
                    MessageBox.Show("Grade A");
                }
                else if (average >= 80)
                {
                    MessageBox.Show("Grade B");
                }
                else if (average >= 70)
                {
                    MessageBox.Show("Grade C");
                }
                else if (average >= 60)
                {
                    MessageBox.Show("Grade D");
                }

            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtTest11.Clear(); 
            txtTest2.Clear();
            txtTest3.Clear();
            lblAverage.Text = "";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
            

        
     










