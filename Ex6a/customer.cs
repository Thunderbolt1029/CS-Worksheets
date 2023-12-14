using System;
using System.Collections.Generic;

namespace Ex6a
{
    class customer
    {
        static List<customer> customers = new List<customer>();
        
        public string forename { get; private set; }
        public string surname { get; private set; }
        private string emailAddress, phoneNumber;
        private Address address;

        public customer(string forename, string surname, string emailAddress, string phoneNumber, Address address, bool addToList = false)
        {
            this.forename = forename;
            this.surname = surname;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
            this.address = address;

            if (addToList)
            {
                customers.Add(this);
            }
        }

        public void viewCustomerDetails(bool hideDetails = true)
        {
            Console.WriteLine($"Forname: {forename}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine("Email Address: " + (hideDetails ? emailAddress[..emailAddress.IndexOf('@')] + new string('*', emailAddress.Length - 2) : emailAddress));
            Console.WriteLine($"Phone Number: " + (hideDetails ? new string('@', phoneNumber.Length) + phoneNumber[^5..] : phoneNumber));

            if (!hideDetails)
            {
                Console.WriteLine($"House Number: {address.houseNumber}");
                Console.WriteLine($"Street Name: {address.streetName}");
                Console.WriteLine($"City: {address.city}");
                Console.WriteLine($"Postcode: {address.postcode}");

                Console.WriteLine($"Account Number: {account.accounts.Find(x => x.Customer == this).accountNumber}");
            }
        }
    }
}
