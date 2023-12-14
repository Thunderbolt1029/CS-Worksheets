using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace Ex8
{
    class Globals
    {
        public static SQLiteConnection SQLiteCon;
        public static SQLiteCommand SQLiteCmd;

        public static Random random = new Random();

        public static int generateUniqueAccountNumber()
        {
            int accountNumber;
            bool unique;

            do
            {
                unique = true;
                accountNumber = random.Next(1, 100000000);

                SQLiteDataReader reader;
                SQLiteCmd.CommandText = "SELECT * FROM TblAccounts WHERE CustID = @CustID";
                SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumber);
                reader = SQLiteCmd.ExecuteReader();
                if (reader.Read())
                {
                    unique = false;
                }
                reader.Close();
            } while (!unique);

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
