using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SDG.Banking.BL.Models
{
    public class Customer : Person
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private List<Deposit> deposits;

		public List<Deposit> Deposits
		{
			get { return deposits; }
			set { deposits = value; }
		}

        public double LastDepositAmount
        {
            get 
			{
				if (deposits.Count > 0)
				{
                    return deposits.OrderByDescending(d => d.DepositDate).First().DepositAmount;
                }
                else
				{
                    return 0;
                }
			}
        }

		public DateTime LastDepositDate
		{
			get
			{
				if (deposits.Count > 0)
				{
					return deposits.OrderByDescending(d => d.DepositDate).First().DepositDate;
				}
				else
				{
					return DateTime.MinValue;
				}
			}
		}

        private List<Withdrawal> withdrawals;

		public List<Withdrawal> Withdrawals
		{
			get { return withdrawals; }
			set { withdrawals = value; }
		}

		public double LastWithdrawalAmount
		{
            get
			{
                if (withdrawals.Count > 0)
				{
                    return withdrawals.OrderByDescending(w => w.WithdrawalDate).First().WithdrawalAmount;
                }
                else
				{
                    return 0;
                }
            }
        }

		public DateTime LastWithdrawalDate
		{
			get
			{
				if(withdrawals.Count > 0)
				{
					return withdrawals.OrderByDescending(w => w.WithdrawalDate).First().WithdrawalDate;
                }
				else
				{ 
					return DateTime.MinValue; 
				}
			}
		}
	}
}
