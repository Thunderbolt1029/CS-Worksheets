using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    public struct Address
    {
        public int houseNumber;
        public string streetName, town, city, postcode;

        public Address(int houseNumber, string streetName, string town, string city, string postcode)
        {
            this.houseNumber = houseNumber;
            this.streetName = streetName;
            this.town = town;
            this.city = city;
            this.postcode = postcode;
        }
    }
}
