using SDG.Banking.BL.Models;
using SDG.Banking.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDG.Banking.BL
{
    public static class DepositManager
    {
        public static List<Deposit> Populate(int customerId)
        {
            //Create list for deposits
            List<Deposit> deposits = new List<Deposit>();

            //Create a switch statement to populate the deposits for each customer
            switch (customerId)
            {
                case 1:
                    deposits.Add(new Deposit { DepositId = 1, CustomerId = 1, DepositAmount = 350, DepositDate = new DateTime(2022, 05, 12) });
                    deposits.Add(new Deposit { DepositId = 2, CustomerId = 1, DepositAmount = 500, DepositDate = new DateTime(2022, 05, 24) });
                    deposits.Add(new Deposit { DepositId = 3, CustomerId = 1, DepositAmount = 1000, DepositDate = new DateTime(2022, 05, 30) });
                    break;
                case 2:
                    deposits.Add(new Deposit { DepositId = 4, CustomerId = 2, DepositAmount = 100, DepositDate = new DateTime(2022, 05, 17) });
                    deposits.Add(new Deposit { DepositId = 5, CustomerId = 2, DepositAmount = 200, DepositDate = new DateTime(2022, 06, 03) });
                    deposits.Add(new Deposit { DepositId = 6, CustomerId = 2, DepositAmount = 300, DepositDate = new DateTime(2022, 06, 13) });
                    break;
                case 3:
                    deposits.Add(new Deposit { DepositId = 7, CustomerId = 3, DepositAmount = 1000, DepositDate = new DateTime(2022, 08, 22) });
                    deposits.Add(new Deposit { DepositId = 8, CustomerId = 3, DepositAmount = 2000, DepositDate = new DateTime(2022, 09, 24) });
                    deposits.Add(new Deposit { DepositId = 9, CustomerId = 3, DepositAmount = 3000, DepositDate = new DateTime(2022, 10, 06) });
                    break;

            }

            return deposits;
        }

        public static List<Deposit> Load()
        {
            try
            {
                List<Deposit> deposits = new List<Deposit>();
                Database db = new Database();
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tblDeposit";
                SqlCommand sqlCommand = new SqlCommand(sql);

                dt = db.Select(sqlCommand);

                foreach (DataRow dr in dt.Rows)
                {
                    Deposit deposit = new Deposit();
                    deposit.DepositId = int.Parse(dr["Id"].ToString());
                    deposit.CustomerId = int.Parse(dr["CustomerId"].ToString());
                    deposit.DepositAmount = double.Parse(dr["Amount"].ToString());
                    deposit.DepositDate = DateTime.Parse(dr["DepositDate"].ToString());

                    deposits.Add(deposit);
                }

                return deposits;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Deposit> Load(int customerId)
        {
            try
            {
                List<Deposit> deposits = new List<Deposit>();
                Database db = new Database();
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tblDeposit WHERE CustomerId = @CustomerId";
                SqlCommand sqlCommand = new SqlCommand(sql);
                sqlCommand.Parameters.AddWithValue("@CustomerId", customerId);

                dt = db.Select(sqlCommand);

                foreach (DataRow dr in dt.Rows)
                {
                    Deposit deposit = new Deposit();
                    deposit.DepositId = int.Parse(dr["Id"].ToString());
                    deposit.CustomerId = int.Parse(dr["CustomerId"].ToString());
                    deposit.DepositAmount = double.Parse(dr["Amount"].ToString());
                    deposit.DepositDate = DateTime.Parse(dr["DepositDate"].ToString());

                    deposits.Add(deposit);
                }

                return deposits;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int DeleteByCustomerId(int Id, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "DELETE FROM tblDeposit WHERE CustomerId = @CustomerId";

                sqlCommand.CommandText = sql;

                sqlCommand.Parameters.AddWithValue("@CustomerId", Id);
                
                int results = db.Delete(sqlCommand, rollback);
                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(Deposit deposit, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "INSERT INTO tblDeposit (Id, CustomerId, DepositDate, Amount)";
                sql += " VALUES (@Id, @CustomerId, @DepositDate, @Amount)";

                sqlCommand.CommandText = sql;

                sqlCommand.Parameters.AddWithValue("@Id", deposit.DepositId);
                sqlCommand.Parameters.AddWithValue("@CustomerId", deposit.CustomerId);
                sqlCommand.Parameters.AddWithValue("@DepositDate", deposit.DepositDate);
                sqlCommand.Parameters.AddWithValue("@Amount", deposit.DepositAmount);

                int results = db.Insert(sqlCommand, rollback);
                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Update(Deposit deposit, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "UPDATE tblDeposit SET ";
                sql += "CustomerId = @CustomerId, ";
                sql += "DepositDate = @DepositDate, ";
                sql += "Amount = @Amount ";
                sql += "WHERE Id = @Id";

                sqlCommand.CommandText = sql;

                sqlCommand.Parameters.AddWithValue("@Id", deposit.DepositId);
                sqlCommand.Parameters.AddWithValue("@CustomerId", deposit.CustomerId);
                sqlCommand.Parameters.AddWithValue("@DepositDate", deposit.DepositDate);
                sqlCommand.Parameters.AddWithValue("@Amount", deposit.DepositAmount);

                int results = db.Update(sqlCommand, rollback);
                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
