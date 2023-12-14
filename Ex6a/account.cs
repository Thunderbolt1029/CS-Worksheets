using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex6a
{
    class account
    {
        public static List<account> accounts = new List<account>();

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

        private decimal accountBalance;

        private static List<int> accountNumbers = new List<int>();

        public account(customer Customer, bool addToList = false)
        {
            accountNumber = generateUniqueAccountNumber();
            this.Customer = Customer;

            if (addToList)
            {
                accounts.Add(this);
            }
        }


        // Generates unique account number and returns it
        public static int generateUniqueAccountNumber()
        {
            Random rnd = new Random();
            int accountNumber;

            if (accounts.Count != 0)
            {
                do
                {
                    accountNumber = rnd.Next(10000000, 100000000);
                } while (accounts.Any(x => x.accountNumber == accountNumber));
            }
            else
            {
                accountNumber = rnd.Next(10000000, 100000000);
            }

            return accountNumber;
        }

        public static int? findAccountNumber()
        {
            string input = null;
            bool goodAccountNumber, goodLength, isInt;

            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts");
            }
            else
            {
                do
                {
                    Console.Write("Enter Account number: ");
                    input = Console.ReadLine();

                    goodLength = input.Length == 8;
                    isInt = int.TryParse(input, out _);
                    goodAccountNumber = goodLength && isInt;

                    
                    if (goodAccountNumber && !accounts.Any(x => x.accountNumber == int.Parse(input)))
                    {
                        Console.WriteLine("Couldn't find account with that number\n");
                        goodAccountNumber = false;
                    }
                    else if (goodAccountNumber) { break; }
                    else
                    {
                        Console.WriteLine("Not a valid account number\n");
                    }

                } while (!goodAccountNumber);
            }
            return input != null ? (int?)int.Parse(input) : null;
        }

        public void viewAccountBalance()
        {
            Console.WriteLine($"Customer: {Customer.forename} {Customer.surname}");
            Console.WriteLine($"Account: {new string('*', accountNumber.ToString().Length-3)}{accountNumber.ToString()[^3..]}");
            Console.WriteLine($"Balance: £{accountBalance}");
        }

        public void withdrawMoney()
        {
            do
            {
                try
                {
                    Console.Write("Enter the amount to withdraw: £");
                    string withdrawAmount = Console.ReadLine();

                    if (decimal.Parse(withdrawAmount) <= accountBalance)
                    {
                        accountBalance -= Math.Round(decimal.Parse(withdrawAmount), 2, MidpointRounding.AwayFromZero);
                        Console.WriteLine("Amount withdrawn");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not enough money in account");
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number");
                }
            } while (true);
        }

        public void depositMoney()
        {
            do
            {
                try
                {
                    Console.Write("Enter the amount to deposit: £");
                    string depositAmount = Console.ReadLine();

                    accountBalance += Math.Round(decimal.Parse(depositAmount), 2, MidpointRounding.ToZero);
                    Console.WriteLine("Amount deposited");
                    break;
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number");
                }
            } while (true);
        }
    }
}
