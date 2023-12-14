using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    public class account
    {
        public customer Customer
        {
            get;
            private set;
        }

        public int accountNumber
        {
            get;
            private set;
        }

        private decimal accountBalance = 0.00M;

        public string stringBalance
        {
            get
            {
                return $"£{accountBalance}";
            }
        }
        public decimal decBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                accountBalance = Math.Round(value, 2);
            }
        }

        public string custfName
        {
            get
            {
                return Customer.forename;
            }
        }
        public string custsName
        {
            get
            {
                return Customer.surname;
            }
        }

        public account(int accountNumber, customer Customer)
        {
            this.accountNumber = accountNumber;
            this.Customer = Customer;
        }
    }
}
