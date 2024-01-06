using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDG.Banking.BL.Models
{
    public class Withdrawal
    {
		private int withdrawalId;

		public int WithdrawalId
		{
			get { return withdrawalId; }
			set { withdrawalId = value; }
		}

        private int customerId;

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        private double withdrawalAmount;

		public double WithdrawalAmount
		{
			get { return withdrawalAmount; }
			set { withdrawalAmount = value; }
		}

		private DateTime withdrawalDate;

		public DateTime WithdrawalDate
		{
			get { return withdrawalDate; }
			set { withdrawalDate = value; }
		}
	}
}
