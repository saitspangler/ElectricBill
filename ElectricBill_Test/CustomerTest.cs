using Customers;

namespace ElectricBill_Test
{
    [TestClass]
    public class CustomerTest
    {
        //testing calculate charge function
        [TestMethod]
        public void TestCalculateCharge()
        {
            int accountNo = 1;
            string firstName = "John";
            string lastName = "Doe";
            decimal kWhUsed = 100;

            CustomerData customer = new CustomerData(accountNo, firstName, lastName, kWhUsed);

            decimal expected = 19m;
            decimal actual = customer.CalculateCharge();

            Assert.AreEqual(expected, actual);
        }

        //testing that customerdata is correctly formatted in a tostring method
        [TestMethod]
        public void TestToString()
        {
            int accountNo = 1;
            string firstName = "John";
            string lastName = "Doe";
            decimal kWhUsed = 100;

            CustomerData customer = new CustomerData(accountNo, firstName, lastName, kWhUsed);

            string expected = "AccountNo: 1, Name: John Doe, kWh Used: 100, Bill Amount: 19.00";
            string actual = customer.ToString();

            Assert.AreEqual(expected, actual);
        }

        //Testing if the constructor correctly saves the data inputted
        [TestMethod]
        public void TestCustomerDataConstructor()
        {
            int accountNo = 1;
            string firstName = "John";
            string lastName = "Doe";
            decimal kWhUsed = 100;

            CustomerData customer = new CustomerData(accountNo, firstName, lastName, kWhUsed);

            Assert.AreEqual(accountNo, customer.AccountNo);
            Assert.AreEqual(firstName, customer.FirstName);
            Assert.AreEqual(lastName, customer.LastName);
            Assert.AreEqual(kWhUsed, customer.kWhUsed);
            Assert.AreEqual(19m, customer.BillAmount);
        }
    }
}