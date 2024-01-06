using SDG.Banking.BL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SDG.Banking.BL.Test
{
    [TestClass]
    public class utCustomer
    {
        [TestMethod]
        public void PopulateTest()
        {
            //Check if we have 3 customers
            int expected = 3;
            int actual = CustomerManager.Populate().Count;

            //Test if we have 3 customers
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SaveTest()
        {
            List<Customer> list = CustomerManager.Populate();

            bool results = CustomerManager.Save(list, "customers.xml");
            Assert.IsTrue(results);
        }

        [TestMethod]
        public void LoadTest()
        {
            List<Customer> customers = CustomerManager.Load("customers.xml");
            Assert.AreEqual(customers.Count, 3);
            Assert.AreEqual(customers[0].Deposits.Count, 3);
            Assert.AreEqual(customers[1].Deposits.Count, 3);
            Assert.AreEqual(customers[2].Deposits.Count, 3);
        }

        [TestMethod]
        public void LoadDBTest()
        {
            List<Customer> customers = CustomerManager.Load();
            Assert.AreEqual(customers.Count, 3);
            Assert.AreEqual(customers[0].Deposits.Count, 3);
            Assert.AreEqual(customers[1].Deposits.Count, 3);
            Assert.AreEqual(customers[2].Deposits.Count, 3);
        }

        [TestMethod]
        public void InsertTest()
        {
            Customer customer = new Customer();

            customer.Id = -5;
            customer.FirstName = "John";
            customer.LastName = "Green";
            customer.SSN = "000-00-0000";
            customer.BirthDate = new DateTime(1980, 1, 1);


            int actual = CustomerManager.Insert(customer, true);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void DeleteTest()
        {
            Customer customer = CustomerManager.Load().FirstOrDefault();

            int results = CustomerManager.Delete(customer, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void UpdateTest()
        {
            Customer customer = CustomerManager.Load().FirstOrDefault();

            customer.FirstName = "John";
            customer.LastName = "Green";
            customer.SSN = "000-00-0000";
            customer.BirthDate = new DateTime(1980, 1, 1);

            int results = CustomerManager.Update(customer, true);
            Assert.AreEqual(1, results);
        }


    }
}
