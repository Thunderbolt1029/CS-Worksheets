using System;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Ex5c
{
    class databaseEntry
    {
        static public int count
        {
            get;
            private set;
        } = 0;

        public string forename
        {
            get; private set;
        }

        public string surname
        {
            get; private set;
        }
        public DateTime dob
        {
            get; private set;
        }
        public int? houseNo
        {
            get; private set;
        }
        public string streetName
        {
            get; private set;
        }
        public string town
        {
            get; private set;
        }
        public string postcode
        {
            get; private set;
        }
        public string mobileNumber
        {
            get; private set;
        }
        public string emailAddress
        {
            get; private set;
        }

        public databaseEntry(string _forename = null,
                             string _surname = null,
                             DateTime _dob = new DateTime(),
                             int? _houseNo = null,
                             string _streetName = null,
                             string _town = null,
                             string _postcode = null,
                             string _mobileNumber = null,
                             string _emailAddress = null)
        {
            count += 1;

            forename = _forename;
            surname = _surname;
            dob = _dob;
            houseNo = _houseNo;
            streetName = _streetName;
            town = _town;
            postcode = _postcode;
            mobileNumber = _mobileNumber;
            emailAddress = _emailAddress;
        }


        // Validates mobile numbers, returns true if the entered number is valid
        public static bool isMobileNumber(string mobileNumber)
        {
            string noSpaces = "";

            for (int i = 0; i < mobileNumber.Length; i++)
            {
                noSpaces += mobileNumber[i] == ' ' ? "" : mobileNumber[i];
            }

            return new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}").IsMatch(noSpaces);
        }

        // Validates email addresses, returns true if the entered email address is valid
        public static bool isEmailAddress(string emailAddress)
        {
            const string allowedChars = "abcdefghijklmnopqrstuvwxyz.";

            string[] splitEmailAddress = new string[3];
            bool oneAtSign, noSpace, onlyLettersAfterDot, threeSectionsHaveValue;
            emailAddress = emailAddress.ToLower();

            oneAtSign = emailAddress.Split('@').Length - 1 == 1;
            noSpace = !emailAddress.Contains(' ');

            splitEmailAddress[0] = emailAddress.Split('@')[0];
            splitEmailAddress[1] = emailAddress.Split('@')[1];
            splitEmailAddress[2] = concat(splitEmailAddress[1]
                                                            .Split('.', 2)
                                                            .Skip(1)
                                                            .ToArray());
            splitEmailAddress[1] = splitEmailAddress[1].Split('.')[0];

            threeSectionsHaveValue = true;
            foreach (string section in splitEmailAddress)
            {
                threeSectionsHaveValue = section == "" ? false : threeSectionsHaveValue;
            }

            onlyLettersAfterDot = true;
            foreach (char character in splitEmailAddress[2])
            {
                onlyLettersAfterDot = allowedChars.Contains(character) ? onlyLettersAfterDot : false;
            }

            return oneAtSign && noSpace && threeSectionsHaveValue && onlyLettersAfterDot;
        }
        static string concat(string[] stringArray)
        {
            string concatString = "";

            foreach (string _string in stringArray)
            {
                concatString += _string;
            }

            return concatString;
        }

        public static bool isdob(string input)
        {
            return DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }

        public static bool isPostcode(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                output += int.TryParse(input, out _) ? input[i] : input[i].ToString().ToUpper();
            }

            return new Regex(@"(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX]][0-9][A-HJKSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) [0-9][A-Z-[CIKMOV]]{2})").IsMatch(output); // Looked up the regex cause yk cba
        }
    }
}