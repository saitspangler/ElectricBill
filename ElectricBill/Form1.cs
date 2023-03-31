namespace ElectricBill
{
    public partial class Form1 : Form
    {
        const decimal ADMIN_CHARGE = 12;
        const decimal KWH_RATE = 0.07m;
        decimal KWHUsed;
        int accountNumber = 0;
        string FirstName = " ";
        string LastName = " ";
        decimal BillAmount;
        decimal AccountNumber;
        string customer = " ";
        string displayBill = "";
        int totalCustomers = 0;
        decimal totalkWh = 0;
        decimal avgBill;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            //take in First Name, Last Name, and kWh used
            //calculate bill amount by multiplying kWh used by rate and adding admin_charge
            //add customer and bill amount to listbox with toString
            //clear text boxes
            FirstName = txtFirstName.Text;
            LastName = txtLastName.Text;
            KWHUsed = Convert.ToDecimal(txtkWh.Text);
            BillAmount = ((KWHUsed * KWH_RATE) + ADMIN_CHARGE);
            displayBill = "Account # " + AccountNumber + " First Name: " + FirstName + " Last Name: " + LastName + " Bill Amount: " + BillAmount;
            AccountNumber = ++accountNumber;
            lbCustomers.Items.Add(displayBill.ToString());
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtkWh.Text = "";
                    }
    }
}