using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeasssigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clearing textbox and label
            txtdayofweek.Clear();
            txtdayofthemonthe.Text = "";
            txtmonth.Text=string.Empty;
            txtyear.Text=string.Empty;
            //
            ibloutput.Text = "";


        }

        private void bdnshowdata_Click(object sender, EventArgs e)

        {
            //create a variable
            string dayof_week, name_of_month, nemuric_day, year, full_data;
            //intial variables
            dayof_week = txtdayofweek.Text;
            name_of_month = txtdayofthemonthe.Text;
            nemuric_day = txtmonth.Text;
            year = txtyear.Text;
            //stage2
            full_data = dayof_week + " ," + name_of_month + " ," + nemuric_day + " , " + year;
            // satage 3 the output using label
            label6.Text = full_data;
        }



        private void close_Click(object sender, EventArgs e)


        {
            //form close _ using this keyword and close function
            this.Close();






            //create a variable
            string dayof_week, name_of_month, nemuric_day, year, full_data;
            //intial variables
            //dayof_week = txtdayofweek.text;
            //name_of_month = txtdayofthemonthe.teaxt;
            //nemuric_day = txtmonth.teaxt;


          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

  

