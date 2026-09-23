using System;
using System.Windows.Forms;

namespace Assignment1
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnshowinformation_Click(object sender, EventArgs e)
        {
            //create variables
            string student_name, student_id, department, semester;
            //
            student_name = txtname.Text;
            student_id = txtstudentid.Text;
            department = txtdepertment.Text;
            semester = txtsemester.Text;
            ibloutput.Text = student_name + " ," + student_id+ " ," + department + " , " + semester;




        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepertment.Clear();
            txtsemester.Clear();
            ibloutput.Text = "";
        }
    }
}
