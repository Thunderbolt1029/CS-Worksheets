using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ex7
{
    class Globals
    {
        public static BindingList<customer> customers = new BindingList<customer>();
        public static BindingList<account> accounts = new BindingList<account>();

        public static Random random = new Random();

        public static void createNewCustomerAccount(out account newAccount, out customer newCustomer, string forename, string surname, string emailAddress, string phoneNumber, Address address)
        {
            int accountNumber = generateUniqueAccountNumber();

            newCustomer = new customer(accountNumber, forename, surname, emailAddress, phoneNumber, address);
            newAccount = new account(accountNumber, newCustomer);
        }

        public static int generateUniqueAccountNumber()
        {
            int accountNumber;

            do
            {
                accountNumber = random.Next(10000000, 100000000);
            } while (accounts.Any(x => x.accountNumber == accountNumber));

            return accountNumber;
        }

        public static bool isValidPostcode(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                output += int.TryParse(input, out _) ? input[i].ToString() : input[i].ToString().ToUpper();
            }

            return new Regex("(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX]][0-9][A-HJKSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) [0-9][A-Z-[CIKMOV]]{2})").IsMatch(output); // Looked up the regex cause yk cba
        }
    }
}
