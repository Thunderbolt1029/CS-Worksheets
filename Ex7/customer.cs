using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    public class customer
    {
        public int accountNumber { get; private set; }
        public string forename { get; private set; }
        public string surname { get; private set; }
        public string emailAddress { get; private set; }
        public string phoneNumber { get; private set; }

        public Address address { get; private set; }
        public int addHouseNumber { get { return address.houseNumber; } }
        public string addStreetName { get { return address.streetName; } }
        public string addTown { get { return address.town; } }
        public string addCity { get { return address.city; } }
        public string addPostcode { get { return address.postcode; } }

        public customer(int accountNumber, string forename, string surname, string emailAddress, string phoneNumber, Address address)
        {
            this.accountNumber = accountNumber;
            this.forename = forename;
            this.surname = surname;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }
    }
}
