using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBill
{
    public class CustomerData
    {
        public int AccountNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal kWhUsed { get; set; }
        public decimal BillAmount { get; set; }

        public CustomerData(int accountNo, string firstName, string lastName, decimal kWhUsed)
        {
            AccountNo = accountNo;
            FirstName = firstName;
            LastName = lastName;
            this.kWhUsed = kWhUsed;
            BillAmount = CalculateCharge();
        }

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
