namespace vehicle_rental_management
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtCustomerName.Clear();
            txtCustomeragess.Clear();
            txtNumberRental.Clear();
            txtyearsDriving.Clear();

            // vehicle type
            rdoEconmy.Checked = false;
            RDOSUV.Checked = false;
            rdoLuxury.Checked = false;

            // Uncheck insurance option
            chkInsurance.Checked = false;

            // Clear booking details
            RentalDetails.Items.Clear();

            // Focus on guest name
            txtCustomerName.Focus();
        }

        private void btnexi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            string name = txtCustomerName.Text;
            int age = int.Parse(txtCustomeragess.Text);
            int days = int.Parse(txtNumberRental.Text);
            int experience = int.Parse(txtyearsDriving.Text);

            double rate = 0;

            if (rdoEconmy.Checked)
                rate = 30;
            else if (RDOSUV.Checked)
                rate = 50;
            else if (rdoLuxury.Checked)
                rate = 100;

            double insurance = 0;

            if (chkInsurance.Checked)
                insurance = days * 15;

            double rentalCost = days * rate;
            double totalCost = rentalCost + insurance;

            RentalDetails.Items.Clear();
            RentalDetails.Items.Add("Customer Name : " + name);
            RentalDetails.Items.Add("Customer Age : " + age);
            RentalDetails.Items.Add("Rental Days : " + days);
            RentalDetails.Items.Add("Driving Experience : " + experience);
            RentalDetails.Items.Add("Vehicle Cost : $" + rentalCost);
            RentalDetails.Items.Add("Insurance : $" + insurance);
            RentalDetails.Items.Add("Total Cost : $" + totalCost);
        }
    }
}
