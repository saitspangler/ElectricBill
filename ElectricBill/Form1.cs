using Customers;

namespace ElectricBill
{
    public partial class Form1 : Form
    {
        /*
         * Application to calculate electric bill from given inputs
         * 
         * Author: Peter
         * 
         * When: April 2023
         */

        //Application constants
        const decimal ADMIN_CHARGE = 12;
        const decimal KWH_RATE = 0.07m;

        //Application variables for calculations and user input
        decimal KWHUsed;
        int accountNumber = 1;
        string FirstName = " ";
        string LastName = " ";
        decimal BillAmount;
        decimal AccountNumber = 1;
        string displayBill = "";
        int totalCustomers = 0;
        decimal totalkWh = 0;
        decimal totalBilled = 0;
        decimal avgBill;
        string displayStatistics = " ";

        public Form1()
        {
            InitializeComponent();
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            //Validate user input
            if (Validator.IsPresent(txtFirstName)
               && Validator.IsPresent(txtLastName)
               && Validator.IsNonNegativeInt(txtkWh))
            {
                //take in First Name, Last Name, and kWh used
                FirstName = txtFirstName.Text;
                LastName = txtLastName.Text;
                KWHUsed = Convert.ToDecimal(txtkWh.Text);

                //create new CustomerData object
                CustomerData customer = new CustomerData(++accountNumber, FirstName, LastName, KWHUsed);

                totalCustomers += 1;
                totalkWh = totalkWh + KWHUsed;

                txtKWHUsed.Text = totalkWh.ToString();
                txtTotalCust.Text = totalCustomers.ToString();

                totalBilled += customer.BillAmount;

                avgBill = totalBilled / totalCustomers;

                txtAvgBill.Text = avgBill.ToString("c");

                displayStatistics = "Total Customers: " + totalCustomers + " Total kWh: " + totalkWh + " Average Bill: " + avgBill;

                //add customer to listbox with toString
                lbCustomers.Items.Add(customer.ToString());


                //clear text boxes to be ready for next customer
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtkWh.Text = "";
            }
        }
    }
}