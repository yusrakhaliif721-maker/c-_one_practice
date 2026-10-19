namespace Airline_Ticket_Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Variables
                string name = txtPassenger.Text.Trim();
                int age;
                int tickets;
                double baggage;
                double ticketPrice = 0;
                double total;
                double insurance = 0;

                // 2. Validate passenger name
                if (name == "" || int.TryParse(name, out _))
                {
                    MessageBox.Show("Enter a valid passenger name.");
                    txtPassenger.Focus();
                    return;
                }

                // 3. Validate age
                if (!int.TryParse(txtPassengerAgess.Text, out age) ||
                    age < 1 || age > 120)
                {
                    MessageBox.Show("Enter a valid age (1-120).");
                    txtPassengerAgess.Focus();
                    return;
                }

                // 4. Validate number of tickets
                if (!int.TryParse(texttxtNumber.Text, out tickets) ||
                    tickets < 1 || tickets > 10)
                {
                    MessageBox.Show("Enter tickets between 1 and 10.");
                    texttxtNumber.Focus();
                    return;
                }

                // 5. Validate baggage weight
                if (!double.TryParse(txtbaggagewheigh.Text, out baggage) ||
                    baggage < 0)
                {
                    MessageBox.Show("Enter a valid baggage weight.");
                    txtbaggagewheigh.Focus();
                    return;
                }

                // 6. Decision structure: Travel class
                if (rdoFiristClass.Checked)
                {
                    ticketPrice = 500;
                }
                else if (rdoNormalClass.Checked)
                {
                    ticketPrice = 250;
                }
                else if (rdoBusnessClass.Checked)
                {
                    ticketPrice = 400;
                }
                else
                {
                    MessageBox.Show("Please select a travel class.");
                    return;
                }

                // 7. Calculate ticket cost
                total = ticketPrice * tickets;

                // 8. Optional travel insurance ($25 per ticket)
                if (chcAddTravel.Checked)
                {
                    insurance = 25 * tickets;
                }

                total = total + insurance;

                // 9. Display results in ListBox
                ListBox1.Items.Clear();
                ListBox1.Items.Add("AIRLINE BOOKING DETAILS");
                ListBox1.Items.Add("----------------------------");
                ListBox1.Items.Add("Passenger: " + name);
                ListBox1.Items.Add("Age: " + age);
                ListBox1.Items.Add("Number of Tickets: " + tickets);
                ListBox1.Items.Add("Baggage Weight: " + baggage + " kg");

                ListBox1.Items.Add("Travel Class: " +
                    (rdoFiristClass.Checked ? "First Class" :
                    rdoNormalClass.Checked ? "Normal Class" :
                    "Business Class"));

                ListBox1.Items.Add("Ticket Price: $" + ticketPrice);
                ListBox1.Items.Add("Insurance: $" + insurance);
                ListBox1.Items.Add("Total Amount: $" + total);

                MessageBox.Show("Booking calculated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {

            // Clear all input fields
            txtPassenger.Clear();
            txtPassengerAgess.Clear();
            texttxtNumber.Clear();
            txtbaggagewheigh.Clear();

            // Reset travel class selections
            rdoFiristClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusnessClass.Checked = false;

            // Uncheck Addtravel
            chcAddTravel.Checked = false;

            // Clear booking details
            ListBox1.Items.Clear();

            // Focus on passenger name
            txtPassenger.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
