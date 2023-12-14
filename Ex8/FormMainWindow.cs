using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.ComponentModel.DataAnnotations;

namespace Ex8
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void FormMainWindow_Load(object sender, EventArgs e)
        {
            Globals.SQLiteCon = new SQLiteConnection("Data Source=Ex8.db; Version = 3; new = true; Compress = true; ");

            try
            {
                Globals.SQLiteCon.Open();

                new command("CREATE TABLE IF NOT EXISTS TblAccounts(CustID INT, AccountBalance DECIMAL, fName VARCHAR(20), sName VARCHAR(20))");
                new command("CREATE TABLE IF NOT EXISTS TblCustomers(CustID INT, fName VARCHAR(20), sName VARCHAR(20), PhoneNumber VARCHAR(15), EmailAddress VARCHAR(40), HouseNumber INT, StreetName VARCHAR(25), Town VARCHAR(20), City VARCHAR(20), Postcode VARCHAR(10))");

                runCommands();

                updateTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void runCommands()
        {
            Globals.SQLiteCmd = Globals.SQLiteCon.CreateCommand();
            foreach (var command in command.commands)
            {
                Globals.SQLiteCmd.CommandText = command.Command;

                foreach (var parameter in command.Parameters)
                {
                    Globals.SQLiteCmd.Parameters.AddWithValue(parameter.key, parameter.value);
                }

                Globals.SQLiteCmd.ExecuteNonQuery();
            }

            command.commands.Clear();
        }

        void updateTables()
        {
            dataGridViewAccounts.Rows.Clear();
            dataGridViewCustomers.Rows.Clear();

            Globals.SQLiteCmd.CommandText = "SELECT * FROM TblAccounts";
            using (var reader = Globals.SQLiteCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dataGridViewAccounts.Rows.Add(new object[]
                    {
                            int.Parse(reader.GetValue(reader.GetOrdinal("CustID")).ToString()).ToString("D8"),
                            "£" + Math.Round(decimal.Parse(reader.GetValue(reader.GetOrdinal("AccountBalance")).ToString()), 2),
                            reader.GetValue(reader.GetOrdinal("fName")),
                            reader.GetValue(reader.GetOrdinal("sName"))
                    });
                }
                reader.Close();
            }

            Globals.SQLiteCmd.CommandText = "SELECT * FROM TblCustomers";
            using (var reader = Globals.SQLiteCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dataGridViewCustomers.Rows.Add(new object[]
                    {
                            int.Parse(reader.GetValue(reader.GetOrdinal("CustID")).ToString()).ToString("D8"),
                            reader.GetValue(reader.GetOrdinal("fName")),
                            reader.GetValue(reader.GetOrdinal("sName")),
                            reader.GetValue(reader.GetOrdinal("PhoneNumber")),
                            reader.GetValue(reader.GetOrdinal("EmailAddress")),
                            reader.GetValue(reader.GetOrdinal("HouseNumber")),
                            reader.GetValue(reader.GetOrdinal("StreetName")),
                            reader.GetValue(reader.GetOrdinal("Town")),
                            reader.GetValue(reader.GetOrdinal("City")),
                            reader.GetValue(reader.GetOrdinal("Postcode"))
                    });
                }
                reader.Close();
            }
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            exchangeMoney("withdraw");
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            exchangeMoney("deposit");
        }

        private void buttonTransact_Click(object sender, EventArgs e)
        {
            exchangeMoney("transact");
        }

        void exchangeMoney(string setting)
        {
            List<string> notGoodInputs = new List<string>();

            switch (setting)
            {
                case "withdraw":
                    if (mskEntryAccountNumberDepositWithdraw.Text.Length < 8)
                    {
                        notGoodInputs.Add("Account number not correct length");

                        if (!decimal.TryParse(entryAmountWithdrawDeposit.Text, out decimal amount))
                            notGoodInputs.Add("Not a valid amount (just enter the amount - no pound sign)");
                    }
                    else
                    {
                        int accountNumber = int.Parse(mskEntryAccountNumberDepositWithdraw.Text);
                        bool validAccountNumber = true, validWithdrawAmount = true;

                        bool found = false;
                        Globals.SQLiteCmd.CommandText = "SELECT * FROM TblAccounts WHERE CustID = @CustID; ";
                        Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumber);
                        using (SQLiteDataReader reader = Globals.SQLiteCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                found = true;
                            }
                            reader.Close();
                        }
                        
                        if (!found)
                        {
                            notGoodInputs.Add("Not a valid account number");
                            validAccountNumber = false;
                        }
                        if (!decimal.TryParse(entryAmountWithdrawDeposit.Text, out decimal amount))
                        {
                            notGoodInputs.Add("Not a valid amount (just enter the amount - no pound sign)");
                            validWithdrawAmount = false;
                        }

                        if (validAccountNumber && validWithdrawAmount)
                        {
                            decimal AccountBalance;

                            Globals.SQLiteCmd.CommandText = "SELECT * FROM TblAccounts WHERE CustID = @CustID; ";
                            Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumber);
                            using (SQLiteDataReader reader = Globals.SQLiteCmd.ExecuteReader())
                            {
                                reader.Read();
                                AccountBalance = reader.GetDecimal(1);
                                reader.Close();
                            }

                            if (AccountBalance < amount)
                                notGoodInputs.Add("Not enough money in account");
                            else
                            {
                                decimal newBalance = AccountBalance -= Math.Round(amount, 2);

                                Globals.SQLiteCmd.CommandText = "UPDATE TblAccounts SET AccountBalance = @AccountBalance WHERE CustID = @CustID; ";
                                Globals.SQLiteCmd.Parameters.AddWithValue("@AccountBalance", newBalance);
                                Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumber);
                                Globals.SQLiteCmd.ExecuteNonQuery();

                                MessageBox.Show("Amount successfully withdrawn", "Withdraw successfull");
                            }

                        }
                    }

                    labelErrorTextWithdrawDeposit.Text = "";
                    foreach (var error in notGoodInputs)
                    {
                        labelErrorTextWithdrawDeposit.Text += error + "\n";
                    }
                    break;

                case "deposit":
                    if (mskEntryAccountNumberDepositWithdraw.Text.Length < 8)
                    {
                        notGoodInputs.Add("Account number not correct length");

                        if (!decimal.TryParse(entryAmountWithdrawDeposit.Text, out decimal amount))
                            notGoodInputs.Add("Not a valid amount (just enter the amount - no pound sign)");
                    }
                    else
                    {
                        int accountNumber = int.Parse(mskEntryAccountNumberDepositWithdraw.Text);
                        bool validAccountNumber = true, validWithdrawAmount = true;

                        bool found = false;
                        Globals.SQLiteCmd.CommandText = "SELECT * FROM TblAccounts WHERE CustID = @CustID; ";
                        Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumber);
                        using (SQLiteDataReader reader = Globals.SQLiteCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                found = true;
                            }
                            reader.Close();
                        }

                        if (!found)
                        {
                            notGoodInputs.Add("Not a valid account number");
                            validAccountNumber = false;
                        }
                        if (!decimal.TryParse(entryAmountWithdrawDeposit.Text, out decimal amount))
                        {
                            notGoodInputs.Add("Not a valid amount (just enter the amount - no pound sign)");
                            validWithdrawAmount = false;
                        }

                        if (validAccountNumber && validWithdrawAmount)
                        {
                            decimal AccountBalance, newBalance;

                            Globals.SQLiteCmd.CommandText = "SELECT * FROM TblAccounts WHERE CustID = @CustID; ";
                            Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumber);
                            using (SQLiteDataReader reader = Globals.SQLiteCmd.ExecuteReader())
                            {
                                reader.Read();
                                AccountBalance = reader.GetDecimal(1);
                                reader.Close();
                            }

                            newBalance = AccountBalance += Math.Round(amount, 2);
                            Globals.SQLiteCmd.CommandText = "UPDATE TblAccounts SET AccountBalance = @AccountBalance WHERE CustID = @CustID; ";
                            Globals.SQLiteCmd.Parameters.AddWithValue("@AccountBalance", newBalance);
                            Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumber);
                            Globals.SQLiteCmd.ExecuteNonQuery();

                            MessageBox.Show("Amount successfully deposited", "Deposit successfull");
                        }
                    }

                    labelErrorTextWithdrawDeposit.Text = "";
                    foreach (var error in notGoodInputs)
                    {
                        labelErrorTextWithdrawDeposit.Text += error + "\n";
                    }
                    break;
                case "transact":
                    if (mskEntryAccountNumberFrom.Text.Length < 8 || mskEntryAccountNumberTo.Text.Length < 8)
                    {
                        notGoodInputs.Add("Account number not correct length");

                        if (!decimal.TryParse(entryAmountTransact.Text, out decimal amount))
                            notGoodInputs.Add("Not a valid amount (just enter the amount - no pound sign)");
                    }
                    else
                    {
                        int accountNumberFrom = int.Parse(mskEntryAccountNumberFrom.Text);
                        int accountNumberTo = int.Parse(mskEntryAccountNumberTo.Text);
                        bool validAccountNumberFrom = true, validAccountNumberTo = true, validTransactAmount = true;

                        bool found = false;
                        Globals.SQLiteCmd.CommandText = "SELECT * FROM TblAccounts WHERE CustID = @CustID; ";
                        Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumberFrom);
                        using (SQLiteDataReader reader = Globals.SQLiteCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                found = true;
                            }
                            reader.Close();
                        }
                        if (!found)
                        {
                            notGoodInputs.Add("Not a valid account number to transact from");
                            validAccountNumberFrom = false;
                        }

                        found = false;
                        Globals.SQLiteCmd.CommandText = "SELECT * FROM TblAccounts WHERE CustID = @CustID; ";
                        Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumberTo);
                        using (SQLiteDataReader reader = Globals.SQLiteCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                found = true;
                            }
                            reader.Close();
                        }
                        if (!found)
                        {
                            notGoodInputs.Add("Not a valid account number to transact to");
                            validAccountNumberTo = false;
                        }
                        if (!decimal.TryParse(entryAmountTransact.Text, out decimal amount))
                        {
                            notGoodInputs.Add("Not a valid amount (just enter the amount - no pound sign)");
                            validTransactAmount = false;
                        }

                        if (validAccountNumberFrom && validAccountNumberTo && validTransactAmount)
                        {
                            decimal AccountBalanceFrom, AccountBalanceTo;

                            Globals.SQLiteCmd.CommandText = "SELECT * FROM TblAccounts WHERE CustID = @CustID; ";
                            Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumberFrom);
                            using (SQLiteDataReader reader = Globals.SQLiteCmd.ExecuteReader())
                            {
                                reader.Read();
                                AccountBalanceFrom = reader.GetDecimal(1);
                                reader.Close();
                            }

                            Globals.SQLiteCmd.CommandText = "SELECT * FROM TblAccounts WHERE CustID = @CustID; ";
                            Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumberTo);
                            using (SQLiteDataReader reader = Globals.SQLiteCmd.ExecuteReader())
                            {
                                reader.Read();
                                AccountBalanceTo = reader.GetDecimal(1);
                                reader.Close();
                            }

                            if (AccountBalanceFrom < amount)
                                notGoodInputs.Add("Not enough money in account");
                            else
                            {
                                decimal newBalanceFrom = AccountBalanceFrom -= Math.Round(amount, 2);
                                decimal newBalanceTo = AccountBalanceTo += Math.Round(amount, 2);

                                Globals.SQLiteCmd.CommandText = "UPDATE TblAccounts SET AccountBalance = @AccountBalance WHERE CustID = @CustID; ";
                                Globals.SQLiteCmd.Parameters.AddWithValue("@AccountBalance", newBalanceFrom);
                                Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumberFrom);
                                Globals.SQLiteCmd.ExecuteNonQuery();

                                Globals.SQLiteCmd.CommandText = "UPDATE TblAccounts SET AccountBalance = @AccountBalance WHERE CustID = @CustID; ";
                                Globals.SQLiteCmd.Parameters.AddWithValue("@AccountBalance", newBalanceTo);
                                Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumberTo);
                                Globals.SQLiteCmd.ExecuteNonQuery();

                                MessageBox.Show("Amount successfully transacted", "Transation successful");
                            }
                        }
                    }

                    labelErrorTextTransact.Text = "";
                    foreach (var error in notGoodInputs)
                    {
                        labelErrorTextTransact.Text += error + "\n";
                    }
                    break;
            }
            updateTables();
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            if (!isGoodInputs(out List<string> notGoodInputs))
            {
                labelErrorTextAddAccount.Text = "";
                foreach (var error in notGoodInputs)
                {
                    labelErrorTextAddAccount.Text += error + "\n";
                }
            }
            else
            {
                labelErrorTextAddAccount.Text = "";

                int accountNumber = Globals.generateUniqueAccountNumber();

                Globals.SQLiteCmd = Globals.SQLiteCon.CreateCommand();
                Globals.SQLiteCmd.CommandText = "INSERT INTO TblCustomers(CustID, fName, sName, PhoneNumber, EmailAddress, HouseNumber, StreetName, Town, City, Postcode) VALUES(@CustID, @fName, @sName, @PhoneNumber, @EmailAddress, @HouseNumber, @StreetName, @Town, @City, @Postcode)";
                Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumber);
                Globals.SQLiteCmd.Parameters.AddWithValue("@fName", entryForename.Text);
                Globals.SQLiteCmd.Parameters.AddWithValue("@sName", entrySurname.Text);
                Globals.SQLiteCmd.Parameters.AddWithValue("@PhoneNumber", entryPhoneNumber.Text);
                Globals.SQLiteCmd.Parameters.AddWithValue("@EmailAddress", entryEmailAddress.Text);
                Globals.SQLiteCmd.Parameters.AddWithValue("@HouseNumber", int.Parse(entryHouseNumber.Text));
                Globals.SQLiteCmd.Parameters.AddWithValue("@StreetName", entryStreet.Text);
                Globals.SQLiteCmd.Parameters.AddWithValue("@Town", entryTown.Text);
                Globals.SQLiteCmd.Parameters.AddWithValue("@City", entryCity.Text);
                Globals.SQLiteCmd.Parameters.AddWithValue("@Postcode", entryPostcode.Text);
                Globals.SQLiteCmd.ExecuteNonQuery();

                Globals.SQLiteCmd = Globals.SQLiteCon.CreateCommand();
                Globals.SQLiteCmd.CommandText = "INSERT INTO TblAccounts(CustID, AccountBalance, fName, sName) VALUES(@CustID, @AccountBalance, @fName, @sName)";
                Globals.SQLiteCmd.Parameters.AddWithValue("@CustID", accountNumber);
                Globals.SQLiteCmd.Parameters.AddWithValue("@AccountBalance", 0.00M);
                Globals.SQLiteCmd.Parameters.AddWithValue("@fName", entryForename.Text);
                Globals.SQLiteCmd.Parameters.AddWithValue("@sName", entrySurname.Text);
                Globals.SQLiteCmd.ExecuteNonQuery();

                updateTables();
                MessageBox.Show($"Your account number is {accountNumber}", "New account successfully created");
            }
        }

        bool isGoodInputs(out List<string> notGoodInputs)
        {
            notGoodInputs = new List<string>();

            if (entryForename.Text == "")
            {
                notGoodInputs.Add("Forename form is empty");
            }

            if (entrySurname.Text == "")
            {
                notGoodInputs.Add("Surname form is empty");
            }

            bool found = false;
            Globals.SQLiteCmd.CommandText = "SELECT * FROM TblCustomers WHERE EmailAddress = @EmailAddress; ";
            Globals.SQLiteCmd.Parameters.AddWithValue("@EmailAddress", entryEmailAddress.Text);
            using (SQLiteDataReader reader = Globals.SQLiteCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    found = true;
                }
                reader.Close();
            }
            if (entryEmailAddress.Text == "")
            {
                notGoodInputs.Add("Email Address form is empty");
            }
            else if (!new EmailAddressAttribute().IsValid(entryEmailAddress.Text))
            {
                notGoodInputs.Add("Not a valid Email Address");
            }
            else if (found)
            {
                notGoodInputs.Add("Email address already used");
            }

            if (entryPhoneNumber.Text == "")
            {
                notGoodInputs.Add("Phone Number form is empty");
            }
            else if (!new PhoneAttribute().IsValid(entryPhoneNumber.Text))
            {
                notGoodInputs.Add("Not a valid Phone Number");
            }

            if (entryHouseNumber.Text == "")
            {
                notGoodInputs.Add("House Number form is empty");
            }
            else if (!int.TryParse(entryHouseNumber.Text, out _))
            {
                notGoodInputs.Add("House Number isn't a number");
            }

            if (entryStreet.Text == "")
            {
                notGoodInputs.Add("Street form is empty");
            }

            if (entryTown.Text == "")
            {
                notGoodInputs.Add("Town form is empty");
            }

            if (entryCity.Text == "")
            {
                notGoodInputs.Add("City form is empty");
            }

            if (entryPostcode.Text == "")
            {
                notGoodInputs.Add("Postcode form is empty");
            }
            else if (!Globals.isValidPostcode(entryPostcode.Text))
            {
                notGoodInputs.Add("Not a valid Postcode");
            }

            return notGoodInputs.Count == 0;
        }
    }
}