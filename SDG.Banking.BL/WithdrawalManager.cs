using SDG.Banking.BL.Models;
using SDG.Banking.PL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDG.Banking.BL
{
    public static class WithdrawalManager
    {
        public static List<Withdrawal> Populate(int customerId)
        {
            //Create list for withdrawals
            List<Withdrawal> withdrawals = new List<Withdrawal>();

            //Create a switch statement to populate the withdrawals for each customer
            switch (customerId)
            {
                case 1:
                    withdrawals.Add(new Withdrawal { WithdrawalId = 1, CustomerId = 1, WithdrawalAmount = 55, WithdrawalDate = new DateTime(2022, 8, 12) });
                    withdrawals.Add(new Withdrawal { WithdrawalId = 2, CustomerId = 1, WithdrawalAmount = 150, WithdrawalDate = new DateTime(2022, 8, 24) });
                    withdrawals.Add(new Withdrawal { WithdrawalId = 3, CustomerId = 1, WithdrawalAmount = 200, WithdrawalDate = new DateTime(2022, 8, 30) });
                    break;
                case 2:
                    withdrawals.Add(new Withdrawal { WithdrawalId = 4, CustomerId = 2, WithdrawalAmount = 50, WithdrawalDate = new DateTime(2022, 8, 17) });
                    withdrawals.Add(new Withdrawal { WithdrawalId = 5, CustomerId = 2, WithdrawalAmount = 100, WithdrawalDate = new DateTime(2022, 9, 3) });
                    withdrawals.Add(new Withdrawal { WithdrawalId = 6, CustomerId = 2, WithdrawalAmount = 75, WithdrawalDate = new DateTime(2022, 9, 13) });
                    break;
                case 3:
                    withdrawals.Add(new Withdrawal { WithdrawalId = 7, CustomerId = 3, WithdrawalAmount = 200, WithdrawalDate = new DateTime(2022, 10, 22) });
                    withdrawals.Add(new Withdrawal { WithdrawalId = 8, CustomerId = 3, WithdrawalAmount = 100, WithdrawalDate = new DateTime(2022, 11, 24) });
                    withdrawals.Add(new Withdrawal { WithdrawalId = 9, CustomerId = 3, WithdrawalAmount = 185, WithdrawalDate = new DateTime(2022, 12, 6) });
                    break;
            }

            return withdrawals;
        }
        public static List<Withdrawal> Load()
        {
            try
            {
                List<Withdrawal> withdrawals = new List<Withdrawal>();
                Database db = new Database();
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tblWithdrawal";
                SqlCommand sqlCommand = new SqlCommand(sql);

                dt = db.Select(sqlCommand);

                foreach (DataRow dr in dt.Rows)
                {
                    Withdrawal withdrawal = new Withdrawal();
                    withdrawal.WithdrawalId = int.Parse(dr["Id"].ToString());
                    withdrawal.CustomerId = int.Parse(dr["CustomerId"].ToString());
                    withdrawal.WithdrawalAmount = double.Parse(dr["Amount"].ToString());
                    withdrawal.WithdrawalDate = DateTime.Parse(dr["WithdrawalDate"].ToString());

                    withdrawals.Add(withdrawal);
                }

                return withdrawals;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Withdrawal> Load(int customerId)
        {
            try
            {
                List<Withdrawal> withdrawals = new List<Withdrawal>();
                Database db = new Database();
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tblWithdrawal WHERE CustomerId = @CustomerId";
                SqlCommand sqlCommand = new SqlCommand(sql);
                sqlCommand.Parameters.AddWithValue("@CustomerId", customerId);

                dt = db.Select(sqlCommand);

                foreach (DataRow dr in dt.Rows)
                {
                    Withdrawal withdrawal = new Withdrawal();
                    withdrawal.WithdrawalId = int.Parse(dr["Id"].ToString());
                    withdrawal.CustomerId = int.Parse(dr["CustomerId"].ToString());
                    withdrawal.WithdrawalAmount = double.Parse(dr["Amount"].ToString());
                    withdrawal.WithdrawalDate = DateTime.Parse(dr["WithdrawalDate"].ToString());

                    withdrawals.Add(withdrawal);
                }

                return withdrawals;
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

                string sql = "DELETE FROM tblWithdrawal WHERE CustomerId = @CustomerId";

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

        public static int Insert(Withdrawal withdrawal, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "INSERT INTO tblWithdrawal (Id, CustomerId, WithdrawalDate, Amount)";
                sql += " VALUES (@Id, @CustomerId, @WithdrawalDate, @Amount)";

                sqlCommand.CommandText = sql;

                sqlCommand.Parameters.AddWithValue("@Id", withdrawal.WithdrawalId);
                sqlCommand.Parameters.AddWithValue("@CustomerId", withdrawal.CustomerId);
                sqlCommand.Parameters.AddWithValue("@WithdrawalDate", withdrawal.WithdrawalDate);
                sqlCommand.Parameters.AddWithValue("@Amount", withdrawal.WithdrawalAmount);

                int results = db.Insert(sqlCommand, rollback);
                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Update(Withdrawal withdrawal, bool rollback = false)
        {
            try
            {
                Database db = new Database();
                SqlCommand sqlCommand = new SqlCommand();

                string sql = "UPDATE tblWithdrawal SET";
                sql += " CustomerId = @CustomerId,";
                sql += " WithdrawalDate = @WithdrawalDate,";
                sql += " Amount = @Amount";
                sql += " WHERE Id = @Id";

                sqlCommand.CommandText = sql;

                sqlCommand.Parameters.AddWithValue("@Id", withdrawal.WithdrawalId);
                sqlCommand.Parameters.AddWithValue("@CustomerId", withdrawal.CustomerId);
                sqlCommand.Parameters.AddWithValue("@WithdrawalDate", withdrawal.WithdrawalDate);
                sqlCommand.Parameters.AddWithValue("@Amount", withdrawal.WithdrawalAmount);

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
