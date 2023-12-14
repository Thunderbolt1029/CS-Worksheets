using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Ex7
{
    public partial class formWindow : Form
    {
        public formWindow()
        {
            InitializeComponent();
        }

        private void formWindow_Load(object sender, EventArgs e)
        {
            Globals.createNewCustomerAccount(out account newAccount, out customer newCustomer, "Zac", "Royle", "z.r@gmail.ac.uk", "07805 369941", new Address(69, "lil street", "grimsville", "p town", "PR3 3YJ"));
            Globals.accounts.Add(newAccount);
            Globals.customers.Add(newCustomer);
            
            Globals.createNewCustomerAccount(out newAccount, out newCustomer, "Joe", "Mamma", "suck_on_deez@ligma.com", "069420 42069", new Address(420, "bigg street", "loŋ", "p ville", "M23 8LP"));
            Globals.accounts.Add(newAccount);
            Globals.customers.Add(newCustomer);

            tableViewAccounts.AutoGenerateColumns = false;
            tableViewAccounts.DataSource = Globals.accounts;

            tableViewCustomers.AutoGenerateColumns = false;
            tableViewCustomers.DataSource = Globals.customers;
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
                Globals.createNewCustomerAccount(out account newAccount, out customer newCustomer, entryForename.Text, entrySurname.Text, entryEmailAddress.Text, entryPhoneNumber.Text, new Address(int.Parse(entryHouseNumber.Text), entryStreet.Text, entryTown.Text, entryCity.Text, entryPostcode.Text));
                Globals.accounts.Add(newAccount);
                Globals.customers.Add(newCustomer);

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

            if (entryEmailAddress.Text == "")
            {
                notGoodInputs.Add("Email Address form is empty");
            }
            else if (!new EmailAddressAttribute().IsValid(entryEmailAddress.Text))
            {
                notGoodInputs.Add("Not a valid Email Address");
            }
            else if (Globals.customers.Any(x => x.emailAddress == entryEmailAddress.Text))
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

                        if (!Globals.accounts.Any(x => x.accountNumber == accountNumber))
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
                            var account = Globals.accounts.First(x => x.accountNumber == accountNumber);

                            if (account.decBalance < amount)
                                notGoodInputs.Add("Not enough money in account");
                            else
                            {
                                account.decBalance -= Math.Round(amount, 2);
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

                        if (!Globals.accounts.Any(x => x.accountNumber == accountNumber))
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
                            var account = Globals.accounts.First(x => x.accountNumber == accountNumber);
                            account.decBalance += Math.Round(amount, 2);
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

                        if (!Globals.accounts.Any(x => x.accountNumber == accountNumberFrom))
                        {
                            notGoodInputs.Add("Not a valid account number to transact from");
                            validAccountNumberFrom = false;
                        }
                        if (!Globals.accounts.Any(x => x.accountNumber == accountNumberTo))
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
                            var accountFrom = Globals.accounts.First(x => x.accountNumber == accountNumberFrom);
                            var accountTo = Globals.accounts.First(x => x.accountNumber == accountNumberTo);

                            if (accountFrom.decBalance < amount)
                                notGoodInputs.Add("Not enough money in account");
                            else
                            {
                                accountFrom.decBalance -= Math.Round(amount, 2);
                                accountTo.decBalance += Math.Round(amount, 2);
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
        }
    }
}
