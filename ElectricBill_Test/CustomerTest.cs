using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectricBill;
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
            //arrange
            int accountNo = 1;
            string firstName = "John";
            string lastName = "Doe";
            decimal kWhUsed = 100;

            CustomerData customer = new CustomerData(accountNo, firstName, lastName, kWhUsed);

            //act
            decimal expected = 19m;
            decimal actual = customer.CalculateCharge();

            //assert
            Assert.AreEqual(expected, actual);
        }

        //testing that customerdata is correctly formatted in the to string method
        [TestMethod]
        public void TestToString()
        {
            //arrange
            int accountNo = 13;
            string firstName = "Samwise";
            string lastName = "Gamgee";
            decimal kWhUsed = 200;

            CustomerData customer = new CustomerData(accountNo, firstName, lastName, kWhUsed);

            //act
            string expected = "AccountNo: 13, Name: Samwise Gamgee, kWh Used: 200, Bill Amount: 26.00";
            string actual = customer.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Testing if the constructor correctly saves the data inputted
        [TestMethod]
        public void TestCustomerDataConstructor()
        {
            //arrange
            int accountNo = 6;
            string firstName = "Frodo";
            string lastName = "Baggins";
            decimal kWhUsed = 500;

            //act
            CustomerData customer = new CustomerData(accountNo, firstName, lastName, kWhUsed);

            //assert
            Assert.AreEqual(accountNo, customer.AccountNo);
            Assert.AreEqual(firstName, customer.FirstName);
            Assert.AreEqual(lastName, customer.LastName);
            Assert.AreEqual(kWhUsed, customer.kWhUsed);
            Assert.AreEqual(47m, customer.BillAmount);
        }
    }
    
}