using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDG.Banking.BL.Models
{
    public class Person
    {

		private string ssn;

		public string SSN
		{
			get { return ssn; }
			set { ssn = value; }
		}

		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private DateTime birthDate;

		public DateTime BirthDate
		{
			get { return birthDate; }
			set { birthDate = value; }
		}

		public int Age
		{
			get { return DateTime.Now.Year - birthDate.Year ;}
		}

		public string FullName
		{
			get { return firstName + " " + lastName; }
		}
	}
}
