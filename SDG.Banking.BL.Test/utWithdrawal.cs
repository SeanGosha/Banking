using SDG.Banking.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDG.Banking.BL.Test
{
    [TestClass]
    public class utWithdrawal
    {
        [TestMethod]
        public void PopulateTest()
        {
            //Check if we have 3 withdrawals for each customer
            int expected = 3;

            //Loop through each customer in customer manager
            foreach (Customer customer in CustomerManager.Populate())
            {
                //Check if we have 3 withdrawals for each customer by customer id
                int actual = WithdrawalManager.Populate(customer.Id).Count;
                //Test if we have 3 withdrawals for each customer
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void LoadTest()
        {
            int actual = WithdrawalManager.Load().Count;
            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void Load1Test()
        {
            int actual = WithdrawalManager.Load(1).Count;
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            //Create new withdrawal
            Withdrawal withdrawal = new Withdrawal();
            //Set withdrawal properties
            withdrawal.WithdrawalId = -1;
            withdrawal.CustomerId = 1;
            withdrawal.WithdrawalAmount = 100;
            withdrawal.WithdrawalDate = DateTime.Now;

            Assert.AreEqual(1, WithdrawalManager.Insert(withdrawal, true));
        }
    }
}
