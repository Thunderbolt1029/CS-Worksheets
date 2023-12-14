using System;
using System.Collections.Generic;
using System.Globalization;



// Searching for and editing entries arn't completed




namespace Ex5c
{
    class Program
    {
        static List<databaseEntry> database = new List<databaseEntry>();

        static void Main(string[] args)
        {
            const int selectionMax = 4;

            string userSelection;


            database.Add(new databaseEntry("joe", "mamma", DateTime.ParseExact("22/03/2006", "dd/MM/yyyy", CultureInfo.InvariantCulture), 69, "lil street", "grimsville", "PR3 3YJ", "07805369941", "zacatron1234@gmail.com")); // Temp starting database entry


            do
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Would you like to: ");
                Console.WriteLine("[0] Enter a new Record");
                Console.WriteLine("[1] View all existing Records");
                Console.WriteLine("[2] Search for record by surname");
                Console.WriteLine("[3] Edit a customer record");
                Console.WriteLine("[4] Clear console window");
                Console.WriteLine("[5] Exit");
                Console.WriteLine();

                Console.Write("Enter number of what you would like to do: ");
                userSelection = Console.ReadLine();

                try
                {
                    Console.ForegroundColor = ConsoleColor.Gray;

                    switch (int.Parse(userSelection))
                    {
                        case 0: // New record
                            newRecord();
                            break;

                        case 1: // View all records
                            viewAllRecords();
                            break;

                        case 2: // Search
                            Console.WriteLine("Search record\n");
                            break;

                        case 3: // Edit record
                            Console.WriteLine("Edit record\n");
                            break;

                        case 4: // Clear Console
                            Console.Clear();
                            break;

                        case 5: // Exit
                            break;

                        default:
                            Console.WriteLine("Not in valid selection range\n");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Not a number\n");
                }
    
                } while (!(isGoodSelection(userSelection, selectionMax) && int.TryParse(userSelection, out _) ? int.Parse(userSelection) == 5 : true));
        }

        static bool isGoodSelection(string selection, int max)
        {
            bool isInt = int.TryParse(selection, out int choice);
            bool isGoodLength = choice >= 0 && choice <= max;

            return isInt && isGoodLength;
        }


        // Enters a new record into database and returns the record in the datatype
        static databaseEntry newRecord()
        {
            string forename, surname, streetName, town, postcode, emailAddress, houseNoString, dobString, mobileNumber;
            int houseNo;
            DateTime dob;


            Console.WriteLine("\n\n---------- ENTER NEW RECORD ----------\n");

            checkValidInputLoop("Forename: ", "Not a valid forename", isWord, out forename);
            checkValidInputLoop("Surname: ", "Not a valid surname", isWord, out surname);
            checkValidInputLoop("Date of Birth (DD/MM/YYYY): ", "Not a valid birth date", databaseEntry.isdob, out dobString); dob = DateTime.ParseExact(dobString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            checkValidInputLoop("House number: ", "Not a number", isNumbers, out houseNoString); houseNo = int.Parse(houseNoString);
            checkValidInputLoop("Street name: ", "Not a valid street name", isSentence, out streetName);
            checkValidInputLoop("Town name: ", "Not a valid town name", isSentence, out town);
            checkValidInputLoop("Postcode: ", "Not a valid postcode", databaseEntry.isPostcode, out postcode);

            checkValidInputLoop("Mobile Number: ", "Not a valid mobile number", databaseEntry.isMobileNumber, out mobileNumber);
            checkValidInputLoop("Email Address: ", "Not a valid email address", databaseEntry.isEmailAddress, out emailAddress);


            Console.WriteLine();

            databaseEntry newEntry = new databaseEntry(forename, surname, dob, houseNo, streetName, town, postcode, mobileNumber, emailAddress);
            database.Add(newEntry);

            return newEntry;
        }

        static void checkValidInputLoop(string outString, string ifFailOutString, Func<string, bool> testFunction, out string result)
        {
            bool goodInput = false;
            do
            {
                Console.Write(outString);
                result = Console.ReadLine();

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

            if (input!="")
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


        // Returns an array of all database records
        static databaseEntry[] viewAllRecords()
        {
            databaseEntry[] databaseArray = database.ToArray();

            if (databaseArray.Length!=0)
            {
                printEntry(databaseArray[0], true);
                try
                {
                    for (int i = 1; i < databaseArray.Length; i++)
                    {
                        printEntry(databaseArray[i]);
                    }
                }
                catch { } // databaseArray has 1 element
                
            }
            else
            {
                Console.WriteLine("The database is empty");
            }

            Console.WriteLine();
            return databaseArray;
        }

        // Searches through the database by surname and returns an array of all entries that match
        static databaseEntry[] searchRecordSurname()
        {
            string surname = "";

            List<databaseEntry> positiveResults = new List<databaseEntry>();

            foreach (databaseEntry entry in database)
            {
                if (entry.surname == surname)
                {
                    positiveResults.Add(entry);
                }
            }

            return positiveResults.ToArray();
        }

        // Edits an entry (searched by surname) and returns the updated entry
        static databaseEntry editEntry(string surname)
        {
            databaseEntry searchedEntry = null;

            if (database.Contains(new databaseEntry(_surname: surname)))
            {
                for (int i = 0; i < database.Count; i++)
                {
                    if (database[i].surname == surname)
                    {
                        searchedEntry = database[i];
                        break;
                    }
                }
            }

            return searchedEntry;
        }

        static void printEntry(databaseEntry entry, bool printLabels = false)
        {
            if (printLabels)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.Write("Forename\t\t");
                Console.Write("Surname\t\t\t");
                Console.Write("Date of Birth\t\t");

                Console.Write("House number\t\t");
                Console.Write("Street name\t\t");
                Console.Write("Town name\t\t");
                Console.Write("Postcode\t\t");

                Console.Write("Mobile Number\t\t");
                Console.Write("Email Address");

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write(entry.forename + tabs(entry.forename));
            Console.Write(entry.surname + tabs(entry.surname));
            Console.Write($"{entry.dob.Day}/{entry.dob.Month}/{entry.dob.Year}\t\t");

            Console.Write(entry.houseNo + tabs(entry.houseNo.ToString()));
            Console.Write(entry.streetName + tabs(entry.streetName));
            Console.Write(entry.town + tabs(entry.town));
            Console.Write(entry.postcode + tabs(entry.postcode));

            Console.Write(entry.mobileNumber + tabs(entry.mobileNumber));
            Console.Write(entry.emailAddress);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
        }

        static string tabs(string str)
        {
            string tabs = "";

            for (int i = 0; i < 24-str.Length; i++)
            {
                tabs += ' ';
            }
            
            return tabs;
        }
    }
}