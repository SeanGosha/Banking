using SDG.Banking.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDG.Banking.BL.Test
{
    [TestClass]
    public class utDeposit
    {
        [TestMethod]
        public void PopulateTest()
        {
            //Check if we have 3 deposits for each customer
            int expected = 3;

            //Loop through each customer in customer manager
            foreach (Customer customer in CustomerManager.Populate())
            {
                //Check if we have 3 deposits for each customer by customer id
                int actual = DepositManager.Populate(customer.Id).Count;
                //Test if we have 3 deposits for each customer
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void LoadTest()
        {
            int actual = DepositManager.Load().Count;
            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void Load1Test()
        {
            int actual = DepositManager.Load(1).Count;
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            //Create new deposit
            Deposit deposit = new Deposit();
            //Set deposit properties
            deposit.DepositId = -1;
            deposit.CustomerId = 1;
            deposit.DepositAmount = 100;
            deposit.DepositDate = DateTime.Now;

            Assert.AreEqual(1, DepositManager.Insert(deposit, true));
        }
    }
}
