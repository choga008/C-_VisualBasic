namespace HaloFitnessApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordSubmitButton = new System.Windows.Forms.Button();
            this.PricingPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TermTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PricePerMonthLabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.PriceFullTermLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPriceNextTierLabel = new System.Windows.Forms.Label();
            this.SalesPromptLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.ClientConfirmedTextBox = new System.Windows.Forms.TextBox();
            this.QuotePanel = new System.Windows.Forms.Panel();
            this.MembershipDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.TelephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.JoinDayLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MembershipIDLabel = new System.Windows.Forms.Label();
            this.PricingGroupBox = new System.Windows.Forms.GroupBox();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.AverageMembershipFeeLabelOutput = new System.Windows.Forms.Label();
            this.AverageMembershipTermLabelOutput = new System.Windows.Forms.Label();
            this.TotalCostMembershipFeesLabelOutput = new System.Windows.Forms.Label();
            this.AverageMembershipFeeLabel = new System.Windows.Forms.Label();
            this.AverageMembershipTermLabel = new System.Windows.Forms.Label();
            this.MembershipIDsTextBox = new System.Windows.Forms.TextBox();
            this.TotalCostMembershipFeesLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchTermTextBox = new System.Windows.Forms.TextBox();
            this.SearchByDateButton = new System.Windows.Forms.Button();
            this.SearchByIDButton = new System.Windows.Forms.Button();
            this.SearchResultsTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PricingPictureBox)).BeginInit();
            this.QuotePanel.SuspendLayout();
            this.MembershipDetailsGroupBox.SuspendLayout();
            this.PricingGroupBox.SuspendLayout();
            this.SummaryGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordPanel.Controls.Add(this.label1);
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Controls.Add(this.PasswordSubmitButton);
            this.PasswordPanel.Location = new System.Drawing.Point(281, 43);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(604, 70);
            this.PasswordPanel.TabIndex = 0;
            this.PasswordPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter Your Password ";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(244, 24);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(123, 23);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordSubmitButton
            // 
            this.PasswordSubmitButton.Location = new System.Drawing.Point(411, 22);
            this.PasswordSubmitButton.Name = "PasswordSubmitButton";
            this.PasswordSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.PasswordSubmitButton.TabIndex = 0;
            this.PasswordSubmitButton.Text = "&Submit";
            this.PasswordSubmitButton.UseVisualStyleBackColor = true;
            this.PasswordSubmitButton.Click += new System.EventHandler(this.PasswordSubmitButton_Click);
            // 
            // PricingPictureBox
            // 
            this.PricingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PricingPictureBox.Image")));
            this.PricingPictureBox.Location = new System.Drawing.Point(12, 37);
            this.PricingPictureBox.Name = "PricingPictureBox";
            this.PricingPictureBox.Size = new System.Drawing.Size(212, 250);
            this.PricingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PricingPictureBox.TabIndex = 1;
            this.PricingPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monthly Base Price €59";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client Requested Term";
            // 
            // TermTextBox
            // 
            this.TermTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermTextBox.Location = new System.Drawing.Point(270, 42);
            this.TermTextBox.Name = "TermTextBox";
            this.TermTextBox.Size = new System.Drawing.Size(100, 26);
            this.TermTextBox.TabIndex = 5;
            this.TermTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price Per Month";
            // 
            // PricePerMonthLabel
            // 
            this.PricePerMonthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PricePerMonthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PricePerMonthLabel.Location = new System.Drawing.Point(143, 11);
            this.PricePerMonthLabel.Name = "PricePerMonthLabel";
            this.PricePerMonthLabel.Size = new System.Drawing.Size(75, 22);
            this.PricePerMonthLabel.TabIndex = 7;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(390, 41);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 3;
            this.DisplayButton.Text = "&Display";
            this.toolTip1.SetToolTip(this.DisplayButton, "Press to display pricing details");
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(14, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 17);
            this.label.TabIndex = 8;
            this.label.Text = "Price Full Term";
            // 
            // PriceFullTermLabel
            // 
            this.PriceFullTermLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PriceFullTermLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceFullTermLabel.Location = new System.Drawing.Point(143, 54);
            this.PriceFullTermLabel.Name = "PriceFullTermLabel";
            this.PriceFullTermLabel.Size = new System.Drawing.Size(75, 22);
            this.PriceFullTermLabel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(14, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 44);
            this.label6.TabIndex = 10;
            this.label6.Text = "Next Tier Total Price:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalPriceNextTierLabel
            // 
            this.TotalPriceNextTierLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TotalPriceNextTierLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPriceNextTierLabel.Location = new System.Drawing.Point(143, 93);
            this.TotalPriceNextTierLabel.Name = "TotalPriceNextTierLabel";
            this.TotalPriceNextTierLabel.Size = new System.Drawing.Size(75, 22);
            this.TotalPriceNextTierLabel.TabIndex = 11;
            // 
            // SalesPromptLabel
            // 
            this.SalesPromptLabel.AutoSize = true;
            this.SalesPromptLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalesPromptLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.SalesPromptLabel.Location = new System.Drawing.Point(15, 130);
            this.SalesPromptLabel.Name = "SalesPromptLabel";
            this.SalesPromptLabel.Size = new System.Drawing.Size(183, 17);
            this.SalesPromptLabel.TabIndex = 12;
            this.SalesPromptLabel.Text = "Your Sales Prompt Here";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Client Confirmed Term";
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(390, 263);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(89, 23);
            this.ProceedButton.TabIndex = 15;
            this.ProceedButton.Text = "&Proceed";
            this.toolTip1.SetToolTip(this.ProceedButton, "Press to proceed with processing membership");
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // ClientConfirmedTextBox
            // 
            this.ClientConfirmedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientConfirmedTextBox.Location = new System.Drawing.Point(270, 265);
            this.ClientConfirmedTextBox.Name = "ClientConfirmedTextBox";
            this.ClientConfirmedTextBox.Size = new System.Drawing.Size(100, 26);
            this.ClientConfirmedTextBox.TabIndex = 16;
            this.ClientConfirmedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuotePanel
            // 
            this.QuotePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuotePanel.Controls.Add(this.PricePerMonthLabel);
            this.QuotePanel.Controls.Add(this.PriceFullTermLabel);
            this.QuotePanel.Controls.Add(this.TotalPriceNextTierLabel);
            this.QuotePanel.Controls.Add(this.SalesPromptLabel);
            this.QuotePanel.Controls.Add(this.label6);
            this.QuotePanel.Controls.Add(this.label);
            this.QuotePanel.Controls.Add(this.label4);
            this.QuotePanel.Location = new System.Drawing.Point(230, 76);
            this.QuotePanel.Name = "QuotePanel";
            this.QuotePanel.Size = new System.Drawing.Size(298, 154);
            this.QuotePanel.TabIndex = 17;
            // 
            // MembershipDetailsGroupBox
            // 
            this.MembershipDetailsGroupBox.Controls.Add(this.TelephoneMaskedTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.ConfirmButton);
            this.MembershipDetailsGroupBox.Controls.Add(this.label12);
            this.MembershipDetailsGroupBox.Controls.Add(this.JoinDayLabel);
            this.MembershipDetailsGroupBox.Controls.Add(this.EmailTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.label11);
            this.MembershipDetailsGroupBox.Controls.Add(this.label9);
            this.MembershipDetailsGroupBox.Controls.Add(this.FullNameTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.label5);
            this.MembershipDetailsGroupBox.Controls.Add(this.label10);
            this.MembershipDetailsGroupBox.Controls.Add(this.MembershipIDLabel);
            this.MembershipDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipDetailsGroupBox.Location = new System.Drawing.Point(589, 12);
            this.MembershipDetailsGroupBox.Name = "MembershipDetailsGroupBox";
            this.MembershipDetailsGroupBox.Size = new System.Drawing.Size(484, 245);
            this.MembershipDetailsGroupBox.TabIndex = 4;
            this.MembershipDetailsGroupBox.TabStop = false;
            this.MembershipDetailsGroupBox.Text = "Member Details";
            // 
            // TelephoneMaskedTextBox
            // 
            this.TelephoneMaskedTextBox.Location = new System.Drawing.Point(201, 145);
            this.TelephoneMaskedTextBox.Mask = "(999) 000-0000";
            this.TelephoneMaskedTextBox.Name = "TelephoneMaskedTextBox";
            this.TelephoneMaskedTextBox.Size = new System.Drawing.Size(136, 23);
            this.TelephoneMaskedTextBox.TabIndex = 22;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(156, 216);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 18;
            this.ConfirmButton.Text = "C&onfirm";
            this.toolTip1.SetToolTip(this.ConfirmButton, "Press to enter client details");
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(47, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Joining Date";
            // 
            // JoinDayLabel
            // 
            this.JoinDayLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.JoinDayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoinDayLabel.Location = new System.Drawing.Point(201, 65);
            this.JoinDayLabel.Name = "JoinDayLabel";
            this.JoinDayLabel.Size = new System.Drawing.Size(136, 22);
            this.JoinDayLabel.TabIndex = 21;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(201, 181);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(136, 23);
            this.EmailTextBox.TabIndex = 18;
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(47, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(47, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telephone Number";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(201, 103);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(136, 23);
            this.FullNameTextBox.TabIndex = 3;
            this.FullNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(47, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Full Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(47, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Membership ID";
            // 
            // MembershipIDLabel
            // 
            this.MembershipIDLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MembershipIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MembershipIDLabel.Location = new System.Drawing.Point(201, 31);
            this.MembershipIDLabel.Name = "MembershipIDLabel";
            this.MembershipIDLabel.Size = new System.Drawing.Size(136, 22);
            this.MembershipIDLabel.TabIndex = 14;
            // 
            // PricingGroupBox
            // 
            this.PricingGroupBox.Controls.Add(this.DisplayButton);
            this.PricingGroupBox.Controls.Add(this.ProceedButton);
            this.PricingGroupBox.Controls.Add(this.label2);
            this.PricingGroupBox.Controls.Add(this.label3);
            this.PricingGroupBox.Controls.Add(this.ClientConfirmedTextBox);
            this.PricingGroupBox.Controls.Add(this.QuotePanel);
            this.PricingGroupBox.Controls.Add(this.TermTextBox);
            this.PricingGroupBox.Controls.Add(this.label8);
            this.PricingGroupBox.Controls.Add(this.PricingPictureBox);
            this.PricingGroupBox.Location = new System.Drawing.Point(26, 12);
            this.PricingGroupBox.Name = "PricingGroupBox";
            this.PricingGroupBox.Size = new System.Drawing.Size(534, 314);
            this.PricingGroupBox.TabIndex = 18;
            this.PricingGroupBox.TabStop = false;
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.linkLabel1);
            this.SummaryGroupBox.Controls.Add(this.AverageMembershipFeeLabelOutput);
            this.SummaryGroupBox.Controls.Add(this.AverageMembershipTermLabelOutput);
            this.SummaryGroupBox.Controls.Add(this.TotalCostMembershipFeesLabelOutput);
            this.SummaryGroupBox.Controls.Add(this.AverageMembershipFeeLabel);
            this.SummaryGroupBox.Controls.Add(this.AverageMembershipTermLabel);
            this.SummaryGroupBox.Controls.Add(this.MembershipIDsTextBox);
            this.SummaryGroupBox.Controls.Add(this.TotalCostMembershipFeesLabel);
            this.SummaryGroupBox.Controls.Add(this.label13);
            this.SummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryGroupBox.Location = new System.Drawing.Point(26, 340);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(609, 260);
            this.SummaryGroupBox.TabIndex = 19;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Summary Data";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(84, 89);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 22;
            // 
            // AverageMembershipFeeLabelOutput
            // 
            this.AverageMembershipFeeLabelOutput.AutoSize = true;
            this.AverageMembershipFeeLabelOutput.Location = new System.Drawing.Point(345, 214);
            this.AverageMembershipFeeLabelOutput.Name = "AverageMembershipFeeLabelOutput";
            this.AverageMembershipFeeLabelOutput.Size = new System.Drawing.Size(30, 20);
            this.AverageMembershipFeeLabelOutput.TabIndex = 21;
            this.AverageMembershipFeeLabelOutput.Text = "---";
            // 
            // AverageMembershipTermLabelOutput
            // 
            this.AverageMembershipTermLabelOutput.AutoSize = true;
            this.AverageMembershipTermLabelOutput.Location = new System.Drawing.Point(345, 141);
            this.AverageMembershipTermLabelOutput.Name = "AverageMembershipTermLabelOutput";
            this.AverageMembershipTermLabelOutput.Size = new System.Drawing.Size(30, 20);
            this.AverageMembershipTermLabelOutput.TabIndex = 20;
            this.AverageMembershipTermLabelOutput.Text = "---";
            // 
            // TotalCostMembershipFeesLabelOutput
            // 
            this.TotalCostMembershipFeesLabelOutput.AutoSize = true;
            this.TotalCostMembershipFeesLabelOutput.Location = new System.Drawing.Point(345, 69);
            this.TotalCostMembershipFeesLabelOutput.Name = "TotalCostMembershipFeesLabelOutput";
            this.TotalCostMembershipFeesLabelOutput.Size = new System.Drawing.Size(30, 20);
            this.TotalCostMembershipFeesLabelOutput.TabIndex = 19;
            this.TotalCostMembershipFeesLabelOutput.Text = "---";
            // 
            // AverageMembershipFeeLabel
            // 
            this.AverageMembershipFeeLabel.AutoSize = true;
            this.AverageMembershipFeeLabel.Location = new System.Drawing.Point(258, 179);
            this.AverageMembershipFeeLabel.Name = "AverageMembershipFeeLabel";
            this.AverageMembershipFeeLabel.Size = new System.Drawing.Size(228, 20);
            this.AverageMembershipFeeLabel.TabIndex = 18;
            this.AverageMembershipFeeLabel.Text = "Average Membership Fee:";
            // 
            // AverageMembershipTermLabel
            // 
            this.AverageMembershipTermLabel.AutoSize = true;
            this.AverageMembershipTermLabel.Location = new System.Drawing.Point(255, 111);
            this.AverageMembershipTermLabel.Name = "AverageMembershipTermLabel";
            this.AverageMembershipTermLabel.Size = new System.Drawing.Size(240, 20);
            this.AverageMembershipTermLabel.TabIndex = 17;
            this.AverageMembershipTermLabel.Text = "Average Membership Term:";
            // 
            // MembershipIDsTextBox
            // 
            this.MembershipIDsTextBox.Location = new System.Drawing.Point(12, 34);
            this.MembershipIDsTextBox.Multiline = true;
            this.MembershipIDsTextBox.Name = "MembershipIDsTextBox";
            this.MembershipIDsTextBox.ReadOnly = true;
            this.MembershipIDsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MembershipIDsTextBox.Size = new System.Drawing.Size(218, 97);
            this.MembershipIDsTextBox.TabIndex = 15;
            // 
            // TotalCostMembershipFeesLabel
            // 
            this.TotalCostMembershipFeesLabel.AutoSize = true;
            this.TotalCostMembershipFeesLabel.Location = new System.Drawing.Point(255, 37);
            this.TotalCostMembershipFeesLabel.Name = "TotalCostMembershipFeesLabel";
            this.TotalCostMembershipFeesLabel.Size = new System.Drawing.Size(281, 20);
            this.TotalCostMembershipFeesLabel.TabIndex = 14;
            this.TotalCostMembershipFeesLabel.Text = "Total Amount Membership Fees:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(33, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 13;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchTermTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchByDateButton);
            this.SearchGroupBox.Controls.Add(this.SearchByIDButton);
            this.SearchGroupBox.Controls.Add(this.SearchResultsTextBox);
            this.SearchGroupBox.Controls.Add(this.label14);
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(655, 340);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(418, 260);
            this.SearchGroupBox.TabIndex = 20;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // SearchTermTextBox
            // 
            this.SearchTermTextBox.Location = new System.Drawing.Point(103, 25);
            this.SearchTermTextBox.Name = "SearchTermTextBox";
            this.SearchTermTextBox.Size = new System.Drawing.Size(222, 26);
            this.SearchTermTextBox.TabIndex = 21;
            this.SearchTermTextBox.Text = "Search Term";
            // 
            // SearchByDateButton
            // 
            this.SearchByDateButton.Location = new System.Drawing.Point(285, 69);
            this.SearchByDateButton.Name = "SearchByDateButton";
            this.SearchByDateButton.Size = new System.Drawing.Size(106, 52);
            this.SearchByDateButton.TabIndex = 20;
            this.SearchByDateButton.Text = "Search by Date";
            this.SearchByDateButton.UseVisualStyleBackColor = true;
            this.SearchByDateButton.Click += new System.EventHandler(this.SearchByDateButton_Click);
            // 
            // SearchByIDButton
            // 
            this.SearchByIDButton.Location = new System.Drawing.Point(52, 69);
            this.SearchByIDButton.Name = "SearchByIDButton";
            this.SearchByIDButton.Size = new System.Drawing.Size(107, 52);
            this.SearchByIDButton.TabIndex = 19;
            this.SearchByIDButton.Text = "Search by ID";
            this.SearchByIDButton.UseVisualStyleBackColor = true;
            this.SearchByIDButton.Click += new System.EventHandler(this.SearchByIDButton_Click);
            // 
            // SearchResultsTextBox
            // 
            this.SearchResultsTextBox.Location = new System.Drawing.Point(103, 147);
            this.SearchResultsTextBox.Multiline = true;
            this.SearchResultsTextBox.Name = "SearchResultsTextBox";
            this.SearchResultsTextBox.ReadOnly = true;
            this.SearchResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SearchResultsTextBox.Size = new System.Drawing.Size(218, 87);
            this.SearchResultsTextBox.TabIndex = 17;
            this.SearchResultsTextBox.Text = "Search Results:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(110, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 14;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.SearchButton);
            this.ButtonPanel.Controls.Add(this.ExitButton);
            this.ButtonPanel.Controls.Add(this.SummaryButton);
            this.ButtonPanel.Controls.Add(this.ClearButton);
            this.ButtonPanel.Location = new System.Drawing.Point(589, 275);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(484, 51);
            this.ButtonPanel.TabIndex = 21;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(245, 16);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "S&earch";
            this.toolTip1.SetToolTip(this.SearchButton, "Press to bring up functionality to search records");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(333, 16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.ExitButton, "Press to exit application");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(135, 16);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(95, 23);
            this.SummaryButton.TabIndex = 1;
            this.SummaryButton.Text = "&Summary";
            this.toolTip1.SetToolTip(this.SummaryButton, "Press to show summary of company sales ");
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(49, 16);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.ClearButton, "Press to clear form");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 620);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.PricingGroupBox);
            this.Controls.Add(this.MembershipDetailsGroupBox);
            this.Controls.Add(this.PasswordPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Welcome to Halo Fitness";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PricingPictureBox)).EndInit();
            this.QuotePanel.ResumeLayout(false);
            this.QuotePanel.PerformLayout();
            this.MembershipDetailsGroupBox.ResumeLayout(false);
            this.MembershipDetailsGroupBox.PerformLayout();
            this.PricingGroupBox.ResumeLayout(false);
            this.PricingGroupBox.PerformLayout();
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button PasswordSubmitButton;
        private System.Windows.Forms.PictureBox PricingPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.TextBox ClientConfirmedTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SalesPromptLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TermTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel QuotePanel;
        private System.Windows.Forms.Label PricePerMonthLabel;
        private System.Windows.Forms.Label PriceFullTermLabel;
        private System.Windows.Forms.Label TotalPriceNextTierLabel;
        private System.Windows.Forms.GroupBox MembershipDetailsGroupBox;
        private System.Windows.Forms.Label MembershipIDLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label JoinDayLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox PricingGroupBox;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label TotalCostMembershipFeesLabel;
        private System.Windows.Forms.TextBox MembershipIDsTextBox;
        private System.Windows.Forms.Label AverageMembershipFeeLabel;
        private System.Windows.Forms.Label AverageMembershipTermLabel;
        private System.Windows.Forms.Label TotalCostMembershipFeesLabelOutput;
        private System.Windows.Forms.Label AverageMembershipTermLabelOutput;
        private System.Windows.Forms.Label AverageMembershipFeeLabelOutput;
        private System.Windows.Forms.TextBox SearchTermTextBox;
        private System.Windows.Forms.Button SearchByDateButton;
        private System.Windows.Forms.Button SearchByIDButton;
        private System.Windows.Forms.TextBox SearchResultsTextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MaskedTextBox TelephoneMaskedTextBox;
    }
}

