using SDG.Banking.BL.Models;
using SDG.Banking.PL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SDG.Banking.BL
{
    public static class CustomerManager
    {
        public static List<Customer> Populate()
        {
            try
            {
                //Create list for customers
                List<Customer> customers = new List<Customer>();

                //Create and add Customer 1
                Customer customer1 = new Customer()
                {
                    Id = 1,
                    FirstName = "Carl",
                    LastName = "Wheezer",
                    SSN = "123-45-6789",
                    BirthDate = new DateTime(1980, 05, 12),
                };
                //Set deposits and withdrawals to the Populate methods
                customer1.Deposits = DepositManager.Populate(customer1.Id);
                customer1.Withdrawals = WithdrawalManager.Populate(customer1.Id);

                customers.Add(customer1);

                //Create and add Customer 2
                Customer customer2 = new Customer()
                {
                    Id = 2,
                    FirstName = "Sheen",
                    LastName = "Estevez",
                    SSN = "987-65-4321",
                    BirthDate = new DateTime(1985, 07, 08),
                };
                //Set deposits and withdrawals to the Populate methods
                customer2.Deposits = DepositManager.Populate(customer2.Id);
                customer2.Withdrawals = WithdrawalManager.Populate(customer2.Id);

                customers.Add(customer2);

                //Create and add Customer 3
                Customer customer3 = new Customer()
                {
                    Id = 3,
                    FirstName = "Jimmy",
                    LastName = "Neutron",
                    SSN = "111-11-1111",
                    BirthDate = new DateTime(1975, 02, 26),
                };
                //Set deposits and withdrawals to the Populate methods
                customer3.Deposits = DepositManager.Populate(customer3.Id);
                customer3.Withdrawals = WithdrawalManager.Populate(customer3.Id);

                customers.Add(customer3);

                return customers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Save(List<Customer> customers, string xmlFilePath)
        {
            try
            {
                FileIO.Delete(xmlFilePath);

                XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
                TextWriter writer = new StreamWriter(xmlFilePath);
                serializer.Serialize(writer, customers);
                writer.Close();
                writer = null;
                serializer = null;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Customer> Load(string xmlFilePath)
        {
            try
            {
                //Create list for customers and XML reader object
                List<Customer> customers = new List<Customer>();
                XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

                //Read XML file and add to customers list
                TextReader reader = new StreamReader(xmlFilePath);
                customers.AddRange((List<Customer>)serializer.Deserialize(reader));
                reader.Close();
                reader = null;
                serializer = null;

                return customers;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Customer> Load()
        {
            try
            {
                List<Customer> customers = new List<Customer>();
                Database db = new Database();
                DataTable data = new DataTable();

                string sql = "SELECT * FROM tblCustomer";
                SqlCommand command = new SqlCommand(sql);

                data = db.Select(command);

                foreach (DataRow row in data.Rows)
                {
                    Customer customer = new Customer();
                    customer.Id = int.Parse(row["Id"].ToString());
                    customer.FirstName = row["FirstName"].ToString();
                    customer.LastName = row["LastName"].ToString();
                    customer.SSN = row["SSN"].ToString();
                    customer.BirthDate = DateTime.Parse(row["BirthDate"].ToString());

                    customer.Deposits = DepositManager.Load(customer.Id);
                    customer.Withdrawals = WithdrawalManager.Load(customer.Id);

                    customers.Add(customer);
                }
                return customers;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(Customer customer, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand command = new SqlCommand();

                string sql = "INSERT INTO tblCustomer (Id, SSN, FirstName, LastName, BirthDate)";
                sql += "VALUES (@Id, @SSN, @FirstName, @LastName, @BirthDate)";

                command.CommandText = sql;

                command.Parameters.AddWithValue("@Id", customer.Id);
                command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                command.Parameters.AddWithValue("@LastName", customer.LastName);
                command.Parameters.AddWithValue("@SSN", customer.SSN);
                command.Parameters.AddWithValue("@BirthDate", customer.BirthDate);

                int iRows = db.Insert(command, rollback);

                //Load Deposits and Withdrawals
                customer.Deposits = DepositManager.Load(customer.Id);
                customer.Withdrawals = WithdrawalManager.Load(customer.Id);


                return iRows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Delete(Customer customer, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand command = new SqlCommand();

                string sql = "DELETE FROM tblCustomer WHERE Id = @Id";

                command.CommandText = sql;

                command.Parameters.AddWithValue("@Id", customer.Id);

                DepositManager.DeleteByCustomerId(customer.Id);
                WithdrawalManager.DeleteByCustomerId(customer.Id);

                int iRows = db.Delete(command, rollback);

                return iRows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Update(Customer customer, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand command = new SqlCommand();

                string sql = "UPDATE tblCustomer SET " +
                             "FirstName = @FirstName, " +
                             "LastName = @LastName, " +
                             "SSN = @SSN, " +
                             "BirthDate = @BirthDate " +
                             "WHERE Id = @Id";

                command.CommandText = sql;

                command.Parameters.AddWithValue("@Id", customer.Id);
                command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                command.Parameters.AddWithValue("@LastName", customer.LastName);
                command.Parameters.AddWithValue("@SSN", customer.SSN);
                command.Parameters.AddWithValue("@BirthDate", customer.BirthDate);

                int iRows = db.Update(command, rollback);

                return iRows;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
