namespace SalesSystem
{
    partial class SalesSystem
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
            this.grpPaymentType = new System.Windows.Forms.GroupBox();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.radBankTransfer = new System.Windows.Forms.RadioButton();
            this.grpProductSelection = new System.Windows.Forms.GroupBox();
            this.ProductName = new System.Windows.Forms.Label();
            this.Shoes = new System.Windows.Forms.CheckBox();
            this.Jackets = new System.Windows.Forms.CheckBox();
            this.Gloves = new System.Windows.Forms.CheckBox();
            this.Beanies = new System.Windows.Forms.CheckBox();
            this.Sweaters = new System.Windows.Forms.CheckBox();
            this.Scarfs = new System.Windows.Forms.CheckBox();
            this.UnitPrice = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.txtShoesP = new System.Windows.Forms.TextBox();
            this.txtScarfsQ = new System.Windows.Forms.TextBox();
            this.txtJacketsP = new System.Windows.Forms.TextBox();
            this.txtSweatersQ = new System.Windows.Forms.TextBox();
            this.txtGlovesP = new System.Windows.Forms.TextBox();
            this.txtBeaniesQ = new System.Windows.Forms.TextBox();
            this.txtBeaniesP = new System.Windows.Forms.TextBox();
            this.txtGlovesQ = new System.Windows.Forms.TextBox();
            this.txtSweatersP = new System.Windows.Forms.TextBox();
            this.txtJacketsQ = new System.Windows.Forms.TextBox();
            this.txtScarfsP = new System.Windows.Forms.TextBox();
            this.txtShoesQ = new System.Windows.Forms.TextBox();
            this.grpCreditCardInfo = new System.Windows.Forms.GroupBox();
            this.NameCard = new System.Windows.Forms.Label();
            this.CardType = new System.Windows.Forms.Label();
            this.CardNumber = new System.Windows.Forms.Label();
            this.Expiry = new System.Windows.Forms.Label();
            this.IssuingBank = new System.Windows.Forms.Label();
            this.txtNameCard = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.comCardType = new System.Windows.Forms.ComboBox();
            this.comIssuingBank = new System.Windows.Forms.ComboBox();
            this.comExpiryMonth = new System.Windows.Forms.ComboBox();
            this.comExpiryYear = new System.Windows.Forms.ComboBox();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.StreetAddress = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Suburb = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.County = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.btnShowSummary = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.grpPaymentType.SuspendLayout();
            this.grpProductSelection.SuspendLayout();
            this.grpCreditCardInfo.SuspendLayout();
            this.grpCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPaymentType
            // 
            this.grpPaymentType.Controls.Add(this.radCash);
            this.grpPaymentType.Controls.Add(this.radCreditCard);
            this.grpPaymentType.Controls.Add(this.radBankTransfer);
            this.grpPaymentType.Location = new System.Drawing.Point(332, 274);
            this.grpPaymentType.Name = "grpPaymentType";
            this.grpPaymentType.Size = new System.Drawing.Size(274, 67);
            this.grpPaymentType.TabIndex = 80;
            this.grpPaymentType.TabStop = false;
            this.grpPaymentType.Text = "Payment Type";
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(7, 33);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(49, 17);
            this.radCash.TabIndex = 56;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            this.radCash.CheckedChanged += new System.EventHandler(this.radCash_CheckedChanged);
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Location = new System.Drawing.Point(71, 33);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(77, 17);
            this.radCreditCard.TabIndex = 57;
            this.radCreditCard.TabStop = true;
            this.radCreditCard.Text = "Credit Card";
            this.radCreditCard.UseVisualStyleBackColor = true;
            this.radCreditCard.CheckedChanged += new System.EventHandler(this.radCreditCard_CheckedChanged);
            // 
            // radBankTransfer
            // 
            this.radBankTransfer.AutoSize = true;
            this.radBankTransfer.Location = new System.Drawing.Point(163, 33);
            this.radBankTransfer.Name = "radBankTransfer";
            this.radBankTransfer.Size = new System.Drawing.Size(92, 17);
            this.radBankTransfer.TabIndex = 58;
            this.radBankTransfer.TabStop = true;
            this.radBankTransfer.Text = "Bank Transfer";
            this.radBankTransfer.UseVisualStyleBackColor = true;
            this.radBankTransfer.CheckedChanged += new System.EventHandler(this.radBankTransfer_CheckedChanged);
            // 
            // grpProductSelection
            // 
            this.grpProductSelection.Controls.Add(this.ProductName);
            this.grpProductSelection.Controls.Add(this.Shoes);
            this.grpProductSelection.Controls.Add(this.Jackets);
            this.grpProductSelection.Controls.Add(this.Gloves);
            this.grpProductSelection.Controls.Add(this.Beanies);
            this.grpProductSelection.Controls.Add(this.Sweaters);
            this.grpProductSelection.Controls.Add(this.Scarfs);
            this.grpProductSelection.Controls.Add(this.UnitPrice);
            this.grpProductSelection.Controls.Add(this.Quantity);
            this.grpProductSelection.Controls.Add(this.txtShoesP);
            this.grpProductSelection.Controls.Add(this.txtScarfsQ);
            this.grpProductSelection.Controls.Add(this.txtJacketsP);
            this.grpProductSelection.Controls.Add(this.txtSweatersQ);
            this.grpProductSelection.Controls.Add(this.txtGlovesP);
            this.grpProductSelection.Controls.Add(this.txtBeaniesQ);
            this.grpProductSelection.Controls.Add(this.txtBeaniesP);
            this.grpProductSelection.Controls.Add(this.txtGlovesQ);
            this.grpProductSelection.Controls.Add(this.txtSweatersP);
            this.grpProductSelection.Controls.Add(this.txtJacketsQ);
            this.grpProductSelection.Controls.Add(this.txtScarfsP);
            this.grpProductSelection.Controls.Add(this.txtShoesQ);
            this.grpProductSelection.Location = new System.Drawing.Point(332, 12);
            this.grpProductSelection.Name = "grpProductSelection";
            this.grpProductSelection.Size = new System.Drawing.Size(274, 214);
            this.grpProductSelection.TabIndex = 79;
            this.grpProductSelection.TabStop = false;
            this.grpProductSelection.Text = "Product Selection";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(15, 24);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(75, 13);
            this.ProductName.TabIndex = 26;
            this.ProductName.Text = "Product Name";
            // 
            // Shoes
            // 
            this.Shoes.AutoSize = true;
            this.Shoes.Location = new System.Drawing.Point(18, 52);
            this.Shoes.Name = "Shoes";
            this.Shoes.Size = new System.Drawing.Size(56, 17);
            this.Shoes.TabIndex = 33;
            this.Shoes.Text = "Shoes";
            this.Shoes.UseVisualStyleBackColor = true;
            this.Shoes.CheckedChanged += new System.EventHandler(this.Shoes_CheckedChanged);
            // 
            // Jackets
            // 
            this.Jackets.AutoSize = true;
            this.Jackets.Location = new System.Drawing.Point(18, 75);
            this.Jackets.Name = "Jackets";
            this.Jackets.Size = new System.Drawing.Size(63, 17);
            this.Jackets.TabIndex = 34;
            this.Jackets.Text = "Jackets";
            this.Jackets.UseVisualStyleBackColor = true;
            this.Jackets.CheckedChanged += new System.EventHandler(this.Jackets_CheckedChanged);
            // 
            // Gloves
            // 
            this.Gloves.AutoSize = true;
            this.Gloves.Location = new System.Drawing.Point(18, 103);
            this.Gloves.Name = "Gloves";
            this.Gloves.Size = new System.Drawing.Size(59, 17);
            this.Gloves.TabIndex = 35;
            this.Gloves.Text = "Gloves";
            this.Gloves.UseVisualStyleBackColor = true;
            this.Gloves.CheckedChanged += new System.EventHandler(this.Gloves_CheckedChanged);
            // 
            // Beanies
            // 
            this.Beanies.AutoSize = true;
            this.Beanies.Location = new System.Drawing.Point(18, 129);
            this.Beanies.Name = "Beanies";
            this.Beanies.Size = new System.Drawing.Size(64, 17);
            this.Beanies.TabIndex = 36;
            this.Beanies.Text = "Beanies";
            this.Beanies.UseVisualStyleBackColor = true;
            this.Beanies.CheckedChanged += new System.EventHandler(this.Beanies_CheckedChanged);
            // 
            // Sweaters
            // 
            this.Sweaters.AutoSize = true;
            this.Sweaters.Location = new System.Drawing.Point(18, 154);
            this.Sweaters.Name = "Sweaters";
            this.Sweaters.Size = new System.Drawing.Size(70, 17);
            this.Sweaters.TabIndex = 37;
            this.Sweaters.Text = "Sweaters";
            this.Sweaters.UseVisualStyleBackColor = true;
            this.Sweaters.CheckedChanged += new System.EventHandler(this.Sweaters_CheckedChanged);
            // 
            // Scarfs
            // 
            this.Scarfs.AutoSize = true;
            this.Scarfs.Location = new System.Drawing.Point(18, 180);
            this.Scarfs.Name = "Scarfs";
            this.Scarfs.Size = new System.Drawing.Size(56, 17);
            this.Scarfs.TabIndex = 38;
            this.Scarfs.Text = "Scarfs";
            this.Scarfs.UseVisualStyleBackColor = true;
            this.Scarfs.CheckedChanged += new System.EventHandler(this.Scarfs_CheckedChanged);
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSize = true;
            this.UnitPrice.Location = new System.Drawing.Point(149, 24);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(56, 13);
            this.UnitPrice.TabIndex = 39;
            this.UnitPrice.Text = "Unit Price ";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(216, 24);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 40;
            this.Quantity.Text = "Quantity";
            // 
            // txtShoesP
            // 
            this.txtShoesP.BackColor = System.Drawing.SystemColors.Menu;
            this.txtShoesP.Location = new System.Drawing.Point(152, 49);
            this.txtShoesP.Name = "txtShoesP";
            this.txtShoesP.Size = new System.Drawing.Size(46, 20);
            this.txtShoesP.TabIndex = 41;
            this.txtShoesP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtShoesP.TextChanged += new System.EventHandler(this.txtShoesP_TextChanged);
            // 
            // txtScarfsQ
            // 
            this.txtScarfsQ.Location = new System.Drawing.Point(219, 178);
            this.txtScarfsQ.Name = "txtScarfsQ";
            this.txtScarfsQ.Size = new System.Drawing.Size(46, 20);
            this.txtScarfsQ.TabIndex = 52;
            this.txtScarfsQ.TextChanged += new System.EventHandler(this.txtScarfsQ_TextChanged);
            this.txtScarfsQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScarfsQ_KeyPress);
            // 
            // txtJacketsP
            // 
            this.txtJacketsP.BackColor = System.Drawing.SystemColors.Menu;
            this.txtJacketsP.Location = new System.Drawing.Point(152, 75);
            this.txtJacketsP.Name = "txtJacketsP";
            this.txtJacketsP.Size = new System.Drawing.Size(46, 20);
            this.txtJacketsP.TabIndex = 42;
            this.txtJacketsP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSweatersQ
            // 
            this.txtSweatersQ.Location = new System.Drawing.Point(219, 152);
            this.txtSweatersQ.Name = "txtSweatersQ";
            this.txtSweatersQ.Size = new System.Drawing.Size(46, 20);
            this.txtSweatersQ.TabIndex = 51;
            this.txtSweatersQ.TextChanged += new System.EventHandler(this.txtSweatersQ_TextChanged);
            this.txtSweatersQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSweatersQ_KeyPress);
            // 
            // txtGlovesP
            // 
            this.txtGlovesP.BackColor = System.Drawing.SystemColors.Menu;
            this.txtGlovesP.Location = new System.Drawing.Point(152, 101);
            this.txtGlovesP.Name = "txtGlovesP";
            this.txtGlovesP.Size = new System.Drawing.Size(46, 20);
            this.txtGlovesP.TabIndex = 43;
            this.txtGlovesP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBeaniesQ
            // 
            this.txtBeaniesQ.Location = new System.Drawing.Point(219, 127);
            this.txtBeaniesQ.Name = "txtBeaniesQ";
            this.txtBeaniesQ.Size = new System.Drawing.Size(46, 20);
            this.txtBeaniesQ.TabIndex = 50;
            this.txtBeaniesQ.TextChanged += new System.EventHandler(this.txtBeaniesQ_TextChanged);
            this.txtBeaniesQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBeaniesQ_KeyPress);
            // 
            // txtBeaniesP
            // 
            this.txtBeaniesP.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBeaniesP.Location = new System.Drawing.Point(152, 127);
            this.txtBeaniesP.Name = "txtBeaniesP";
            this.txtBeaniesP.Size = new System.Drawing.Size(46, 20);
            this.txtBeaniesP.TabIndex = 44;
            this.txtBeaniesP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGlovesQ
            // 
            this.txtGlovesQ.Location = new System.Drawing.Point(219, 101);
            this.txtGlovesQ.Name = "txtGlovesQ";
            this.txtGlovesQ.Size = new System.Drawing.Size(46, 20);
            this.txtGlovesQ.TabIndex = 49;
            this.txtGlovesQ.TextChanged += new System.EventHandler(this.txtGlovesQ_TextChanged);
            this.txtGlovesQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGlovesQ_KeyPress);
            // 
            // txtSweatersP
            // 
            this.txtSweatersP.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSweatersP.Location = new System.Drawing.Point(152, 152);
            this.txtSweatersP.Name = "txtSweatersP";
            this.txtSweatersP.Size = new System.Drawing.Size(46, 20);
            this.txtSweatersP.TabIndex = 45;
            this.txtSweatersP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJacketsQ
            // 
            this.txtJacketsQ.Location = new System.Drawing.Point(219, 75);
            this.txtJacketsQ.Name = "txtJacketsQ";
            this.txtJacketsQ.Size = new System.Drawing.Size(46, 20);
            this.txtJacketsQ.TabIndex = 48;
            this.txtJacketsQ.TextChanged += new System.EventHandler(this.txtJacketsQ_TextChanged);
            this.txtJacketsQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJacketsQ_KeyPress);
            // 
            // txtScarfsP
            // 
            this.txtScarfsP.BackColor = System.Drawing.SystemColors.Menu;
            this.txtScarfsP.Location = new System.Drawing.Point(152, 178);
            this.txtScarfsP.Name = "txtScarfsP";
            this.txtScarfsP.Size = new System.Drawing.Size(46, 20);
            this.txtScarfsP.TabIndex = 46;
            this.txtScarfsP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtShoesQ
            // 
            this.txtShoesQ.Location = new System.Drawing.Point(219, 49);
            this.txtShoesQ.Name = "txtShoesQ";
            this.txtShoesQ.Size = new System.Drawing.Size(46, 20);
            this.txtShoesQ.TabIndex = 47;
            this.txtShoesQ.TextChanged += new System.EventHandler(this.txtShoesQ_TextChanged);
            this.txtShoesQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShoesQ_KeyPress);
            // 
            // grpCreditCardInfo
            // 
            this.grpCreditCardInfo.Controls.Add(this.NameCard);
            this.grpCreditCardInfo.Controls.Add(this.CardType);
            this.grpCreditCardInfo.Controls.Add(this.CardNumber);
            this.grpCreditCardInfo.Controls.Add(this.Expiry);
            this.grpCreditCardInfo.Controls.Add(this.IssuingBank);
            this.grpCreditCardInfo.Controls.Add(this.txtNameCard);
            this.grpCreditCardInfo.Controls.Add(this.txtCardNumber);
            this.grpCreditCardInfo.Controls.Add(this.comCardType);
            this.grpCreditCardInfo.Controls.Add(this.comIssuingBank);
            this.grpCreditCardInfo.Controls.Add(this.comExpiryMonth);
            this.grpCreditCardInfo.Controls.Add(this.comExpiryYear);
            this.grpCreditCardInfo.Location = new System.Drawing.Point(12, 219);
            this.grpCreditCardInfo.Name = "grpCreditCardInfo";
            this.grpCreditCardInfo.Size = new System.Drawing.Size(290, 177);
            this.grpCreditCardInfo.TabIndex = 78;
            this.grpCreditCardInfo.TabStop = false;
            this.grpCreditCardInfo.Text = "Credit Card Information";
            // 
            // NameCard
            // 
            this.NameCard.AutoSize = true;
            this.NameCard.Location = new System.Drawing.Point(15, 25);
            this.NameCard.Name = "NameCard";
            this.NameCard.Size = new System.Drawing.Size(75, 13);
            this.NameCard.TabIndex = 14;
            this.NameCard.Text = "Name on Card";
            // 
            // CardType
            // 
            this.CardType.AutoSize = true;
            this.CardType.Location = new System.Drawing.Point(15, 55);
            this.CardType.Name = "CardType";
            this.CardType.Size = new System.Drawing.Size(56, 13);
            this.CardType.TabIndex = 15;
            this.CardType.Text = "Card Type";
            // 
            // CardNumber
            // 
            this.CardNumber.AutoSize = true;
            this.CardNumber.Location = new System.Drawing.Point(15, 82);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(69, 13);
            this.CardNumber.TabIndex = 16;
            this.CardNumber.Text = "Card Number";
            // 
            // Expiry
            // 
            this.Expiry.AutoSize = true;
            this.Expiry.Location = new System.Drawing.Point(15, 109);
            this.Expiry.Name = "Expiry";
            this.Expiry.Size = new System.Drawing.Size(35, 13);
            this.Expiry.TabIndex = 17;
            this.Expiry.Text = "Expiry";
            // 
            // IssuingBank
            // 
            this.IssuingBank.AutoSize = true;
            this.IssuingBank.Location = new System.Drawing.Point(15, 136);
            this.IssuingBank.Name = "IssuingBank";
            this.IssuingBank.Size = new System.Drawing.Size(68, 13);
            this.IssuingBank.TabIndex = 18;
            this.IssuingBank.Text = "Issuing Bank";
            // 
            // txtNameCard
            // 
            this.txtNameCard.Location = new System.Drawing.Point(95, 22);
            this.txtNameCard.Name = "txtNameCard";
            this.txtNameCard.Size = new System.Drawing.Size(181, 20);
            this.txtNameCard.TabIndex = 19;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(95, 79);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(181, 20);
            this.txtCardNumber.TabIndex = 20;
            // 
            // comCardType
            // 
            this.comCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCardType.FormattingEnabled = true;
            this.comCardType.Location = new System.Drawing.Point(95, 52);
            this.comCardType.Name = "comCardType";
            this.comCardType.Size = new System.Drawing.Size(181, 21);
            this.comCardType.TabIndex = 21;
            this.comCardType.SelectedIndexChanged += new System.EventHandler(this.comCardType_SelectedIndexChanged);
            // 
            // comIssuingBank
            // 
            this.comIssuingBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comIssuingBank.FormattingEnabled = true;
            this.comIssuingBank.Location = new System.Drawing.Point(95, 133);
            this.comIssuingBank.Name = "comIssuingBank";
            this.comIssuingBank.Size = new System.Drawing.Size(181, 21);
            this.comIssuingBank.TabIndex = 22;
            // 
            // comExpiryMonth
            // 
            this.comExpiryMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comExpiryMonth.FormattingEnabled = true;
            this.comExpiryMonth.Location = new System.Drawing.Point(95, 106);
            this.comExpiryMonth.Name = "comExpiryMonth";
            this.comExpiryMonth.Size = new System.Drawing.Size(111, 21);
            this.comExpiryMonth.TabIndex = 23;
            // 
            // comExpiryYear
            // 
            this.comExpiryYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comExpiryYear.FormattingEnabled = true;
            this.comExpiryYear.Location = new System.Drawing.Point(212, 106);
            this.comExpiryYear.Name = "comExpiryYear";
            this.comExpiryYear.Size = new System.Drawing.Size(64, 21);
            this.comExpiryYear.TabIndex = 24;
            this.comExpiryYear.SelectedIndexChanged += new System.EventHandler(this.comExpiryYear_SelectedIndexChanged);
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.FirstName);
            this.grpCustomerDetails.Controls.Add(this.txtCounty);
            this.grpCustomerDetails.Controls.Add(this.LastName);
            this.grpCustomerDetails.Controls.Add(this.txtCity);
            this.grpCustomerDetails.Controls.Add(this.txtSuburb);
            this.grpCustomerDetails.Controls.Add(this.StreetAddress);
            this.grpCustomerDetails.Controls.Add(this.txtStreetAddress);
            this.grpCustomerDetails.Controls.Add(this.txtLastName);
            this.grpCustomerDetails.Controls.Add(this.Suburb);
            this.grpCustomerDetails.Controls.Add(this.txtFirstName);
            this.grpCustomerDetails.Controls.Add(this.County);
            this.grpCustomerDetails.Controls.Add(this.City);
            this.grpCustomerDetails.Location = new System.Drawing.Point(12, 12);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(290, 186);
            this.grpCustomerDetails.TabIndex = 77;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(15, 27);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(95, 151);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(181, 20);
            this.txtCounty.TabIndex = 12;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(15, 52);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(95, 125);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(181, 20);
            this.txtCity.TabIndex = 11;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(95, 99);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(181, 20);
            this.txtSuburb.TabIndex = 10;
            // 
            // StreetAddress
            // 
            this.StreetAddress.AutoSize = true;
            this.StreetAddress.Location = new System.Drawing.Point(15, 76);
            this.StreetAddress.Name = "StreetAddress";
            this.StreetAddress.Size = new System.Drawing.Size(76, 13);
            this.StreetAddress.TabIndex = 3;
            this.StreetAddress.Text = "Street Address";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(95, 73);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(181, 20);
            this.txtStreetAddress.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(95, 49);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(181, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // Suburb
            // 
            this.Suburb.AutoSize = true;
            this.Suburb.Location = new System.Drawing.Point(15, 102);
            this.Suburb.Name = "Suburb";
            this.Suburb.Size = new System.Drawing.Size(41, 13);
            this.Suburb.TabIndex = 4;
            this.Suburb.Text = "Suburb";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(95, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(181, 20);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // County
            // 
            this.County.AutoSize = true;
            this.County.Location = new System.Drawing.Point(15, 155);
            this.County.Name = "County";
            this.County.Size = new System.Drawing.Size(43, 13);
            this.County.TabIndex = 6;
            this.County.Text = "Country";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(15, 130);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(24, 13);
            this.City.TabIndex = 5;
            this.City.Text = "City";
            // 
            // btnShowSummary
            // 
            this.btnShowSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSummary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowSummary.Location = new System.Drawing.Point(448, 365);
            this.btnShowSummary.Name = "btnShowSummary";
            this.btnShowSummary.Size = new System.Drawing.Size(150, 36);
            this.btnShowSummary.TabIndex = 76;
            this.btnShowSummary.Text = "Show Summary";
            this.btnShowSummary.UseVisualStyleBackColor = true;
            this.btnShowSummary.Click += new System.EventHandler(this.btnShowSummary_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(347, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 75;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(343, 245);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(146, 16);
            this.TotalAmount.TabIndex = 74;
            this.TotalAmount.Text = "TOTAL AMOUNT : $";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTotalAmount.Location = new System.Drawing.Point(495, 241);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(84, 20);
            this.txtTotalAmount.TabIndex = 73;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            // 
            // SalesSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 425);
            this.Controls.Add(this.grpPaymentType);
            this.Controls.Add(this.grpProductSelection);
            this.Controls.Add(this.grpCreditCardInfo);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.btnShowSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Name = "SalesSystem";
            this.Text = "SalesSystem";
            this.grpPaymentType.ResumeLayout(false);
            this.grpPaymentType.PerformLayout();
            this.grpProductSelection.ResumeLayout(false);
            this.grpProductSelection.PerformLayout();
            this.grpCreditCardInfo.ResumeLayout(false);
            this.grpCreditCardInfo.PerformLayout();
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaymentType;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCreditCard;
        private System.Windows.Forms.RadioButton radBankTransfer;
        private System.Windows.Forms.GroupBox grpProductSelection;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.CheckBox Shoes;
        private System.Windows.Forms.CheckBox Jackets;
        private System.Windows.Forms.CheckBox Gloves;
        private System.Windows.Forms.CheckBox Beanies;
        private System.Windows.Forms.CheckBox Sweaters;
        private System.Windows.Forms.CheckBox Scarfs;
        private System.Windows.Forms.Label UnitPrice;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txtShoesP;
        private System.Windows.Forms.TextBox txtScarfsQ;
        private System.Windows.Forms.TextBox txtJacketsP;
        private System.Windows.Forms.TextBox txtSweatersQ;
        private System.Windows.Forms.TextBox txtGlovesP;
        private System.Windows.Forms.TextBox txtBeaniesQ;
        private System.Windows.Forms.TextBox txtBeaniesP;
        private System.Windows.Forms.TextBox txtGlovesQ;
        private System.Windows.Forms.TextBox txtSweatersP;
        private System.Windows.Forms.TextBox txtJacketsQ;
        private System.Windows.Forms.TextBox txtScarfsP;
        private System.Windows.Forms.TextBox txtShoesQ;
        private System.Windows.Forms.GroupBox grpCreditCardInfo;
        private System.Windows.Forms.Label NameCard;
        private System.Windows.Forms.Label CardType;
        private System.Windows.Forms.Label CardNumber;
        private System.Windows.Forms.Label Expiry;
        private System.Windows.Forms.Label IssuingBank;
        private System.Windows.Forms.TextBox txtNameCard;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.ComboBox comCardType;
        private System.Windows.Forms.ComboBox comIssuingBank;
        private System.Windows.Forms.ComboBox comExpiryMonth;
        private System.Windows.Forms.ComboBox comExpiryYear;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label StreetAddress;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label Suburb;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label County;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Button btnShowSummary;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
    }
}

