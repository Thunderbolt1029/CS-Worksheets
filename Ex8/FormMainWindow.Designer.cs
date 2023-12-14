
namespace Ex8
{
    partial class FormMainWindow
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabViewAccounts = new System.Windows.Forms.TabPage();
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabViewCustomers = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageTransact = new System.Windows.Forms.TabPage();
            this.groupTransact = new System.Windows.Forms.GroupBox();
            this.buttonTransact = new System.Windows.Forms.Button();
            this.labelErrorTextTransact = new System.Windows.Forms.Label();
            this.labelAccountNumberFrom = new System.Windows.Forms.Label();
            this.mskEntryAccountNumberFrom = new System.Windows.Forms.MaskedTextBox();
            this.labelAmountTransact = new System.Windows.Forms.Label();
            this.mskEntryAccountNumberTo = new System.Windows.Forms.MaskedTextBox();
            this.labelAccountNumberTo = new System.Windows.Forms.Label();
            this.entryAmountTransact = new System.Windows.Forms.TextBox();
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
            this.tabControlMain.SuspendLayout();
            this.tabViewAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.tabViewCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabPageTransact.SuspendLayout();
            this.groupTransact.SuspendLayout();
            this.groupWithdrawDeposit.SuspendLayout();
            this.tabAddAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabViewAccounts);
            this.tabControlMain.Controls.Add(this.tabViewCustomers);
            this.tabControlMain.Controls.Add(this.tabPageTransact);
            this.tabControlMain.Controls.Add(this.tabAddAccount);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(853, 438);
            this.tabControlMain.TabIndex = 7;
            // 
            // tabViewAccounts
            // 
            this.tabViewAccounts.Controls.Add(this.dataGridViewAccounts);
            this.tabViewAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabViewAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.tabViewAccounts.Name = "tabViewAccounts";
            this.tabViewAccounts.Padding = new System.Windows.Forms.Padding(2);
            this.tabViewAccounts.Size = new System.Drawing.Size(845, 412);
            this.tabViewAccounts.TabIndex = 0;
            this.tabViewAccounts.Text = "View Accounts";
            this.tabViewAccounts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.AllowUserToAddRows = false;
            this.dataGridViewAccounts.AllowUserToDeleteRows = false;
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNumber,
            this.AccountBalance,
            this.CustfName,
            this.CustsName});
            this.dataGridViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.ReadOnly = true;
            this.dataGridViewAccounts.RowHeadersWidth = 51;
            this.dataGridViewAccounts.RowTemplate.Height = 24;
            this.dataGridViewAccounts.Size = new System.Drawing.Size(841, 408);
            this.dataGridViewAccounts.TabIndex = 0;
            // 
            // AccountNumber
            // 
            this.AccountNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AccountNumber.DataPropertyName = "CustID";
            this.AccountNumber.HeaderText = "Account Number";
            this.AccountNumber.MinimumWidth = 6;
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.ReadOnly = true;
            this.AccountNumber.Width = 101;
            // 
            // AccountBalance
            // 
            this.AccountBalance.DataPropertyName = "AccountBalance";
            this.AccountBalance.HeaderText = "Account Balance";
            this.AccountBalance.MinimumWidth = 6;
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.ReadOnly = true;
            this.AccountBalance.Width = 125;
            // 
            // CustfName
            // 
            this.CustfName.DataPropertyName = "fName";
            this.CustfName.HeaderText = "Forename";
            this.CustfName.MinimumWidth = 6;
            this.CustfName.Name = "CustfName";
            this.CustfName.ReadOnly = true;
            this.CustfName.Width = 125;
            // 
            // CustsName
            // 
            this.CustsName.DataPropertyName = "sName";
            this.CustsName.HeaderText = "Surname";
            this.CustsName.MinimumWidth = 6;
            this.CustsName.Name = "CustsName";
            this.CustsName.ReadOnly = true;
            this.CustsName.Width = 125;
            // 
            // tabViewCustomers
            // 
            this.tabViewCustomers.Controls.Add(this.dataGridViewCustomers);
            this.tabViewCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabViewCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.tabViewCustomers.Name = "tabViewCustomers";
            this.tabViewCustomers.Padding = new System.Windows.Forms.Padding(2);
            this.tabViewCustomers.Size = new System.Drawing.Size(845, 412);
            this.tabViewCustomers.TabIndex = 1;
            this.tabViewCustomers.Text = "View Customers";
            this.tabViewCustomers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustID,
            this.fName,
            this.sName,
            this.PhoneNumber,
            this.EmailAddress,
            this.HouseNumber,
            this.StreetName,
            this.Town,
            this.City,
            this.Postcode});
            this.dataGridViewCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(841, 408);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // CustID
            // 
            this.CustID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CustID.DataPropertyName = "CustID";
            this.CustID.HeaderText = "Account Number";
            this.CustID.MinimumWidth = 6;
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.Width = 101;
            // 
            // fName
            // 
            this.fName.DataPropertyName = "fName";
            this.fName.HeaderText = "Forename";
            this.fName.MinimumWidth = 6;
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            this.fName.Width = 125;
            // 
            // sName
            // 
            this.sName.DataPropertyName = "sName";
            this.sName.HeaderText = "Surname";
            this.sName.MinimumWidth = 6;
            this.sName.Name = "sName";
            this.sName.ReadOnly = true;
            this.sName.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 125;
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "Email Address";
            this.EmailAddress.MinimumWidth = 6;
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Width = 125;
            // 
            // HouseNumber
            // 
            this.HouseNumber.DataPropertyName = "HouseNumber";
            this.HouseNumber.HeaderText = "House Number";
            this.HouseNumber.MinimumWidth = 6;
            this.HouseNumber.Name = "HouseNumber";
            this.HouseNumber.ReadOnly = true;
            this.HouseNumber.Width = 125;
            // 
            // StreetName
            // 
            this.StreetName.DataPropertyName = "StreetName";
            this.StreetName.HeaderText = "Street Name";
            this.StreetName.MinimumWidth = 6;
            this.StreetName.Name = "StreetName";
            this.StreetName.ReadOnly = true;
            this.StreetName.Width = 125;
            // 
            // Town
            // 
            this.Town.DataPropertyName = "Town";
            this.Town.HeaderText = "Town";
            this.Town.MinimumWidth = 6;
            this.Town.Name = "Town";
            this.Town.ReadOnly = true;
            this.Town.Width = 125;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 125;
            // 
            // Postcode
            // 
            this.Postcode.DataPropertyName = "Postcode";
            this.Postcode.HeaderText = "Postcode";
            this.Postcode.MinimumWidth = 6;
            this.Postcode.Name = "Postcode";
            this.Postcode.ReadOnly = true;
            this.Postcode.Width = 125;
            // 
            // tabPageTransact
            // 
            this.tabPageTransact.Controls.Add(this.groupTransact);
            this.tabPageTransact.Controls.Add(this.groupWithdrawDeposit);
            this.tabPageTransact.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransact.Name = "tabPageTransact";
            this.tabPageTransact.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransact.Size = new System.Drawing.Size(845, 412);
            this.tabPageTransact.TabIndex = 2;
            this.tabPageTransact.Text = "Make Transaction";
            this.tabPageTransact.UseVisualStyleBackColor = true;
            // 
            // groupTransact
            // 
            this.groupTransact.Controls.Add(this.buttonTransact);
            this.groupTransact.Controls.Add(this.labelErrorTextTransact);
            this.groupTransact.Controls.Add(this.labelAccountNumberFrom);
            this.groupTransact.Controls.Add(this.mskEntryAccountNumberFrom);
            this.groupTransact.Controls.Add(this.labelAmountTransact);
            this.groupTransact.Controls.Add(this.mskEntryAccountNumberTo);
            this.groupTransact.Controls.Add(this.labelAccountNumberTo);
            this.groupTransact.Controls.Add(this.entryAmountTransact);
            this.groupTransact.Location = new System.Drawing.Point(408, 6);
            this.groupTransact.Name = "groupTransact";
            this.groupTransact.Size = new System.Drawing.Size(431, 400);
            this.groupTransact.TabIndex = 1;
            this.groupTransact.TabStop = false;
            this.groupTransact.Text = "Transact between accounts";
            // 
            // buttonTransact
            // 
            this.buttonTransact.Location = new System.Drawing.Point(188, 267);
            this.buttonTransact.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTransact.Name = "buttonTransact";
            this.buttonTransact.Size = new System.Drawing.Size(60, 22);
            this.buttonTransact.TabIndex = 37;
            this.buttonTransact.Text = "Transact";
            this.buttonTransact.UseVisualStyleBackColor = true;
            this.buttonTransact.Click += new System.EventHandler(this.buttonTransact_Click);
            // 
            // labelErrorTextTransact
            // 
            this.labelErrorTextTransact.AutoSize = true;
            this.labelErrorTextTransact.ForeColor = System.Drawing.Color.Crimson;
            this.labelErrorTextTransact.Location = new System.Drawing.Point(18, 125);
            this.labelErrorTextTransact.Name = "labelErrorTextTransact";
            this.labelErrorTextTransact.Size = new System.Drawing.Size(0, 13);
            this.labelErrorTextTransact.TabIndex = 36;
            // 
            // labelAccountNumberFrom
            // 
            this.labelAccountNumberFrom.AutoSize = true;
            this.labelAccountNumberFrom.Location = new System.Drawing.Point(18, 31);
            this.labelAccountNumberFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccountNumberFrom.Name = "labelAccountNumberFrom";
            this.labelAccountNumberFrom.Size = new System.Drawing.Size(90, 26);
            this.labelAccountNumberFrom.TabIndex = 29;
            this.labelAccountNumberFrom.Text = "Account Number \r\nto Transact from";
            this.labelAccountNumberFrom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mskEntryAccountNumberFrom
            // 
            this.mskEntryAccountNumberFrom.Location = new System.Drawing.Point(117, 35);
            this.mskEntryAccountNumberFrom.Mask = "00000000";
            this.mskEntryAccountNumberFrom.Name = "mskEntryAccountNumberFrom";
            this.mskEntryAccountNumberFrom.Size = new System.Drawing.Size(73, 20);
            this.mskEntryAccountNumberFrom.TabIndex = 32;
            // 
            // labelAmountTransact
            // 
            this.labelAmountTransact.AutoSize = true;
            this.labelAmountTransact.Location = new System.Drawing.Point(152, 84);
            this.labelAmountTransact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmountTransact.Name = "labelAmountTransact";
            this.labelAmountTransact.Size = new System.Drawing.Size(43, 13);
            this.labelAmountTransact.TabIndex = 30;
            this.labelAmountTransact.Text = "Amount";
            // 
            // mskEntryAccountNumberTo
            // 
            this.mskEntryAccountNumberTo.Location = new System.Drawing.Point(336, 35);
            this.mskEntryAccountNumberTo.Mask = "00000000";
            this.mskEntryAccountNumberTo.Name = "mskEntryAccountNumberTo";
            this.mskEntryAccountNumberTo.Size = new System.Drawing.Size(73, 20);
            this.mskEntryAccountNumberTo.TabIndex = 33;
            // 
            // labelAccountNumberTo
            // 
            this.labelAccountNumberTo.AutoSize = true;
            this.labelAccountNumberTo.Location = new System.Drawing.Point(237, 31);
            this.labelAccountNumberTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccountNumberTo.Name = "labelAccountNumberTo";
            this.labelAccountNumberTo.Size = new System.Drawing.Size(90, 26);
            this.labelAccountNumberTo.TabIndex = 31;
            this.labelAccountNumberTo.Text = "Account Number \r\nto Transact to";
            // 
            // entryAmountTransact
            // 
            this.entryAmountTransact.Location = new System.Drawing.Point(201, 82);
            this.entryAmountTransact.Margin = new System.Windows.Forms.Padding(2);
            this.entryAmountTransact.Name = "entryAmountTransact";
            this.entryAmountTransact.Size = new System.Drawing.Size(81, 20);
            this.entryAmountTransact.TabIndex = 34;
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
            this.groupWithdrawDeposit.Location = new System.Drawing.Point(8, 6);
            this.groupWithdrawDeposit.Name = "groupWithdrawDeposit";
            this.groupWithdrawDeposit.Size = new System.Drawing.Size(394, 400);
            this.groupWithdrawDeposit.TabIndex = 0;
            this.groupWithdrawDeposit.TabStop = false;
            this.groupWithdrawDeposit.Text = "Withdraw / Deposit";
            // 
            // labelErrorTextWithdrawDeposit
            // 
            this.labelErrorTextWithdrawDeposit.AutoSize = true;
            this.labelErrorTextWithdrawDeposit.ForeColor = System.Drawing.Color.Crimson;
            this.labelErrorTextWithdrawDeposit.Location = new System.Drawing.Point(36, 107);
            this.labelErrorTextWithdrawDeposit.Name = "labelErrorTextWithdrawDeposit";
            this.labelErrorTextWithdrawDeposit.Size = new System.Drawing.Size(0, 13);
            this.labelErrorTextWithdrawDeposit.TabIndex = 28;
            // 
            // entryAmountWithdrawDeposit
            // 
            this.entryAmountWithdrawDeposit.Location = new System.Drawing.Point(160, 60);
            this.entryAmountWithdrawDeposit.Name = "entryAmountWithdrawDeposit";
            this.entryAmountWithdrawDeposit.Size = new System.Drawing.Size(106, 20);
            this.entryAmountWithdrawDeposit.TabIndex = 23;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(108, 63);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 27;
            this.labelAmount.Text = "Amount";
            // 
            // mskEntryAccountNumberDepositWithdraw
            // 
            this.mskEntryAccountNumberDepositWithdraw.Location = new System.Drawing.Point(160, 29);
            this.mskEntryAccountNumberDepositWithdraw.Mask = "00000000";
            this.mskEntryAccountNumberDepositWithdraw.Name = "mskEntryAccountNumberDepositWithdraw";
            this.mskEntryAccountNumberDepositWithdraw.Size = new System.Drawing.Size(106, 20);
            this.mskEntryAccountNumberDepositWithdraw.TabIndex = 22;
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.AutoSize = true;
            this.labelAccountNumber.Location = new System.Drawing.Point(61, 32);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.labelAccountNumber.TabIndex = 24;
            this.labelAccountNumber.Text = "Account Number";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(187, 268);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(80, 22);
            this.buttonDeposit.TabIndex = 26;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(101, 268);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(80, 22);
            this.buttonWithdraw.TabIndex = 25;
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
            this.tabAddAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddAccount.Size = new System.Drawing.Size(845, 412);
            this.tabAddAccount.TabIndex = 3;
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
            this.labelErrorTextAddAccount.TabIndex = 40;
            // 
            // entryPhoneNumber
            // 
            this.entryPhoneNumber.Location = new System.Drawing.Point(214, 120);
            this.entryPhoneNumber.Name = "entryPhoneNumber";
            this.entryPhoneNumber.Size = new System.Drawing.Size(106, 20);
            this.entryPhoneNumber.TabIndex = 26;
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.Location = new System.Drawing.Point(367, 176);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(84, 22);
            this.buttonAddAccount.TabIndex = 36;
            this.buttonAddAccount.Text = "Add Account";
            this.buttonAddAccount.UseVisualStyleBackColor = true;
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAddAccount_Click);
            // 
            // entryPostcode
            // 
            this.entryPostcode.Location = new System.Drawing.Point(560, 130);
            this.entryPostcode.Name = "entryPostcode";
            this.entryPostcode.Size = new System.Drawing.Size(106, 20);
            this.entryPostcode.TabIndex = 34;
            // 
            // labelPostcode
            // 
            this.labelPostcode.AutoSize = true;
            this.labelPostcode.Location = new System.Drawing.Point(471, 133);
            this.labelPostcode.Name = "labelPostcode";
            this.labelPostcode.Size = new System.Drawing.Size(52, 13);
            this.labelPostcode.TabIndex = 39;
            this.labelPostcode.Text = "Postcode";
            // 
            // entryCity
            // 
            this.entryCity.Location = new System.Drawing.Point(560, 104);
            this.entryCity.Name = "entryCity";
            this.entryCity.Size = new System.Drawing.Size(106, 20);
            this.entryCity.TabIndex = 33;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(471, 108);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 38;
            this.labelCity.Text = "City";
            // 
            // entryTown
            // 
            this.entryTown.Location = new System.Drawing.Point(560, 76);
            this.entryTown.Name = "entryTown";
            this.entryTown.Size = new System.Drawing.Size(106, 20);
            this.entryTown.TabIndex = 31;
            // 
            // labelTown
            // 
            this.labelTown.AutoSize = true;
            this.labelTown.Location = new System.Drawing.Point(471, 79);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(34, 13);
            this.labelTown.TabIndex = 37;
            this.labelTown.Text = "Town";
            // 
            // entryStreet
            // 
            this.entryStreet.Location = new System.Drawing.Point(560, 50);
            this.entryStreet.Name = "entryStreet";
            this.entryStreet.Size = new System.Drawing.Size(106, 20);
            this.entryStreet.TabIndex = 30;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(471, 53);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(35, 13);
            this.labelStreet.TabIndex = 35;
            this.labelStreet.Text = "Street";
            // 
            // entryHouseNumber
            // 
            this.entryHouseNumber.Location = new System.Drawing.Point(560, 24);
            this.entryHouseNumber.Name = "entryHouseNumber";
            this.entryHouseNumber.Size = new System.Drawing.Size(106, 20);
            this.entryHouseNumber.TabIndex = 28;
            // 
            // labelHouseNumber
            // 
            this.labelHouseNumber.AutoSize = true;
            this.labelHouseNumber.Location = new System.Drawing.Point(471, 28);
            this.labelHouseNumber.Name = "labelHouseNumber";
            this.labelHouseNumber.Size = new System.Drawing.Size(78, 13);
            this.labelHouseNumber.TabIndex = 32;
            this.labelHouseNumber.Text = "House Number";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(124, 120);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 29;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // entryEmailAddress
            // 
            this.entryEmailAddress.Location = new System.Drawing.Point(214, 92);
            this.entryEmailAddress.Name = "entryEmailAddress";
            this.entryEmailAddress.Size = new System.Drawing.Size(106, 20);
            this.entryEmailAddress.TabIndex = 25;
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(124, 95);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.labelEmailAddress.TabIndex = 27;
            this.labelEmailAddress.Text = "Email Address";
            // 
            // entrySurname
            // 
            this.entrySurname.Location = new System.Drawing.Point(214, 66);
            this.entrySurname.Name = "entrySurname";
            this.entrySurname.Size = new System.Drawing.Size(106, 20);
            this.entrySurname.TabIndex = 24;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(124, 69);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 23;
            this.labelSurname.Text = "Surname";
            // 
            // entryForename
            // 
            this.entryForename.Location = new System.Drawing.Point(214, 40);
            this.entryForename.Name = "entryForename";
            this.entryForename.Size = new System.Drawing.Size(106, 20);
            this.entryForename.TabIndex = 22;
            // 
            // labelForename
            // 
            this.labelForename.AutoSize = true;
            this.labelForename.Location = new System.Drawing.Point(124, 44);
            this.labelForename.Name = "labelForename";
            this.labelForename.Size = new System.Drawing.Size(54, 13);
            this.labelForename.TabIndex = 21;
            this.labelForename.Text = "Forename";
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(853, 438);
            this.Controls.Add(this.tabControlMain);
            this.MaximumSize = new System.Drawing.Size(869, 477);
            this.MinimumSize = new System.Drawing.Size(869, 477);
            this.Name = "FormMainWindow";
            this.Text = "Banking App but SQL this time";
            this.Load += new System.EventHandler(this.FormMainWindow_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabViewAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.tabViewCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabPageTransact.ResumeLayout(false);
            this.groupTransact.ResumeLayout(false);
            this.groupTransact.PerformLayout();
            this.groupWithdrawDeposit.ResumeLayout(false);
            this.groupWithdrawDeposit.PerformLayout();
            this.tabAddAccount.ResumeLayout(false);
            this.tabAddAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabViewAccounts;
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.TabPage tabViewCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Town;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustsName;
        private System.Windows.Forms.TabPage tabPageTransact;
        private System.Windows.Forms.GroupBox groupTransact;
        private System.Windows.Forms.GroupBox groupWithdrawDeposit;
        private System.Windows.Forms.Label labelErrorTextWithdrawDeposit;
        private System.Windows.Forms.TextBox entryAmountWithdrawDeposit;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.MaskedTextBox mskEntryAccountNumberDepositWithdraw;
        private System.Windows.Forms.Label labelAccountNumber;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Label labelErrorTextTransact;
        private System.Windows.Forms.Label labelAccountNumberFrom;
        private System.Windows.Forms.MaskedTextBox mskEntryAccountNumberFrom;
        private System.Windows.Forms.Label labelAmountTransact;
        private System.Windows.Forms.MaskedTextBox mskEntryAccountNumberTo;
        private System.Windows.Forms.Label labelAccountNumberTo;
        private System.Windows.Forms.TextBox entryAmountTransact;
        private System.Windows.Forms.Button buttonTransact;
        private System.Windows.Forms.TabPage tabAddAccount;
        private System.Windows.Forms.Label labelErrorTextAddAccount;
        private System.Windows.Forms.TextBox entryPhoneNumber;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.TextBox entryPostcode;
        private System.Windows.Forms.Label labelPostcode;
        private System.Windows.Forms.TextBox entryCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox entryTown;
        private System.Windows.Forms.Label labelTown;
        private System.Windows.Forms.TextBox entryStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox entryHouseNumber;
        private System.Windows.Forms.Label labelHouseNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox entryEmailAddress;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.TextBox entrySurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox entryForename;
        private System.Windows.Forms.Label labelForename;
    }
}

