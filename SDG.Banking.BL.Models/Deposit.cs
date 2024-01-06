using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDG.Banking.BL.Models
{
    public class Deposit
    {
		private int depositId;

		public int DepositId
		{
			get { return depositId; }
			set { depositId = value; }
		}

		private int customerId;

		public int CustomerId
		{
			get { return customerId; }
			set { customerId = value; }
		}


		private double depositAmount;

		public double DepositAmount
		{
			get { return depositAmount; }
			set { depositAmount = value; }
		}

		private DateTime depositDate;

		public DateTime DepositDate
		{
			get { return depositDate; }
			set { depositDate = value; }
		}
	}
}
