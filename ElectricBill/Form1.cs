using Customers;

namespace ElectricBill
{
    public partial class frmElectricBill : Form
    {
        /*
         * Application to calculate electric bill from given inputs
         * 
         * Author: Peter
         * 
         * When: April 2023
         */

        //enum for datagridview columns
        enum BillDetails { Account, FirstName, LastName, kWh, Amount };

        //Application variables for calculations and user input

        //start counting account numbers at 999 just because it looks better in the datagridview
        int accountNumber = 999;
        string FirstName = "";
        string LastName = "";
        decimal KWHUsed;
        int totalCustomers = 0;
        decimal totalkWh = 0;
        decimal totalBilled = 0;
        decimal avgBill;
        string formatBill = "";
        string formatKWH = "";
        string billHeader = "";
        string addCust = "";

        public frmElectricBill()
        {
            InitializeComponent();

            billHeader = "Account # \t First Name Last Name \t \t kWh Used \t Bill Amount";
            lblCustomers.Items.Add(billHeader);

            //use datagrid because the formatting is reliable and easy to use
            //and initialize with columns to datagridview

            dgvCustomers.ColumnCount = 5;

            //add header titles to datagridview
            dgvCustomers.Columns[(int)BillDetails.Account].Name = "Account Number";
            dgvCustomers.Columns[(int)BillDetails.FirstName].Name = "First Name";
            dgvCustomers.Columns[(int)BillDetails.LastName].Name = "Last Name";
            dgvCustomers.Columns[(int)BillDetails.kWh].Name = "kWh Used";
            dgvCustomers.Columns[(int)BillDetails.Amount].Name = "Bill Amount";
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            //Validate user input
            if (Validator.IsPresent(txtFirstName)
               && Validator.IsPresent(txtLastName)
               && Validator.IsNonNegativeDecimal(txtkWh))
            {
                //take in First Name, Last Name, and kWh used
                FirstName = txtFirstName.Text;
                LastName = txtLastName.Text;
                KWHUsed = Convert.ToDecimal(txtkWh.Text);

                //create new CustomerData object
                CustomerData customer = new CustomerData(++accountNumber, FirstName, LastName, KWHUsed);

                // add to total customers and total kWh
                totalCustomers += 1;
                totalkWh = totalkWh + KWHUsed;

                //display total customers and total kWh
                txtKWHUsed.Text = totalkWh.ToString("#####.##");
                txtTotalCust.Text = totalCustomers.ToString();

                //calculate and display average bill
                totalBilled += customer.BillAmount;
                avgBill = totalBilled / totalCustomers;
                txtAvgBill.Text = avgBill.ToString("c");


                //format kWh and bill amount for datagridview
                formatKWH = customer.kWhUsed.ToString("#####.##");
                formatBill = customer.BillAmount.ToString("c");


                //add customers to datagridview
                dgvCustomers.Rows.Add(customer.AccountNo, customer.FirstName, customer.LastName, formatKWH, formatBill);

                addCust = $"{customer.AccountNo} \t\t {customer.FirstName} {customer.LastName} \t\t {formatKWH} \t\t {formatBill}";

                //add customers to listbox
                lblCustomers.Items.Add(addCust);

                //clear text boxes to be ready for next customer and focus on first name
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtkWh.Text = "";
                txtFirstName.Focus();
            }
        }
    }
}