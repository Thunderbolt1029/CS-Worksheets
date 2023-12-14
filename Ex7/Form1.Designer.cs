
namespace Ex7
{
    partial class formWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabsGeneralTabs = new System.Windows.Forms.TabControl();
            this.tabViewAccounts = new System.Windows.Forms.TabPage();
            this.tableViewAccounts = new System.Windows.Forms.DataGridView();
            this.accountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabViewCustomers = new System.Windows.Forms.TabPage();
            this.tableViewCustomers = new System.Windows.Forms.DataGridView();
            this.custAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMakeTransaction = new System.Windows.Forms.TabPage();
            this.groupTransact = new System.Windows.Forms.GroupBox();
            this.labelErrorTextTransact = new System.Windows.Forms.Label();
            this.mskEntryAccountNumberFrom = new System.Windows.Forms.MaskedTextBox();
            this.mskEntryAccountNumberTo = new System.Windows.Forms.MaskedTextBox();
            this.buttonTransact = new System.Windows.Forms.Button();
            this.entryAmountTransact = new System.Windows.Forms.TextBox();
            this.labelAccountNumberTo = new System.Windows.Forms.Label();
            this.labelAmountTransact = new System.Windows.Forms.Label();
            this.labelAccountNumberFrom = new System.Windows.Forms.Label();
            this.groupWithdrawDeposit = new System.Windows.Forms.GroupBox();
            this.labelErrorTextWithdrawDeposit = new System.Windows.Forms.Label();
            this.entryAmountWithdrawDeposit = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.mskEntryAccountNumberDepositWithdraw = new System.Windows.Forms.MaskedTextBox();
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.tabAddAccount = new System.Windows.Forms.TabPage();
            this.labelErrorTextAddAccount = new System.Windows.Forms.Label();
            this.entryPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.entryPostcode = new System.Windows.Forms.TextBox();
            this.labelPostcode = new System.Windows.Forms.Label();
            this.entryCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.entryTown = new System.Windows.Forms.TextBox();
            this.labelTown = new System.Windows.Forms.Label();
            this.entryStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.entryHouseNumber = new System.Windows.Forms.TextBox();
            this.labelHouseNumber = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.entryEmailAddress = new System.Windows.Forms.TextBox();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.entrySurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.entryForename = new System.Windows.Forms.TextBox();
            this.labelForename = new System.Windows.Forms.Label();
            this.maskedEntryWithdrawAccNum = new System.Windows.Forms.MaskedTextBox();
            this.labelAccountNumberWithdraw = new System.Windows.Forms.Label();
            this.labelAccountNumberDeposit = new System.Windows.Forms.Label();
            this.maskedEntryDepositAccNo = new System.Windows.Forms.MaskedTextBox();
            this.maskedEntryDepositAccNum = new System.Windows.Forms.MaskedTextBox();
            this.maskedEntryWithdrawAccNo = new System.Windows.Forms.MaskedTextBox();
            this.maskedEntryAccountNumberDeposit = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxAccNum = new System.Windows.Forms.GroupBox();
            this.tabsGeneralTabs.SuspendLayout();
            this.tabViewAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableViewAccounts)).BeginInit();
            this.tabViewCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableViewCustomers)).BeginInit();
            this.tabMakeTransaction.SuspendLayout();
            this.groupTransact.SuspendLayout();
            this.groupWithdrawDeposit.SuspendLayout();
            this.tabAddAccount.SuspendLayout();
            this.groupBoxAccNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsGeneralTabs
            // 
            this.tabsGeneralTabs.Controls.Add(this.tabViewAccounts);
            this.tabsGeneralTabs.Controls.Add(this.tabViewCustomers);
            this.tabsGeneralTabs.Controls.Add(this.tabMakeTransaction);
            this.tabsGeneralTabs.Controls.Add(this.tabAddAccount);
            this.tabsGeneralTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsGeneralTabs.Location = new System.Drawing.Point(0, 0);
            this.tabsGeneralTabs.Name = "tabsGeneralTabs";
            this.tabsGeneralTabs.SelectedIndex = 0;
            this.tabsGeneralTabs.Size = new System.Drawing.Size(853, 440);
            this.tabsGeneralTabs.TabIndex = 0;
            // 
            // tabViewAccounts
            // 
            this.tabViewAccounts.Controls.Add(this.tableViewAccounts);
            this.tabViewAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabViewAccounts.Name = "tabViewAccounts";
            this.tabViewAccounts.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabViewAccounts.Size = new System.Drawing.Size(845, 414);
            this.tabViewAccounts.TabIndex = 1;
            this.tabViewAccounts.Text = "View Accounts";
            this.tabViewAccounts.UseVisualStyleBackColor = true;
            // 
            // tableViewAccounts
            // 
            this.tableViewAccounts.AllowUserToAddRows = false;
            this.tableViewAccounts.AllowUserToDeleteRows = false;
            this.tableViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableViewAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNumber,
            this.accountBalance,
            this.fname,
            this.sname});
            this.tableViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableViewAccounts.Location = new System.Drawing.Point(3, 3);
            this.tableViewAccounts.Name = "tableViewAccounts";
            this.tableViewAccounts.ReadOnly = true;
            this.tableViewAccounts.RowHeadersWidth = 51;
            this.tableViewAccounts.Size = new System.Drawing.Size(839, 408);
            this.tableViewAccounts.TabIndex = 0;
            // 
            // accountNumber
            // 
            this.accountNumber.DataPropertyName = "accountNumber";
            this.accountNumber.HeaderText = "Account Number";
            this.accountNumber.MinimumWidth = 6;
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.ReadOnly = true;
            this.accountNumber.Width = 125;
            // 
            // accountBalance
            // 
            this.accountBalance.DataPropertyName = "stringBalance";
            this.accountBalance.HeaderText = "Account Balance";
            this.accountBalance.MinimumWidth = 6;
            this.accountBalance.Name = "accountBalance";
            this.accountBalance.ReadOnly = true;
            this.accountBalance.Width = 125;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "custfName";
            this.fname.HeaderText = "Forename";
            this.fname.MinimumWidth = 6;
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 125;
            // 
            // sname
            // 
            this.sname.DataPropertyName = "custsName";
            this.sname.HeaderText = "Surname";
            this.sname.MinimumWidth = 6;
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            this.sname.Width = 125;
            // 
            // tabViewCustomers
            // 
            this.tabViewCustomers.Controls.Add(this.tableViewCustomers);
            this.tabViewCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabViewCustomers.Name = "tabViewCustomers";
            this.tabViewCustomers.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabViewCustomers.Size = new System.Drawing.Size(845, 414);
            this.tabViewCustomers.TabIndex = 2;
            this.tabViewCustomers.Text = "View Customers";
            this.tabViewCustomers.UseVisualStyleBackColor = true;
            // 
            // tableViewCustomers
            // 
            this.tableViewCustomers.AllowUserToAddRows = false;
            this.tableViewCustomers.AllowUserToDeleteRows = false;
            this.tableViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custAccountNumber,
            this.custfName,
            this.custsName,
            this.phoneNumber,
            this.emailAddress,
            this.houseNumber,
            this.streetName,
            this.town,
            this.city,
            this.postcode});
            this.tableViewCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableViewCustomers.Location = new System.Drawing.Point(3, 3);
            this.tableViewCustomers.Name = "tableViewCustomers";
            this.tableViewCustomers.ReadOnly = true;
            this.tableViewCustomers.RowHeadersWidth = 51;
            this.tableViewCustomers.Size = new System.Drawing.Size(839, 408);
            this.tableViewCustomers.TabIndex = 0;
            // 
            // custAccountNumber
            // 
            this.custAccountNumber.DataPropertyName = "accountNumber";
            this.custAccountNumber.HeaderText = "Account Number";
            this.custAccountNumber.MinimumWidth = 6;
            this.custAccountNumber.Name = "custAccountNumber";
            this.custAccountNumber.ReadOnly = true;
            this.custAccountNumber.Width = 125;
            // 
            // custfName
            // 
            this.custfName.DataPropertyName = "forename";
            this.custfName.HeaderText = "Forename";
            this.custfName.MinimumWidth = 6;
            this.custfName.Name = "custfName";
            this.custfName.ReadOnly = true;
            this.custfName.Width = 125;
            // 
            // custsName
            // 
            this.custsName.DataPropertyName = "surname";
            this.custsName.HeaderText = "Surname";
            this.custsName.MinimumWidth = 6;
            this.custsName.Name = "custsName";
            this.custsName.ReadOnly = true;
            this.custsName.Width = 125;
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "phoneNumber";
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Width = 125;
            // 
            // emailAddress
            // 
            this.emailAddress.DataPropertyName = "emailAddress";
            this.emailAddress.HeaderText = "Email Address";
            this.emailAddress.MinimumWidth = 6;
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.ReadOnly = true;
            this.emailAddress.Width = 125;
            // 
            // houseNumber
            // 
            this.houseNumber.DataPropertyName = "addHouseNumber";
            this.houseNumber.HeaderText = "House Number";
            this.houseNumber.MinimumWidth = 6;
            this.houseNumber.Name = "houseNumber";
            this.houseNumber.ReadOnly = true;
            this.houseNumber.Width = 125;
            // 
            // streetName
            // 
            this.streetName.DataPropertyName = "addStreetName";
            this.streetName.HeaderText = "Street Name";
            this.streetName.MinimumWidth = 6;
            this.streetName.Name = "streetName";
            this.streetName.ReadOnly = true;
            this.streetName.Width = 125;
            // 
            // town
            // 
            this.town.DataPropertyName = "addTown";
            this.town.HeaderText = "Town";
            this.town.MinimumWidth = 6;
            this.town.Name = "town";
            this.town.ReadOnly = true;
            this.town.Width = 125;
            // 
            // city
            // 
            this.city.DataPropertyName = "addCity";
            this.city.HeaderText = "City";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 125;
            // 
            // postcode
            // 
            this.postcode.DataPropertyName = "addPostcode";
            this.postcode.HeaderText = "Postcode";
            this.postcode.MinimumWidth = 6;
            this.postcode.Name = "postcode";
            this.postcode.ReadOnly = true;
            this.postcode.Width = 125;
            // 
            // tabMakeTransaction
            // 
            this.tabMakeTransaction.Controls.Add(this.groupTransact);
            this.tabMakeTransaction.Controls.Add(this.groupWithdrawDeposit);
            this.tabMakeTransaction.Location = new System.Drawing.Point(4, 22);
            this.tabMakeTransaction.Name = "tabMakeTransaction";
            this.tabMakeTransaction.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabMakeTransaction.Size = new System.Drawing.Size(843, 408);
            this.tabMakeTransaction.TabIndex = 5;
            this.tabMakeTransaction.Text = "Make Transaction";
            this.tabMakeTransaction.UseVisualStyleBackColor = true;
            // 
            // groupTransact
            // 
            this.groupTransact.Controls.Add(this.labelErrorTextTransact);
            this.groupTransact.Controls.Add(this.mskEntryAccountNumberFrom);
            this.groupTransact.Controls.Add(this.mskEntryAccountNumberTo);
            this.groupTransact.Controls.Add(this.buttonTransact);
            this.groupTransact.Controls.Add(this.entryAmountTransact);
            this.groupTransact.Controls.Add(this.labelAccountNumberTo);
            this.groupTransact.Controls.Add(this.labelAmountTransact);
            this.groupTransact.Controls.Add(this.labelAccountNumberFrom);
            this.groupTransact.Location = new System.Drawing.Point(388, 6);
            this.groupTransact.Name = "groupTransact";
            this.groupTransact.Size = new System.Drawing.Size(450, 409);
            this.groupTransact.TabIndex = 1;
            this.groupTransact.TabStop = false;
            this.groupTransact.Text = "Transact between accounts";
            // 
            // labelErrorTextTransact
            // 
            this.labelErrorTextTransact.AutoSize = true;
            this.labelErrorTextTransact.ForeColor = System.Drawing.Color.Crimson;
            this.labelErrorTextTransact.Location = new System.Drawing.Point(20, 132);
            this.labelErrorTextTransact.Name = "labelErrorTextTransact";
            this.labelErrorTextTransact.Size = new System.Drawing.Size(0, 13);
            this.labelErrorTextTransact.TabIndex = 24;
            // 
            // mskEntryAccountNumberFrom
            // 
            this.mskEntryAccountNumberFrom.Location = new System.Drawing.Point(119, 42);
            this.mskEntryAccountNumberFrom.Mask = "00000000";
            this.mskEntryAccountNumberFrom.Name = "mskEntryAccountNumberFrom";
            this.mskEntryAccountNumberFrom.Size = new System.Drawing.Size(73, 20);
            this.mskEntryAccountNumberFrom.TabIndex = 5;
            // 
            // mskEntryAccountNumberTo
            // 
            this.mskEntryAccountNumberTo.Location = new System.Drawing.Point(338, 42);
            this.mskEntryAccountNumberTo.Mask = "00000000";
            this.mskEntryAccountNumberTo.Name = "mskEntryAccountNumberTo";
            this.mskEntryAccountNumberTo.Size = new System.Drawing.Size(73, 20);
            this.mskEntryAccountNumberTo.TabIndex = 6;
            // 
            // buttonTransact
            // 
            this.buttonTransact.Location = new System.Drawing.Point(200, 274);
            this.buttonTransact.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTransact.Name = "buttonTransact";
            this.buttonTransact.Size = new System.Drawing.Size(60, 22);
            this.buttonTransact.TabIndex = 8;
            this.buttonTransact.Text = "Transact";
            this.buttonTransact.UseVisualStyleBackColor = true;
            this.buttonTransact.Click += new System.EventHandler(this.buttonTransact_Click);
            // 
            // entryAmountTransact
            // 
            this.entryAmountTransact.Location = new System.Drawing.Point(203, 89);
            this.entryAmountTransact.Margin = new System.Windows.Forms.Padding(2);
            this.entryAmountTransact.Name = "entryAmountTransact";
            this.entryAmountTransact.Size = new System.Drawing.Size(81, 20);
            this.entryAmountTransact.TabIndex = 7;
            // 
            // labelAccountNumberTo
            // 
            this.labelAccountNumberTo.AutoSize = true;
            this.labelAccountNumberTo.Location = new System.Drawing.Point(239, 38);
            this.labelAccountNumberTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccountNumberTo.Name = "labelAccountNumberTo";
            this.labelAccountNumberTo.Size = new System.Drawing.Size(90, 26);
            this.labelAccountNumberTo.TabIndex = 2;
            this.labelAccountNumberTo.Text = "Account Number \r\nto Transact to";
            // 
            // labelAmountTransact
            // 
            this.labelAmountTransact.AutoSize = true;
            this.labelAmountTransact.Location = new System.Drawing.Point(154, 91);
            this.labelAmountTransact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmountTransact.Name = "labelAmountTransact";
            this.labelAmountTransact.Size = new System.Drawing.Size(43, 13);
            this.labelAmountTransact.TabIndex = 1;
            this.labelAmountTransact.Text = "Amount";
            // 
            // labelAccountNumberFrom
            // 
            this.labelAccountNumberFrom.AutoSize = true;
            this.labelAccountNumberFrom.Location = new System.Drawing.Point(20, 38);
            this.labelAccountNumberFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccountNumberFrom.Name = "labelAccountNumberFrom";
            this.labelAccountNumberFrom.Size = new System.Drawing.Size(90, 26);
            this.labelAccountNumberFrom.TabIndex = 0;
            this.labelAccountNumberFrom.Text = "Account Number \r\nto Transact from";
            this.labelAccountNumberFrom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupWithdrawDeposit
            // 
            this.groupWithdrawDeposit.Controls.Add(this.labelErrorTextWithdrawDeposit);
            this.groupWithdrawDeposit.Controls.Add(this.entryAmountWithdrawDeposit);
            this.groupWithdrawDeposit.Controls.Add(this.labelAmount);
            this.groupWithdrawDeposit.Controls.Add(this.mskEntryAccountNumberDepositWithdraw);
            this.groupWithdrawDeposit.Controls.Add(this.labelAccountNumber);
            this.groupWithdrawDeposit.Controls.Add(this.buttonDeposit);
            this.groupWithdrawDeposit.Controls.Add(this.buttonWithdraw);
            this.groupWithdrawDeposit.Location = new System.Drawing.Point(9, 6);
            this.groupWithdrawDeposit.Name = "groupWithdrawDeposit";
            this.groupWithdrawDeposit.Size = new System.Drawing.Size(374, 409);
            this.groupWithdrawDeposit.TabIndex = 0;
            this.groupWithdrawDeposit.TabStop = false;
            this.groupWithdrawDeposit.Text = "Withdraw / Deposit";
            // 
            // labelErrorTextWithdrawDeposit
            // 
            this.labelErrorTextWithdrawDeposit.AutoSize = true;
            this.labelErrorTextWithdrawDeposit.ForeColor = System.Drawing.Color.Crimson;
            this.labelErrorTextWithdrawDeposit.Location = new System.Drawing.Point(24, 113);
            this.labelErrorTextWithdrawDeposit.Name = "labelErrorTextWithdrawDeposit";
            this.labelErrorTextWithdrawDeposit.Size = new System.Drawing.Size(0, 13);
            this.labelErrorTextWithdrawDeposit.TabIndex = 21;
            // 
            // entryAmountWithdrawDeposit
            // 
            this.entryAmountWithdrawDeposit.Location = new System.Drawing.Point(148, 66);
            this.entryAmountWithdrawDeposit.Name = "entryAmountWithdrawDeposit";
            this.entryAmountWithdrawDeposit.Size = new System.Drawing.Size(106, 20);
            this.entryAmountWithdrawDeposit.TabIndex = 2;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(96, 69);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Amount";
            // 
            // mskEntryAccountNumberDepositWithdraw
            // 
            this.mskEntryAccountNumberDepositWithdraw.Location = new System.Drawing.Point(148, 35);
            this.mskEntryAccountNumberDepositWithdraw.Mask = "00000000";
            this.mskEntryAccountNumberDepositWithdraw.Name = "mskEntryAccountNumberDepositWithdraw";
            this.mskEntryAccountNumberDepositWithdraw.Size = new System.Drawing.Size(106, 20);
            this.mskEntryAccountNumberDepositWithdraw.TabIndex = 1;
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.AutoSize = true;
            this.labelAccountNumber.Location = new System.Drawing.Point(49, 38);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.labelAccountNumber.TabIndex = 3;
            this.labelAccountNumber.Text = "Account Number";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(175, 274);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(80, 22);
            this.buttonDeposit.TabIndex = 4;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(89, 274);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(80, 22);
            this.buttonWithdraw.TabIndex = 3;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // tabAddAccount
            // 
            this.tabAddAccount.Controls.Add(this.labelErrorTextAddAccount);
            this.tabAddAccount.Controls.Add(this.entryPhoneNumber);
            this.tabAddAccount.Controls.Add(this.buttonAddAccount);
            this.tabAddAccount.Controls.Add(this.entryPostcode);
            this.tabAddAccount.Controls.Add(this.labelPostcode);
            this.tabAddAccount.Controls.Add(this.entryCity);
            this.tabAddAccount.Controls.Add(this.labelCity);
            this.tabAddAccount.Controls.Add(this.entryTown);
            this.tabAddAccount.Controls.Add(this.labelTown);
            this.tabAddAccount.Controls.Add(this.entryStreet);
            this.tabAddAccount.Controls.Add(this.labelStreet);
            this.tabAddAccount.Controls.Add(this.entryHouseNumber);
            this.tabAddAccount.Controls.Add(this.labelHouseNumber);
            this.tabAddAccount.Controls.Add(this.labelPhoneNumber);
            this.tabAddAccount.Controls.Add(this.entryEmailAddress);
            this.tabAddAccount.Controls.Add(this.labelEmailAddress);
            this.tabAddAccount.Controls.Add(this.entrySurname);
            this.tabAddAccount.Controls.Add(this.labelSurname);
            this.tabAddAccount.Controls.Add(this.entryForename);
            this.tabAddAccount.Controls.Add(this.labelForename);
            this.tabAddAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAddAccount.Name = "tabAddAccount";
            this.tabAddAccount.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAddAccount.Size = new System.Drawing.Size(843, 408);
            this.tabAddAccount.TabIndex = 6;
            this.tabAddAccount.Text = "Add Account";
            this.tabAddAccount.UseVisualStyleBackColor = true;
            // 
            // labelErrorTextAddAccount
            // 
            this.labelErrorTextAddAccount.AutoSize = true;
            this.labelErrorTextAddAccount.ForeColor = System.Drawing.Color.Crimson;
            this.labelErrorTextAddAccount.Location = new System.Drawing.Point(363, 211);
            this.labelErrorTextAddAccount.Name = "labelErrorTextAddAccount";
            this.labelErrorTextAddAccount.Size = new System.Drawing.Size(0, 13);
            this.labelErrorTextAddAccount.TabIndex = 20;
            // 
            // entryPhoneNumber
            // 
            this.entryPhoneNumber.Location = new System.Drawing.Point(214, 120);
            this.entryPhoneNumber.Name = "entryPhoneNumber";
            this.entryPhoneNumber.Size = new System.Drawing.Size(106, 20);
            this.entryPhoneNumber.TabIndex = 4;
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.Location = new System.Drawing.Point(367, 176);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(84, 22);
            this.buttonAddAccount.TabIndex = 10;
            this.buttonAddAccount.Text = "Add Account";
            this.buttonAddAccount.UseVisualStyleBackColor = true;
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAddAccount_Click);
            // 
            // entryPostcode
            // 
            this.entryPostcode.Location = new System.Drawing.Point(560, 130);
            this.entryPostcode.Name = "entryPostcode";
            this.entryPostcode.Size = new System.Drawing.Size(106, 20);
            this.entryPostcode.TabIndex = 9;
            // 
            // labelPostcode
            // 
            this.labelPostcode.AutoSize = true;
            this.labelPostcode.Location = new System.Drawing.Point(471, 133);
            this.labelPostcode.Name = "labelPostcode";
            this.labelPostcode.Size = new System.Drawing.Size(52, 13);
            this.labelPostcode.TabIndex = 16;
            this.labelPostcode.Text = "Postcode";
            // 
            // entryCity
            // 
            this.entryCity.Location = new System.Drawing.Point(560, 104);
            this.entryCity.Name = "entryCity";
            this.entryCity.Size = new System.Drawing.Size(106, 20);
            this.entryCity.TabIndex = 8;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(471, 108);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 14;
            this.labelCity.Text = "City";
            // 
            // entryTown
            // 
            this.entryTown.Location = new System.Drawing.Point(560, 76);
            this.entryTown.Name = "entryTown";
            this.entryTown.Size = new System.Drawing.Size(106, 20);
            this.entryTown.TabIndex = 7;
            // 
            // labelTown
            // 
            this.labelTown.AutoSize = true;
            this.labelTown.Location = new System.Drawing.Point(471, 79);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(34, 13);
            this.labelTown.TabIndex = 12;
            this.labelTown.Text = "Town";
            // 
            // entryStreet
            // 
            this.entryStreet.Location = new System.Drawing.Point(560, 50);
            this.entryStreet.Name = "entryStreet";
            this.entryStreet.Size = new System.Drawing.Size(106, 20);
            this.entryStreet.TabIndex = 6;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(471, 53);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(35, 13);
            this.labelStreet.TabIndex = 10;
            this.labelStreet.Text = "Street";
            // 
            // entryHouseNumber
            // 
            this.entryHouseNumber.Location = new System.Drawing.Point(560, 24);
            this.entryHouseNumber.Name = "entryHouseNumber";
            this.entryHouseNumber.Size = new System.Drawing.Size(106, 20);
            this.entryHouseNumber.TabIndex = 5;
            // 
            // labelHouseNumber
            // 
            this.labelHouseNumber.AutoSize = true;
            this.labelHouseNumber.Location = new System.Drawing.Point(471, 28);
            this.labelHouseNumber.Name = "labelHouseNumber";
            this.labelHouseNumber.Size = new System.Drawing.Size(78, 13);
            this.labelHouseNumber.TabIndex = 8;
            this.labelHouseNumber.Text = "House Number";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(124, 120);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 6;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // entryEmailAddress
            // 
            this.entryEmailAddress.Location = new System.Drawing.Point(214, 92);
            this.entryEmailAddress.Name = "entryEmailAddress";
            this.entryEmailAddress.Size = new System.Drawing.Size(106, 20);
            this.entryEmailAddress.TabIndex = 3;
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(124, 95);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.labelEmailAddress.TabIndex = 4;
            this.labelEmailAddress.Text = "Email Address";
            // 
            // entrySurname
            // 
            this.entrySurname.Location = new System.Drawing.Point(214, 66);
            this.entrySurname.Name = "entrySurname";
            this.entrySurname.Size = new System.Drawing.Size(106, 20);
            this.entrySurname.TabIndex = 2;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(124, 69);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname";
            // 
            // entryForename
            // 
            this.entryForename.Location = new System.Drawing.Point(214, 40);
            this.entryForename.Name = "entryForename";
            this.entryForename.Size = new System.Drawing.Size(106, 20);
            this.entryForename.TabIndex = 1;
            // 
            // labelForename
            // 
            this.labelForename.AutoSize = true;
            this.labelForename.Location = new System.Drawing.Point(124, 44);
            this.labelForename.Name = "labelForename";
            this.labelForename.Size = new System.Drawing.Size(54, 13);
            this.labelForename.TabIndex = 0;
            this.labelForename.Text = "Forename";
            // 
            // maskedEntryWithdrawAccNum
            // 
            this.maskedEntryWithdrawAccNum.Location = new System.Drawing.Point(103, 19);
            this.maskedEntryWithdrawAccNum.Mask = "00000000";
            this.maskedEntryWithdrawAccNum.Name = "maskedEntryWithdrawAccNum";
            this.maskedEntryWithdrawAccNum.Size = new System.Drawing.Size(50, 20);
            this.maskedEntryWithdrawAccNum.TabIndex = 2;
            this.maskedEntryWithdrawAccNum.ValidatingType = typeof(int);
            // 
            // labelAccountNumberWithdraw
            // 
            this.labelAccountNumberWithdraw.Location = new System.Drawing.Point(10, 16);
            this.labelAccountNumberWithdraw.Name = "labelAccountNumberWithdraw";
            this.labelAccountNumberWithdraw.Size = new System.Drawing.Size(87, 35);
            this.labelAccountNumberWithdraw.TabIndex = 3;
            this.labelAccountNumberWithdraw.Text = "Withdraw Account Number";
            this.labelAccountNumberWithdraw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAccountNumberDeposit
            // 
            this.labelAccountNumberDeposit.Location = new System.Drawing.Point(10, 51);
            this.labelAccountNumberDeposit.Name = "labelAccountNumberDeposit";
            this.labelAccountNumberDeposit.Size = new System.Drawing.Size(87, 35);
            this.labelAccountNumberDeposit.TabIndex = 4;
            this.labelAccountNumberDeposit.Text = "Deposit Account Number";
            this.labelAccountNumberDeposit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maskedEntryDepositAccNo
            // 
            this.maskedEntryDepositAccNo.Location = new System.Drawing.Point(103, 51);
            this.maskedEntryDepositAccNo.Mask = "00000000";
            this.maskedEntryDepositAccNo.Name = "maskedEntryDepositAccNo";
            this.maskedEntryDepositAccNo.Size = new System.Drawing.Size(50, 20);
            this.maskedEntryDepositAccNo.TabIndex = 5;
            this.maskedEntryDepositAccNo.ValidatingType = typeof(int);
            // 
            // maskedEntryDepositAccNum
            // 
            this.maskedEntryDepositAccNum.Location = new System.Drawing.Point(103, 51);
            this.maskedEntryDepositAccNum.Mask = "00000000";
            this.maskedEntryDepositAccNum.Name = "maskedEntryDepositAccNum";
            this.maskedEntryDepositAccNum.Size = new System.Drawing.Size(50, 20);
            this.maskedEntryDepositAccNum.TabIndex = 5;
            this.maskedEntryDepositAccNum.ValidatingType = typeof(int);
            // 
            // maskedEntryWithdrawAccNo
            // 
            this.maskedEntryWithdrawAccNo.Location = new System.Drawing.Point(103, 19);
            this.maskedEntryWithdrawAccNo.Mask = "00000000";
            this.maskedEntryWithdrawAccNo.Name = "maskedEntryWithdrawAccNo";
            this.maskedEntryWithdrawAccNo.Size = new System.Drawing.Size(50, 20);
            this.maskedEntryWithdrawAccNo.TabIndex = 2;
            this.maskedEntryWithdrawAccNo.ValidatingType = typeof(int);
            // 
            // maskedEntryAccountNumberDeposit
            // 
            this.maskedEntryAccountNumberDeposit.Location = new System.Drawing.Point(103, 51);
            this.maskedEntryAccountNumberDeposit.Mask = "00000000";
            this.maskedEntryAccountNumberDeposit.Name = "maskedEntryAccountNumberDeposit";
            this.maskedEntryAccountNumberDeposit.Size = new System.Drawing.Size(50, 20);
            this.maskedEntryAccountNumberDeposit.TabIndex = 5;
            this.maskedEntryAccountNumberDeposit.ValidatingType = typeof(int);
            // 
            // groupBoxAccNum
            // 
            this.groupBoxAccNum.Controls.Add(this.maskedEntryDepositAccNo);
            this.groupBoxAccNum.Controls.Add(this.labelAccountNumberDeposit);
            this.groupBoxAccNum.Controls.Add(this.labelAccountNumberWithdraw);
            this.groupBoxAccNum.Controls.Add(this.maskedEntryWithdrawAccNum);
            this.groupBoxAccNum.Location = new System.Drawing.Point(350, 117);
            this.groupBoxAccNum.Name = "groupBoxAccNum";
            this.groupBoxAccNum.Size = new System.Drawing.Size(169, 94);
            this.groupBoxAccNum.TabIndex = 5;
            this.groupBoxAccNum.TabStop = false;
            this.groupBoxAccNum.Text = "Account Number";
            // 
            // formWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(853, 440);
            this.Controls.Add(this.tabsGeneralTabs);
            this.MaximumSize = new System.Drawing.Size(869, 479);
            this.MinimumSize = new System.Drawing.Size(869, 479);
            this.Name = "formWindow";
            this.Text = "Banking App";
            this.Load += new System.EventHandler(this.formWindow_Load);
            this.tabsGeneralTabs.ResumeLayout(false);
            this.tabViewAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableViewAccounts)).EndInit();
            this.tabViewCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableViewCustomers)).EndInit();
            this.tabMakeTransaction.ResumeLayout(false);
            this.groupTransact.ResumeLayout(false);
            this.groupTransact.PerformLayout();
            this.groupWithdrawDeposit.ResumeLayout(false);
            this.groupWithdrawDeposit.PerformLayout();
            this.tabAddAccount.ResumeLayout(false);
            this.tabAddAccount.PerformLayout();
            this.groupBoxAccNum.ResumeLayout(false);
            this.groupBoxAccNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsGeneralTabs;
        private System.Windows.Forms.TabPage tabViewAccounts;
        private System.Windows.Forms.TabPage tabViewCustomers;
        private System.Windows.Forms.TabPage tabMakeTransaction;
        private System.Windows.Forms.DataGridView tableViewAccounts;
        private System.Windows.Forms.DataGridView tableViewCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn custfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn custsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn town;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcode;
        private System.Windows.Forms.TabPage tabAddAccount;
        private System.Windows.Forms.MaskedTextBox maskedEntryWithdrawAccNum;
        private System.Windows.Forms.Label labelAccountNumberWithdraw;
        private System.Windows.Forms.Label labelAccountNumberDeposit;
        private System.Windows.Forms.MaskedTextBox maskedEntryDepositAccNo;
        private System.Windows.Forms.MaskedTextBox maskedEntryDepositAccNum;
        private System.Windows.Forms.MaskedTextBox maskedEntryWithdrawAccNo;
        private System.Windows.Forms.MaskedTextBox maskedEntryAccountNumberDeposit;
        private System.Windows.Forms.GroupBox groupBoxAccNum;
        private System.Windows.Forms.TextBox entryEmailAddress;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.TextBox entrySurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox entryForename;
        private System.Windows.Forms.Label labelForename;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox entryHouseNumber;
        private System.Windows.Forms.Label labelHouseNumber;
        private System.Windows.Forms.TextBox entryTown;
        private System.Windows.Forms.Label labelTown;
        private System.Windows.Forms.TextBox entryStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox entryPostcode;
        private System.Windows.Forms.Label labelPostcode;
        private System.Windows.Forms.TextBox entryCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.TextBox entryPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.Label labelErrorTextAddAccount;
        private System.Windows.Forms.GroupBox groupTransact;
        private System.Windows.Forms.GroupBox groupWithdrawDeposit;
        private System.Windows.Forms.Label labelAccountNumber;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.MaskedTextBox mskEntryAccountNumberDepositWithdraw;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox entryAmountWithdrawDeposit;
        private System.Windows.Forms.Label labelErrorTextWithdrawDeposit;
        private System.Windows.Forms.MaskedTextBox mskEntryAccountNumberFrom;
        private System.Windows.Forms.MaskedTextBox mskEntryAccountNumberTo;
        private System.Windows.Forms.Button buttonTransact;
        private System.Windows.Forms.TextBox entryAmountTransact;
        private System.Windows.Forms.Label labelAccountNumberTo;
        private System.Windows.Forms.Label labelAmountTransact;
        private System.Windows.Forms.Label labelAccountNumberFrom;
        private System.Windows.Forms.Label labelErrorTextTransact;
    }
}

