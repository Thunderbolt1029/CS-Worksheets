using System;
using System.Text.RegularExpressions;

namespace Ex6a
{
    struct Address
    {
        public int houseNumber;
        public string streetName, city, postcode;

        public Address(int houseNumber, string streetName, string city, string postcode)
        {
            this.houseNumber = houseNumber;
            this.streetName = streetName;
            this.city = city;
            this.postcode = postcode;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            const int selectionCount = 5; // Set to how many Choices you have (not including clear or exit) 

            bool exit = false;
            string userSelection;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Would you like to: ");
                Console.WriteLine("[0] New Customer");
                Console.WriteLine("[1] View all accounts");
                Console.WriteLine("[2] View all customers");
                Console.WriteLine("[3] Check account balance");
                Console.WriteLine("[4] Make a transaction");
                Console.WriteLine($"[{selectionCount}] Clear console window");
                Console.WriteLine($"[{selectionCount+1}] Exit");
                Console.WriteLine();

                Console.Write("Enter number of what you would like to do: ");
                userSelection = Console.ReadLine();
  
                try
                {
                    Console.ForegroundColor = ConsoleColor.Gray;

                    switch (int.Parse(userSelection))
                    {
                        case 0: // New customer
                            Console.WriteLine("\n ----------- CREATE NEW CUSTOMER ----------\n");
                            createNewCustomer();
                            Console.WriteLine();
                            break;

                        case 1: // View all accounts
                            Console.WriteLine("\n ----------- VIEW ALL ACCOUNTS ----------\n");
                            viewAllAccounts();
                            Console.WriteLine();
                            break;

                        case 2: // View all customers
                            Console.WriteLine("\n ----------- VIEW ALL CUSTOMERS ----------\n");
                            viewAllCustomers();
                            Console.WriteLine();
                            break;

                        case 3: // Check account balance
                            Console.WriteLine("\n ----------- CHECK ACCOUNT BALANCE ----------\n");
                            checkAccountBalance();
                            Console.WriteLine();
                            break;

                        case 4: // Make a transaction
                            Console.WriteLine("\n ----------- MAKE A TRANSACTION ----------\n");
                            makeTransaction();
                            Console.WriteLine();
                            break;

                        case selectionCount: // Clear Console
                            Console.Clear();
                            break;

                        case selectionCount+1: // Exit
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Not in valid selection range\n");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Not in valid selection range\n");
                }
            } while (!exit);
        }



        static void createNewCustomer()
        {
            checkValidInputLoop("Forename: ", "Not a valid forename", isWord, out string forename);
            checkValidInputLoop("Surname: ", "Not a valid surname", isWord, out string surname);

            checkValidInputLoop("House number: ", "Not a valid input", isNumbers, out string houseNoString); int houseNo = int.Parse(houseNoString);
            checkValidInputLoop("Street name: ", "Not a valid street name", isSentence, out string streetName);
            checkValidInputLoop("Town name: ", "Not a valid town name", isSentence, out string city);
            checkValidInputLoop("Postcode: ", "Not a valid postcode", isPostcode, out string postcode);

            checkValidInputLoop("Mobile Number: ", "Not a valid mobile number", isMobileNumber, out string phoneNumber);
            checkValidInputLoop("Email Address: ", "Not a valid email address", isEmailAddress, out string emailAddress);

            account newAccount = new account(new customer(forename, surname, emailAddress, phoneNumber, new Address(houseNo, streetName, city, postcode), true), true);

            Console.Write($"Account successfully created\nYour account number is ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(newAccount.accountNumber);
            Console.ResetColor();
        }

        static void checkValidInputLoop(string outString, string ifFailOutString, Func<string, bool> testFunction, out string result)
        {
            bool goodInput;
            do
            {
                Console.Write(outString);
                result = Console.ReadLine().ToLower();

                if (!testFunction(result))
                {
                    goodInput = false;
                    Console.WriteLine(ifFailOutString);
                }
                else
                {
                    goodInput = true;
                }
            } while (!goodInput);
        }

        static bool isWord(string input)
        {
            const string letters = "abcdefghijklmnopqrstuvwxyz";
            bool isLetters = true;

            if (input != "")
            {
                foreach (char character in input)
                {
                    if (!letters.Contains(character))
                    {
                        isLetters = false;
                        break;
                    }
                }
            }
            else
            {
                isLetters = false;
            }

            return isLetters;
        }

        static bool isSentence(string input)
        {
            const string letters = "abcdefghijklmnopqrstuvwxyz ";
            bool isLetters = true;

            foreach (char character in input)
            {
                if (!letters.Contains(character))
                {
                    isLetters = false;
                    break;
                }
            }

            return isLetters;
        }

        static bool isNumbers(string input)
        {
            return int.TryParse(input, out _);
        }

        static bool isMobileNumber(string mobileNumber)
        {
            string noSpaces = "";

            for (int i = 0; i < mobileNumber.Length; i++)
            {
                noSpaces += mobileNumber[i] == ' ' ? "" : mobileNumber[i].ToString();
            }

            return new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}").IsMatch(noSpaces);
        }

        static bool isPostcode(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                output += int.TryParse(input, out _) ? input[i].ToString() : input[i].ToString().ToUpper();
            }

            return new Regex("(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX]][0-9][A-HJKSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) [0-9][A-Z-[CIKMOV]]{2})").IsMatch(output); // Looked up the regex cause yk cba
        }

        static bool isEmailAddress(string input)
        {
            return new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$").IsMatch(input);
        }



        static void viewAllAccounts()
        {
            if (account.accounts.Count == 0)
            {
                Console.WriteLine("No Accounts");
            }
            else
            {
                foreach (account account in account.accounts)
                {
                    account.viewAccountBalance();
                }
            }
        }



        static void viewAllCustomers()
        {
            if (account.accounts.Count == 0)
            {
                Console.WriteLine("No Customers");
            }
            else
            {
                for (int i = 0; i < account.accounts.Count; i++)
                {
                    account.accounts[i].Customer.viewCustomerDetails();
                }
            }
        }



        static void checkAccountBalance() 
        {

            int? accountNumber = account.findAccountNumber();

            if (accountNumber != null)
            {
                int index = account.accounts.FindIndex(x => x.accountNumber == accountNumber);
                account.accounts[index].viewAccountBalance();
            }
        }



        static void makeTransaction()
        {
            int? accountNumber = account.findAccountNumber();

            if (accountNumber != null)
            {
                bool exit = false;

                do
                {
                    Console.Write("Would you like to [1] withdraw or [2] deposit money? ");
                    string choice = Console.ReadLine();

                    try
                    {
                        switch (int.Parse(choice))
                        {
                            case 1:
                                account.accounts.Find(x => x.accountNumber == accountNumber).withdrawMoney();
                                exit = true;
                                break;
                            case 2:
                                account.accounts.Find(x => x.accountNumber == accountNumber).depositMoney();
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Not a valid choice\n");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Not an integer\n");
                    }
                } while (!exit);
            }
        }
    }
}
