namespace Customers
{     /*
     * Class to store Customer Data and perform necessary calculations for electic bill
     * 
     * Author: Peter
     * 
     * When: April 2023
     * 
     */
    public class CustomerData
    {
        //required parameters
        public int AccountNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal kWhUsed { get; set; }
        public decimal BillAmount { get; set; }

        //Constructor
        public CustomerData(int accountNo, string firstName, string lastName, decimal KWHUsed)
        {
            AccountNo = accountNo;
            FirstName = firstName;
            LastName = lastName;
            kWhUsed = KWHUsed;
            BillAmount = CalculateCharge();
        }

        //Function to calculate charges
        public decimal CalculateCharge()
        {
            const decimal administrativeCharge = 12m;
            const decimal chargePerkWh = 0.07m;
            return administrativeCharge + (kWhUsed * chargePerkWh);
        }

        public override string ToString()
        {
            return $"AccountNo: {AccountNo}, Name: {FirstName} {LastName}, kWh Used: {kWhUsed}, Bill Amount: {BillAmount}";
        }
    }
}