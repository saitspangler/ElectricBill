using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBill
{
    internal class CustomerData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal kWhUsed { get; set; }
        public int AccountNumber { get; set; }
        public decimal BillAmount { get; set; }
    }
    
}
