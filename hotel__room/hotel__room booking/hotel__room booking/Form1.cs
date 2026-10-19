namespace hotel__room_booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // Get guest name
            string guestName = txtGuestenNAme.Text;

            // Declare variables for numeric inputs
            int age, nights, guests;

            // Validate numeric inputs using TryParse
            bool isAgeValid = int.TryParse(txtGuesteAges.Text, out age);
            bool isNightsValid = int.TryParse(txtNumberof.Text, out nights);
            bool isGuestsValid = int.TryParse(txtNumberoff.Text, out guests);

            // Validate guest name
            if (string.IsNullOrWhiteSpace(guestName))
            {
                MessageBox.Show("Please enter guest name!", "Error");
                return;
            }

            // Validate age: must be between 18 and 90
            else if (!isAgeValid || age < 18 || age > 90)
            {
                MessageBox.Show("Age must be numeric and between 18 and 90!");
                return;
            }

            // Validate nights: must be between 1 and 30
            else if (!isNightsValid || nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be numeric and between 1 and 30!");
                return;
            }

            // Validate guests: must be between 1 and 6
            else if (!isGuestsValid || guests < 1 || guests > 6)
            {
                MessageBox.Show("Guests must be numeric and between 1 and 6!");
                return;
            }

            // Check whether a room type has been selected
            else if (!rdostandard.Checked &&
                     !rdoNormal.Checked &&
                     !rdoHight.Checked)
            {
                MessageBox.Show("Please select a room type!", "Error");
                return;
            }

            else
            {
                // Declare room variables
                string roomType = "";
                double rate = 0;
                int maxCapacity = 0;

                // Identify the selected room and its maximum capacity
                if (rdostandard.Checked)
                {
                    roomType = "Standard Room";
                    maxCapacity = 2;
                }
                else if (rdoNormal.Checked)
                {
                    roomType = "Normal Room";
                    maxCapacity = 4;
                }
                else if (rdoHight.Checked)
                {
                    roomType = "High Room";
                    maxCapacity = 6;
                }

                // Determine the room rate using switch
                // IMPORTANT: Case names must match roomType exactly
                switch (roomType)
                {
                    case "Standard Room":
                        rate = 50;
                        break;

                    case "Normal Room":
                        rate = 80;
                        break;

                    case "High Room":
                        rate = 130;
                        break;
                }

                // Use a bool flag to approve or reject the booking
                bool approved = true;

                // Reject if guests exceed the room's capacity
                if (guests > maxCapacity)
                {
                    approved = false;
                }

                // Display rejection if booking is not approved
                if (approved == false)
                {
                    listBox1.Items.Add("----- BOOKING REJECTED -----");
                    listBox1.Items.Add("Guest Name: " + guestName);
                    listBox1.Items.Add("Room Type: " + roomType);
                    listBox1.Items.Add("Maximum Capacity: " + maxCapacity);
                    listBox1.Items.Add("Number of Guests: " + guests);
                    MessageBox.Show("Booking rejected! Too many guests for this room.");
                    return;
                }

                // Calculate base cost using room rate and nights
                double baseCost = rate * nights;

                // Calculate discount based on length of stay
                double staydiscount = 0;

                if (nights >= 10)
                {
                    // 12% discount for 10 or more nights
                    staydiscount = baseCost * 0.12;
                }
                else if (nights >= 5 && nights <= 9)
                {
                    // 5% discount for 5 to 9 nights
                    staydiscount = baseCost * 0.05;
                }
                // 1 to 4 nights receive no stay discount

                // Calculate senior discount
                double seniordiscount = 0;

                if (age >= 60)
                {
                    // Additional 5% senior discount
                    seniordiscount = baseCost * 0.05;
                }

                // Calculate breakfast cost
                double breakfastCost = 0;

                if (chcBreakFaste.Checked)
                {
                    // Breakfast costs $10 per guest per night
                    breakfastCost = 10 * guests * nights;
                }

                // Calculate subtotal after discounts and breakfast
                double subtotal = baseCost - staydiscount
                                  - seniordiscount + breakfastCost;

                // Calculate service surcharge
                double servicesurcharge = 0;

                if (guests > 4)
                {
                    // Add 5% surcharge for more than 4 guests
                    servicesurcharge = subtotal * 0.05;
                }

                // Calculate final cost
                double finalCost = subtotal + servicesurcharge;

                // Display booking summary in the ListBox
                listBox1.Items.Add("----- BOOKING SUMMARY -----");
                listBox1.Items.Add("Guest Name: " + guestName);
                listBox1.Items.Add("Guest Age: " + age);
                listBox1.Items.Add("Nights: " + nights);
                listBox1.Items.Add("Guests: " + guests);
                listBox1.Items.Add("Room Type: " + roomType);
                listBox1.Items.Add("Status: Approved");
                listBox1.Items.Add("---------------------------");

                // Display room rate and costs
                listBox1.Items.Add("Rate Per Night: $" + rate.ToString("F2"));
                listBox1.Items.Add("Base Cost: $" + baseCost.ToString("F2"));
                listBox1.Items.Add("Stay Discount: $" + staydiscount.ToString("F2"));
                listBox1.Items.Add("Senior Discount: $" + seniordiscount.ToString("F2"));
                listBox1.Items.Add("Breakfast: $" + breakfastCost.ToString("F2"));
                listBox1.Items.Add("Service Surcharge: $" + servicesurcharge.ToString("F2"));
                listBox1.Items.Add("---------------------------");
                listBox1.Items.Add("FINAL COST: $" + finalCost.ToString("F2"));
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtGuestenNAme.Clear();
            txtGuesteAges.Clear();
            txtNumberof.Clear();
            txtNumberoff.Clear();

            // Reset room selections
            rdostandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;

            // Uncheck breakfast
            chcBreakFaste.Checked = false;

            // Clear booking details
            listBox1.Items.Clear();

            // Focus on guest name
            txtGuestenNAme.Focus();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
