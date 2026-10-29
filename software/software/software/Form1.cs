namespace software
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

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int packages;

            if (!int.TryParse(txtPackages.Text, out packages)
                || packages <= 0)
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            decimal price = 99.00m;
            decimal discountRate = 0m;

            if (packages >= 100)
                discountRate = 0.50m;
            else if (packages >= 50)
                discountRate = 0.40m;
            else if (packages >= 20)
                discountRate = 0.30m;
            else if (packages >= 10)
                discountRate = 0.20m;

            decimal subtotal = packages * price;
            decimal discount = subtotal * discountRate;
            decimal total = subtotal - discount;

            txtResults.Items.Clear();


            txtResults.Items.Add("Software Sales Results");
            txtResults.Items.Add("Number of Packages: " + packages);
            txtResults.Items.Add("Price per package: $" + price.ToString("N2"));
            txtResults.Items.Add("Subtotal Before Discount: $" + subtotal.ToString("N2"));
            txtResults.Items.Add("Discount Rate: " + (discountRate * 100) + "%");
            txtResults.Items.Add("Discount Amount: $" + discount.ToString("N2"));
            txtResults.Items.Add("Total Amount (After Discount): $" + total.ToString("N2"));





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnexits_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtPackages.Clear();
            txtPricePer.Clear();
            txtResults.Text = "";
            txtPackages.Focus();



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPackages_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPricePer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
