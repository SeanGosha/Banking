using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SDG.Banking.PL.Test
{
    [TestClass]
    public class utDatabase
    {
        [TestMethod]
        public void OpenTest()
        {
            Database database = new Database();
            ConnectionState actual = database.Open();
            database.Close();
            Assert.AreEqual(ConnectionState.Open, actual);
        }

        [TestMethod]
        public void CloseTest()
        {
            Database database = new Database();
            database.Open();
            ConnectionState actual = database.Close();
            database.Close();
            Assert.AreEqual(ConnectionState.Closed, actual);
        }

        [TestMethod]
        public void SelectEquipmentTypes()
        {
            Database database = new Database();
            string sql = "SELECT * FROM tblCustomer";

            SqlCommand sqlCommand = new SqlCommand(sql);
            DataTable dataTable = database.Select(sqlCommand);

            int expected = 3;
            int actual = dataTable.Rows.Count;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void InsertTest()
        {
            Database database = new Database();
            SqlCommand sqlCommand = new SqlCommand();

            int id = -1;
            int CustomerId = 3;
            DateTime depositDate = DateTime.Now;
            decimal amount = 1000;

            sqlCommand.CommandText = "INSERT INTO tblDeposit VALUES (@Id, @CustomerId, @DepositDate, @Amount)";
            sqlCommand.Parameters.AddWithValue("@Id", id);
            sqlCommand.Parameters.AddWithValue("@CustomerId", CustomerId);
            sqlCommand.Parameters.AddWithValue("@depositDate", depositDate);
            sqlCommand.Parameters.AddWithValue("@amount", amount);

            int expected = 1;
            int actual = database.Insert(sqlCommand, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            Database database = new Database();
            SqlCommand sqlCommand = new SqlCommand();

            int id = 4;
            double amount = 20;

            sqlCommand.CommandText = "UPDATE tblDeposit SET Amount = @Amount WHERE Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", id);
            sqlCommand.Parameters.AddWithValue("@Amount", amount);

            int expected = 1;
            int actual = database.Update(sqlCommand, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteTest()
        {
            Database database = new Database();
            SqlCommand sqlCommand = new SqlCommand();

            int id = 5;

            sqlCommand.CommandText = "DELETE FROM tblDeposit WHERE Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", id);

            int expected = 1;
            int actual = database.Delete(sqlCommand, true);

            Assert.AreEqual(expected, actual);
        }
    }
}
