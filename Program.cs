using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
		class Address
		{
			public string city { get; set; }
			public string zipcode { get; set; }
			public string street { get; set; }
		}
		class Telephone
		{
			public string CountryCode { get; set; }
			public string AreaCode { get; set; }
			public string Number { get; set; }
			public string Ext { get; set; }
		}


		class Member
		{
			public Address addr;
			public Telephone tel;
			public string name { get; set; }
			public string Account { get; set; }
			public string password { get; set; }
			public string Email { get; set; }
			public string Cellphone { get; set; }
			public void Register(string Name, string Account, string Password, string ConfrimPassword, string Email) { }
			public void ForgetPassword(string Name, string Email) { }
			public void Authenticate(string Account, string Password) { }

		}
	}
}
