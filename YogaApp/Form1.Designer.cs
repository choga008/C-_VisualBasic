namespace yogi_ireland
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WorkshopListBox = new System.Windows.Forms.ListBox();
            this.LocationListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CertificateCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CompleteOrderButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.BookingPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.CurrentCostValue = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.CurrentCostLabel = new System.Windows.Forms.Label();
            this.AddToBookingButton = new System.Windows.Forms.Button();
            this.NumPlaces = new System.Windows.Forms.NumericUpDown();
            this.NoPlacesLabel = new System.Windows.Forms.Label();
            this.PricePerPersonLabel = new System.Windows.Forms.Label();
            this.labelPPP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MealListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchResultsTB = new System.Windows.Forms.TextBox();
            this.SearchTermTextBox = new System.Windows.Forms.TextBox();
            this.SearchByDateButton = new System.Windows.Forms.Button();
            this.SearchByIDButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateQuant = new System.Windows.Forms.NumericUpDown();
            this.UpdateQuantity = new System.Windows.Forms.Button();
            this.ButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.ManagementStockButton = new System.Windows.Forms.Button();
            this.LabelTotalPlaces = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ItemBasket = new System.Windows.Forms.ListBox();
            this.LabelTotalSalesOrder = new System.Windows.Forms.Label();
            this.TotalCostSalesLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectionPanel.SuspendLayout();
            this.BookingPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPlaces)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateQuant)).BeginInit();
            this.ButtonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkshopListBox
            // 
            this.WorkshopListBox.FormattingEnabled = true;
            this.WorkshopListBox.ItemHeight = 16;
            this.WorkshopListBox.Items.AddRange(new object[] {
            "Hatha\t\t\t5 days \t\t€1,000",
            "Prenatal \t\t\t5 days \t\t€900",
            "Vinyasa\t\t\t4 days \t\t€950",
            "Bikram\t\t\t4 days \t\t€850",
            "Iyengar\t\t\t4 days\t\t€900",
            "Chakras\t\t\t3 days \t\t€700",
            "Aerial \t\t\t3 days \t\t€800",
            "Jivamukti\t\t\t2 days \t\t€500",
            "Partners\t \t\t1 day\t\t€300"});
            this.WorkshopListBox.Location = new System.Drawing.Point(45, 37);
            this.WorkshopListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WorkshopListBox.Name = "WorkshopListBox";
            this.WorkshopListBox.Size = new System.Drawing.Size(395, 148);
            this.WorkshopListBox.TabIndex = 31;
            // 
            // LocationListBox
            // 
            this.LocationListBox.FormattingEnabled = true;
            this.LocationListBox.ItemHeight = 16;
            this.LocationListBox.Items.AddRange(new object[] {
            "Burren\t\t€100",
            "Clare\t\t€295",
            "Dingle\t\t€180",
            "Leitrim\t\t€250",
            "Louth\t\t€195",
            "Wicklow\t\t€235"});
            this.LocationListBox.Location = new System.Drawing.Point(485, 37);
            this.LocationListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LocationListBox.Name = "LocationListBox";
            this.LocationListBox.Size = new System.Drawing.Size(197, 100);
            this.LocationListBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 26);
            this.label7.TabIndex = 32;
            this.label7.Text = "Workshops";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(331, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 26);
            this.label8.TabIndex = 33;
            this.label8.Text = "Fees";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 26);
            this.label9.TabIndex = 34;
            this.label9.Text = "Training Days";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(481, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 26);
            this.label10.TabIndex = 35;
            this.label10.Text = "Locations";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(573, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 26);
            this.label11.TabIndex = 36;
            this.label11.Text = "Fees (daily)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CertificateCheckBox
            // 
            this.CertificateCheckBox.AutoSize = true;
            this.CertificateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CertificateCheckBox.Location = new System.Drawing.Point(947, 11);
            this.CertificateCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CertificateCheckBox.Name = "CertificateCheckBox";
            this.CertificateCheckBox.Size = new System.Drawing.Size(109, 55);
            this.CertificateCheckBox.TabIndex = 42;
            this.CertificateCheckBox.Text = "Teaching \r\nCertificate \r\n(€100)";
            this.CertificateCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 17);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(131, 28);
            this.ClearButton.TabIndex = 44;
            this.ClearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.ClearButton, "Clears selections and unconfirmed bookings");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 116);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(131, 28);
            this.ExitButton.TabIndex = 45;
            this.ExitButton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.ExitButton, "Closes Application and writes daily transactions to file");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CompleteOrderButton
            // 
            this.CompleteOrderButton.Location = new System.Drawing.Point(702, 325);
            this.CompleteOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompleteOrderButton.Name = "CompleteOrderButton";
            this.CompleteOrderButton.Size = new System.Drawing.Size(187, 70);
            this.CompleteOrderButton.TabIndex = 46;
            this.CompleteOrderButton.Text = "&Complete Order";
            this.toolTip1.SetToolTip(this.CompleteOrderButton, "Proceed with booking process for the workshops listed");
            this.CompleteOrderButton.UseVisualStyleBackColor = true;
            this.CompleteOrderButton.Click += new System.EventHandler(this.CompleteOrderButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NameLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NameLabel.Location = new System.Drawing.Point(648, 11);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 17);
            this.NameLabel.TabIndex = 64;
            // 
            // SelectionPanel
            // 
            this.SelectionPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.SelectionPanel.Controls.Add(this.BookingPriceGroupBox);
            this.SelectionPanel.Controls.Add(this.label3);
            this.SelectionPanel.Controls.Add(this.CertificateCheckBox);
            this.SelectionPanel.Controls.Add(this.label4);
            this.SelectionPanel.Controls.Add(this.MealListBox);
            this.SelectionPanel.Controls.Add(this.label11);
            this.SelectionPanel.Controls.Add(this.label10);
            this.SelectionPanel.Controls.Add(this.label9);
            this.SelectionPanel.Controls.Add(this.label8);
            this.SelectionPanel.Controls.Add(this.label7);
            this.SelectionPanel.Controls.Add(this.WorkshopListBox);
            this.SelectionPanel.Controls.Add(this.LocationListBox);
            this.SelectionPanel.Location = new System.Drawing.Point(25, 7);
            this.SelectionPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(1492, 191);
            this.SelectionPanel.TabIndex = 65;
            // 
            // BookingPriceGroupBox
            // 
            this.BookingPriceGroupBox.Controls.Add(this.CurrentCostValue);
            this.BookingPriceGroupBox.Controls.Add(this.DisplayButton);
            this.BookingPriceGroupBox.Controls.Add(this.CurrentCostLabel);
            this.BookingPriceGroupBox.Controls.Add(this.AddToBookingButton);
            this.BookingPriceGroupBox.Controls.Add(this.NumPlaces);
            this.BookingPriceGroupBox.Controls.Add(this.NoPlacesLabel);
            this.BookingPriceGroupBox.Controls.Add(this.PricePerPersonLabel);
            this.BookingPriceGroupBox.Controls.Add(this.labelPPP);
            this.BookingPriceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingPriceGroupBox.Location = new System.Drawing.Point(1078, 7);
            this.BookingPriceGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookingPriceGroupBox.Name = "BookingPriceGroupBox";
            this.BookingPriceGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookingPriceGroupBox.Size = new System.Drawing.Size(373, 175);
            this.BookingPriceGroupBox.TabIndex = 43;
            this.BookingPriceGroupBox.TabStop = false;
            this.BookingPriceGroupBox.Text = "Price for Booking";
            // 
            // CurrentCostValue
            // 
            this.CurrentCostValue.AutoSize = true;
            this.CurrentCostValue.Location = new System.Drawing.Point(224, 98);
            this.CurrentCostValue.Name = "CurrentCostValue";
            this.CurrentCostValue.Size = new System.Drawing.Size(26, 17);
            this.CurrentCostValue.TabIndex = 45;
            this.CurrentCostValue.Text = "---";
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(29, 129);
            this.DisplayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(131, 34);
            this.DisplayButton.TabIndex = 63;
            this.DisplayButton.Text = "Display Cost";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // CurrentCostLabel
            // 
            this.CurrentCostLabel.AutoSize = true;
            this.CurrentCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentCostLabel.Location = new System.Drawing.Point(25, 98);
            this.CurrentCostLabel.Name = "CurrentCostLabel";
            this.CurrentCostLabel.Size = new System.Drawing.Size(87, 17);
            this.CurrentCostLabel.TabIndex = 44;
            this.CurrentCostLabel.Text = "Total Cost:";
            // 
            // AddToBookingButton
            // 
            this.AddToBookingButton.Location = new System.Drawing.Point(196, 129);
            this.AddToBookingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddToBookingButton.Name = "AddToBookingButton";
            this.AddToBookingButton.Size = new System.Drawing.Size(137, 34);
            this.AddToBookingButton.TabIndex = 6;
            this.AddToBookingButton.Text = "Add to Booking";
            this.toolTip1.SetToolTip(this.AddToBookingButton, "Adds current selection to Booking list of this Sales Order");
            this.AddToBookingButton.UseVisualStyleBackColor = true;
            this.AddToBookingButton.Click += new System.EventHandler(this.AddToBookingButton_Click);
            // 
            // NumPlaces
            // 
            this.NumPlaces.Location = new System.Drawing.Point(228, 27);
            this.NumPlaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumPlaces.Name = "NumPlaces";
            this.NumPlaces.Size = new System.Drawing.Size(79, 22);
            this.NumPlaces.TabIndex = 3;
            // 
            // NoPlacesLabel
            // 
            this.NoPlacesLabel.AutoSize = true;
            this.NoPlacesLabel.Location = new System.Drawing.Point(25, 30);
            this.NoPlacesLabel.Name = "NoPlacesLabel";
            this.NoPlacesLabel.Size = new System.Drawing.Size(105, 17);
            this.NoPlacesLabel.TabIndex = 2;
            this.NoPlacesLabel.Text = "No of Places:";
            // 
            // PricePerPersonLabel
            // 
            this.PricePerPersonLabel.AutoSize = true;
            this.PricePerPersonLabel.Location = new System.Drawing.Point(224, 65);
            this.PricePerPersonLabel.Name = "PricePerPersonLabel";
            this.PricePerPersonLabel.Size = new System.Drawing.Size(26, 17);
            this.PricePerPersonLabel.TabIndex = 1;
            this.PricePerPersonLabel.Text = "---";
            // 
            // labelPPP
            // 
            this.labelPPP.AutoSize = true;
            this.labelPPP.Location = new System.Drawing.Point(25, 65);
            this.labelPPP.Name = "labelPPP";
            this.labelPPP.Size = new System.Drawing.Size(134, 17);
            this.labelPPP.TabIndex = 0;
            this.labelPPP.Text = "Price per person:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(809, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fees (daily)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(717, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 38;
            this.label4.Text = "Meal Plans";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MealListBox
            // 
            this.MealListBox.FormattingEnabled = true;
            this.MealListBox.ItemHeight = 16;
            this.MealListBox.Items.AddRange(new object[] {
            "Vegan\t\t€10.00",
            "Veg\t\t€8.00",
            "Breakfast Only\t€5.00",
            "No Meal\t\t€0.00"});
            this.MealListBox.Location = new System.Drawing.Point(721, 37);
            this.MealListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MealListBox.Name = "MealListBox";
            this.MealListBox.Size = new System.Drawing.Size(197, 100);
            this.MealListBox.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.SelectionPanel);
            this.panel3.Location = new System.Drawing.Point(16, 370);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1532, 794);
            this.panel3.TabIndex = 68;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchResultsTB);
            this.groupBox2.Controls.Add(this.SearchTermTextBox);
            this.groupBox2.Controls.Add(this.SearchByDateButton);
            this.groupBox2.Controls.Add(this.SearchByIDButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1004, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(516, 577);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // SearchResultsTB
            // 
            this.SearchResultsTB.Location = new System.Drawing.Point(84, 191);
            this.SearchResultsTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchResultsTB.Multiline = true;
            this.SearchResultsTB.Name = "SearchResultsTB";
            this.SearchResultsTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SearchResultsTB.Size = new System.Drawing.Size(352, 274);
            this.SearchResultsTB.TabIndex = 70;
            // 
            // SearchTermTextBox
            // 
            this.SearchTermTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTermTextBox.Location = new System.Drawing.Point(47, 58);
            this.SearchTermTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTermTextBox.Name = "SearchTermTextBox";
            this.SearchTermTextBox.Size = new System.Drawing.Size(429, 22);
            this.SearchTermTextBox.TabIndex = 21;
            this.SearchTermTextBox.Text = "Search Term";
            // 
            // SearchByDateButton
            // 
            this.SearchByDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByDateButton.Location = new System.Drawing.Point(267, 104);
            this.SearchByDateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchByDateButton.Name = "SearchByDateButton";
            this.SearchByDateButton.Size = new System.Drawing.Size(126, 70);
            this.SearchByDateButton.TabIndex = 20;
            this.SearchByDateButton.Text = "Search by Date\r\n(yyyy-MM-dd)\r\n";
            this.SearchByDateButton.UseVisualStyleBackColor = true;
            this.SearchByDateButton.Click += new System.EventHandler(this.SearchByDateButton_Click);
            // 
            // SearchByIDButton
            // 
            this.SearchByIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByIDButton.Location = new System.Drawing.Point(121, 104);
            this.SearchByIDButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchByIDButton.Name = "SearchByIDButton";
            this.SearchByIDButton.Size = new System.Drawing.Size(116, 70);
            this.SearchByIDButton.TabIndex = 19;
            this.SearchByIDButton.Text = "Search by ID\r\n(######)";
            this.SearchByIDButton.UseVisualStyleBackColor = true;
            this.SearchByIDButton.Click += new System.EventHandler(this.SearchByIDButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UpdateQuant);
            this.groupBox1.Controls.Add(this.UpdateQuantity);
            this.groupBox1.Controls.Add(this.ButtonGroupBox);
            this.groupBox1.Controls.Add(this.LabelTotalPlaces);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.ItemBasket);
            this.groupBox1.Controls.Add(this.LabelTotalSalesOrder);
            this.groupBox1.Controls.Add(this.TotalCostSalesLabel);
            this.groupBox1.Controls.Add(this.CompleteOrderButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(966, 577);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Order Details";
            // 
            // UpdateQuant
            // 
            this.UpdateQuant.Location = new System.Drawing.Point(673, 67);
            this.UpdateQuant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateQuant.Name = "UpdateQuant";
            this.UpdateQuant.Size = new System.Drawing.Size(56, 22);
            this.UpdateQuant.TabIndex = 51;
            this.toolTip1.SetToolTip(this.UpdateQuant, "NOTE: Setting to 0 removes the item from basket.");
            // 
            // UpdateQuantity
            // 
            this.UpdateQuantity.Location = new System.Drawing.Point(654, 102);
            this.UpdateQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateQuantity.Name = "UpdateQuantity";
            this.UpdateQuantity.Size = new System.Drawing.Size(100, 46);
            this.UpdateQuantity.TabIndex = 50;
            this.UpdateQuantity.Text = "Update Quantity";
            this.UpdateQuantity.UseVisualStyleBackColor = true;
            this.UpdateQuantity.Click += new System.EventHandler(this.UpdateQuantity_Click);
            // 
            // ButtonGroupBox
            // 
            this.ButtonGroupBox.Controls.Add(this.ManagementStockButton);
            this.ButtonGroupBox.Controls.Add(this.ExitButton);
            this.ButtonGroupBox.Controls.Add(this.ClearButton);
            this.ButtonGroupBox.Location = new System.Drawing.Point(799, 30);
            this.ButtonGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonGroupBox.Name = "ButtonGroupBox";
            this.ButtonGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonGroupBox.Size = new System.Drawing.Size(153, 161);
            this.ButtonGroupBox.TabIndex = 68;
            this.ButtonGroupBox.TabStop = false;
            // 
            // ManagementStockButton
            // 
            this.ManagementStockButton.Location = new System.Drawing.Point(12, 53);
            this.ManagementStockButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManagementStockButton.Name = "ManagementStockButton";
            this.ManagementStockButton.Size = new System.Drawing.Size(131, 55);
            this.ManagementStockButton.TabIndex = 63;
            this.ManagementStockButton.Text = "&Management Stock Report";
            this.toolTip1.SetToolTip(this.ManagementStockButton, "Creates Management Report");
            this.ManagementStockButton.UseVisualStyleBackColor = true;
            this.ManagementStockButton.Click += new System.EventHandler(this.ManagementStockButton_Click);
            // 
            // LabelTotalPlaces
            // 
            this.LabelTotalPlaces.AutoSize = true;
            this.LabelTotalPlaces.Location = new System.Drawing.Point(835, 277);
            this.LabelTotalPlaces.Name = "LabelTotalPlaces";
            this.LabelTotalPlaces.Size = new System.Drawing.Size(26, 17);
            this.LabelTotalPlaces.TabIndex = 49;
            this.LabelTotalPlaces.Text = "---";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(667, 265);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 34);
            this.label20.TabIndex = 48;
            this.label20.Text = "Total Number \r\nof Places:";
            // 
            // ItemBasket
            // 
            this.ItemBasket.FormattingEnabled = true;
            this.ItemBasket.ItemHeight = 16;
            this.ItemBasket.Location = new System.Drawing.Point(5, 30);
            this.ItemBasket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemBasket.Name = "ItemBasket";
            this.ItemBasket.Size = new System.Drawing.Size(600, 324);
            this.ItemBasket.TabIndex = 47;
            // 
            // LabelTotalSalesOrder
            // 
            this.LabelTotalSalesOrder.AutoSize = true;
            this.LabelTotalSalesOrder.Location = new System.Drawing.Point(835, 223);
            this.LabelTotalSalesOrder.Name = "LabelTotalSalesOrder";
            this.LabelTotalSalesOrder.Size = new System.Drawing.Size(26, 17);
            this.LabelTotalSalesOrder.TabIndex = 4;
            this.LabelTotalSalesOrder.Text = "---";
            // 
            // TotalCostSalesLabel
            // 
            this.TotalCostSalesLabel.AutoSize = true;
            this.TotalCostSalesLabel.Location = new System.Drawing.Point(667, 207);
            this.TotalCostSalesLabel.Name = "TotalCostSalesLabel";
            this.TotalCostSalesLabel.Size = new System.Drawing.Size(100, 34);
            this.TotalCostSalesLabel.TabIndex = 3;
            this.TotalCostSalesLabel.Text = "Sales Order \r\nTotal Cost:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 351);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1575, 1055);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YogiIreland";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SelectionPanel.ResumeLayout(false);
            this.SelectionPanel.PerformLayout();
            this.BookingPriceGroupBox.ResumeLayout(false);
            this.BookingPriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPlaces)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateQuant)).EndInit();
            this.ButtonGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox WorkshopListBox;
        private System.Windows.Forms.ListBox LocationListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CertificateCheckBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CompleteOrderButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel SelectionPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox ButtonGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox MealListBox;
        private System.Windows.Forms.GroupBox BookingPriceGroupBox;
        private System.Windows.Forms.NumericUpDown NumPlaces;
        private System.Windows.Forms.Label NoPlacesLabel;
        private System.Windows.Forms.Label PricePerPersonLabel;
        private System.Windows.Forms.Label labelPPP;
        private System.Windows.Forms.Button AddToBookingButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelTotalSalesOrder;
        private System.Windows.Forms.Label TotalCostSalesLabel;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.ListBox ItemBasket;
        private System.Windows.Forms.Label LabelTotalPlaces;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button UpdateQuantity;
        private System.Windows.Forms.NumericUpDown UpdateQuant;
        private System.Windows.Forms.Label CurrentCostValue;
        private System.Windows.Forms.Label CurrentCostLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SearchTermTextBox;
        private System.Windows.Forms.Button SearchByDateButton;
        private System.Windows.Forms.Button SearchByIDButton;
        //private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Button ManagementStockButton;
        private System.Windows.Forms.TextBox SearchResultsTB;
    }
}

