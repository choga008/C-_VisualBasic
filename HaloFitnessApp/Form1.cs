/* Student Name: Caitlin Hogan
 * Student ID: 20231704
 * Date: 07/12/2020
 * Assignment: 3
 * Assignment: Create a fitness application.
 */


using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HaloFitnessApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        const int INCREMENT = 2, FORMWIDTH = 954, FORMSTARTHEIGHT = 380, FORMEXPANDHEIGHT = 620;
        int PasswordAttempts = 0;
        const decimal BASE_RATE = 59.00m;
        const string PATHWAY = "C:\\Users\\caitl\\OneDrive\\Desktop\\Asgt 3\\HaloFitnessApp\\HaloFitnessApp\\MemberDetails.txt";


        // Creates a CultureInfo for Euro in Ireland
        private CultureInfo Locality = new CultureInfo("en-IE");

        private void MainForm_Load(object sender, EventArgs e)
        {
            MembershipDetailsGroupBox.Visible = false;
            PricingGroupBox.Visible = false;
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = false;
            ButtonPanel.Visible = false;
            PasswordPanel.Visible = true;
            this.Size = new Size(FORMWIDTH,FORMSTARTHEIGHT);
        }

        private void PasswordSubmitButton_Click(object sender, EventArgs e)
        {            
            //const int MIN_LENGTH = 0; // Password - minimum length
            
            // Get password from TextBox
            string Password = PasswordTextBox.Text;
            PasswordAttempts++;

            // Validate password            
            if (PasswordAttempts < 4 && Password == "ILuvVisualC#")
            {             
                MessageBox.Show("The password is correct.");                
                PasswordPanel.Visible = false;
                PricingGroupBox.Visible = true;
                ButtonPanel.Visible = true;
            }

            else if (PasswordAttempts < 3)
            {
                MessageBox.Show("Incorrect password. Please try again.");
                PasswordTextBox.Text = "";
                PasswordTextBox.Focus();
            }

            else
            {
                MessageBox.Show("The password does not meet the requirements. No attempts left.");
                this.Close();
            }
           
        }

        private void CalculateDiscountRates(int NumberOfMonths, ref int NextTierNumberOfMonths, ref decimal CurrentDiscountRate, ref decimal NextTierDiscountRate)
        {
            if (NumberOfMonths <= 2)
            {
                NextTierNumberOfMonths = 3;
                CurrentDiscountRate = 0;
                NextTierDiscountRate = 0.1m;
            }

            else if (NumberOfMonths <= 6)
            {
                NextTierNumberOfMonths = 7;
                CurrentDiscountRate = 0.1m;
                NextTierDiscountRate = 0.2m;
            }

            else if (NumberOfMonths <= 12)
            {
                NextTierNumberOfMonths = 13;
                CurrentDiscountRate = 0.2m;
                NextTierDiscountRate = 0.25m;
            }

            else if (NumberOfMonths <= 18)
            {
                NextTierNumberOfMonths = 19;
                CurrentDiscountRate = 0.25m;
                NextTierDiscountRate = 0.3333m;
            }

            else if (NumberOfMonths <= 24)
            {
                NextTierNumberOfMonths = 25;
                CurrentDiscountRate = 0.3333m;
                NextTierDiscountRate = 0.4m;
            }

            else if (NumberOfMonths <= 60)
            {
                NextTierNumberOfMonths = 61;
                CurrentDiscountRate = 0.4m;
                NextTierDiscountRate = 0.6666m;
            }

            else
            {
                NextTierNumberOfMonths = 61;
                CurrentDiscountRate = 0.6666m;
                NextTierDiscountRate = 0.6666m;
            }

        }


        private void DisplayButton_Click(object sender, EventArgs e)
        {
            //calculate cost per month based on client requested term
            //try to upsell the client by displaying the next tier of discounted term's total cost

            int NumberOfMonths = 0;

            bool success = Int32.TryParse(TermTextBox.Text, out NumberOfMonths);
            if (!success)
            {
                MessageBox.Show("Invalid number of months.");
                
            }
            else
            {
                //calculations here
                decimal TotalCost = BASE_RATE * NumberOfMonths;

                //work out discounted price
                int NextTierNumberOfMonths = 0;
                decimal CurrentDiscountRate = 0;
                decimal NextTierDiscountRate = 0;

                //call function to set discount rates
                CalculateDiscountRates(NumberOfMonths, ref NextTierNumberOfMonths, ref CurrentDiscountRate, ref NextTierDiscountRate);


                //Full Term Cost
                TotalCost = TotalCost - (TotalCost * CurrentDiscountRate);
                //Monthly Cost
                decimal MonthlyCost = BASE_RATE - (BASE_RATE * CurrentDiscountRate);
                //Next Term Cost
                decimal NextTermCost = (NextTierNumberOfMonths * BASE_RATE) - ((NextTierNumberOfMonths * BASE_RATE) * NextTierDiscountRate);
                PricePerMonthLabel.Text = MonthlyCost.ToString("C", Locality);
                PriceFullTermLabel.Text = TotalCost.ToString("C", Locality);
                if (NumberOfMonths <= 60)
                {
                    SalesPromptLabel.Text = "Offer the client: " + NextTierNumberOfMonths.ToString() + " months at " + (BASE_RATE * (1 - NextTierDiscountRate)).ToString("C", Locality);

                    TotalPriceNextTierLabel.Text = NextTermCost.ToString("C", Locality);
                }

                else
                {
                    SalesPromptLabel.Text = "Maximum discount already applied";

                    TotalPriceNextTierLabel.Text = "N/A";
                }
                                
            }

        }
        

    private void ProceedButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            int ClientConfirmTerm = 0; 

            // Proceed button needs to be disabled and 
            // no new Member ID generated if Client Confirm Term is empty!
            if (ClientConfirmedTextBox.Text == "")
            {
                MessageBox.Show("Client must confirm term length.");
                valid = false;                
                ClientConfirmedTextBox.Focus();
            }

            //validate Client Confirmed Term is an integer
            else if (!(Int32.TryParse(ClientConfirmedTextBox.Text, out ClientConfirmTerm)))
            {
                MessageBox.Show("Client Confirmed Term must be an integer value (i.e., number of months).");
                valid = false;
                ClientConfirmedTextBox.Focus();
            }

            else
            {
                MembershipDetailsGroupBox.Visible = true;

                //generate random ID value that is 6 characters long
                //integer generated must be between 100000 and 999999
                //technically, this may eventually produce duplicate IDs, but  
                //seed is based on current time 
                Random R = new Random(DateTime.Now.Millisecond);
                int NewID = R.Next(100000, 999999);

                // Check if NewID is duplicate                                  
                while (CheckDuplicates(NewID) == true)
                {
                    R = new Random(DateTime.Now.Millisecond);
                    NewID = R.Next(100000, 999999);                    
                }

                MembershipIDLabel.Text = NewID.ToString();
               

                //get today's date
                JoinDayLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
                

                //Clear Client Confirmed Term for next member to be added
                //ClientConfirmedTextBox.Text = "";

                //Set focus on Full Name Text Box to enter new member details
                FullNameTextBox.Focus();
                
            }

            ClientConfirmedTextBox.Enabled = false;
            //ProceedButton.Enabled = true;
        }

        private bool CheckDuplicates(int NewID)
        {
            try
            {
                        //open file as text file and append client details to end of text file
                        using (StreamReader stream = new StreamReader(PATHWAY))
                        {
                            string Line = "";                        
                            //int RecordLength = 0;

                            // Read and write lines from the file until end of file is reached
                            while ((Line = stream.ReadLine()) != null)
                            {

                                if (Int32.Parse(Line) == NewID)
                                {
                                    MessageBox.Show("ID is already taken.");
                                    return true;
                                }                        
                              
                                for (int i = 0; i < 6; i++)
                                {
                                    Line = stream.ReadLine();                                

                                }
                            }

                    return false;
                        
                        }

                    }

                    catch (Exception e1)
                    {
                        MessageBox.Show("File does not exist. Please try again." + e1.Message);
                    }

            return false;
    }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //Re-enable the Client Confirmed Term text box
            ClientConfirmedTextBox.Enabled = true;

            //Validate user input fields
            bool valid = true;
            bool IsEmail = Regex.IsMatch(EmailTextBox.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            //int PhoneNumber = 0;            

            //Membership ID must be 6 digits; it cannot be empty or not 6 digits in length
            if (MembershipIDLabel.Text.Length != 6)
            {
                MessageBox.Show("ID must be 6 digits");
                valid = false;
            }

            //validate that name, phone number, and email are not empty
            else if (string.IsNullOrEmpty(FullNameTextBox.Text) || string.IsNullOrEmpty(TelephoneMaskedTextBox.Text) || string.IsNullOrEmpty(EmailTextBox.Text))
            {
                MessageBox.Show("Name, Phone Number, and Email must all be filled in.");
                valid = false;
            }

            //else if (!(TelephoneTextBox.Text.Length == 9 || TelephoneTextBox.Text.Length == 10))
            //{
            //    MessageBox.Show("Phone Number must be 9 or 10 digits.");
            //    valid = false;
            //}

            //else if (!(Int32.TryParse(TelephoneMaskedTextBox.Text, out PhoneNumber)))
            //{
            //    MessageBox.Show("Telephone number must be digits only.");
            //    valid = false;
            //}

            //else if (!EmailTextBox.Text.Contains("@"))
            //{
            //    MessageBox.Show("Email address is not properly formatted. Please enter a valid email address.");
            //    valid = false;
            //}

            //else if (!EmailTextBox.Text.Contains("."))
            //{
            //    MessageBox.Show("Email address is not properly formatted. Please enter a valid email address.");
            //    valid = false;
            //}

            //validate email using RegEx - Please see https://stackoverflow.com/questions/16167983/best-regular-expression-for-email-validation-in-c-sharp/16168118
            //Author: Raj, P. 
            else if (!IsEmail)
            {
                MessageBox.Show("Email address is not properly formatted. Please enter a valid email address.");
                valid = false;
            }

            if (valid)
            {
                //work out total cost from Confirmed Term
                int ConfirmedMonths = 0;

                Int32.TryParse(ClientConfirmedTextBox.Text, out ConfirmedMonths);                

                int NextTierNumberOfMonths = 0;
                decimal CurrentDiscountRate = 0;
                decimal NextTierDiscountRate = 0;

                //call function to set discount rates
                CalculateDiscountRates(ConfirmedMonths, ref NextTierNumberOfMonths, ref CurrentDiscountRate, ref NextTierDiscountRate);
                
                //Confirmed Term Cost
                decimal TotalCost = (ConfirmedMonths * BASE_RATE) - ((ConfirmedMonths * BASE_RATE) * CurrentDiscountRate);
                
                try
                {
                    //open file as text file and append client details to end of text file
                    using (StreamWriter stream = File.AppendText(PATHWAY))
                    {
                        stream.WriteLine(MembershipIDLabel.Text);
                        stream.WriteLine(JoinDayLabel.Text);
                        stream.WriteLine(FullNameTextBox.Text);
                        stream.WriteLine(TelephoneMaskedTextBox.Text);
                        stream.WriteLine(EmailTextBox.Text);
                        stream.WriteLine(ConfirmedMonths.ToString());
                        stream.WriteLine(TotalCost.ToString("#.##"));
                    }

                    MessageBox.Show("New Member Added.");

                    ClearButton_Click(null, null);

                }

                catch
                {
                    MessageBox.Show("File does not exist. Please try again.");
                }
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear form data for next member info
            MembershipIDLabel.Text = "";
            JoinDayLabel.Text = "";
            FullNameTextBox.Text = "";
            TelephoneMaskedTextBox.Text = "";
            EmailTextBox.Text = "";
            TermTextBox.Text = "";
            ClientConfirmedTextBox.Text = "";

            //set Focus to Term text box for next member
            TermTextBox.Focus();

            //Re-enable Client Confirmed term text box for next member
            ClientConfirmedTextBox.Enabled = true;

            if ((SummaryGroupBox.Visible) || (SearchGroupBox.Visible))
                {
                    for (int i = 620; i > 380; i -= INCREMENT)
                    {
                        this.Size = new Size(FORMWIDTH, i);
                        this.Update();
                        System.Threading.Thread.Sleep(1);
                    }
                }

            //Hide the Summary and Search Group Boxes
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = false;
        }

        private void SearchByIDButton_Click(object sender, EventArgs e)
        {
            SearchResultsTextBox.Text = "";
            try
            {
                //search file based on user ID (exact match only)
                using (StreamReader stream = new StreamReader(PATHWAY))
                {
                    string Line = "";
                    int RecordLength = 7;
                    bool Success = false;

                    // Read and write lines from the file until end of file is reached
                    while ((Line = stream.ReadLine()) != null && Success == false)
                    {                        
                        if (Line == SearchTermTextBox.Text)
                        {
                            Success = true;
                            SearchResultsTextBox.Text += Line + Environment.NewLine;
                        }                        

                        for (int i = 0; i < RecordLength - 1; i++)
                        {
                            Line = stream.ReadLine();
                            if (Success)
                            {
                                SearchResultsTextBox.Text += Line + Environment.NewLine;                              

                            }                            

                        }
                    }
                    
                }

            }

            catch (Exception e1)
            {
                MessageBox.Show("File does not exist. Please try again." + e1.Message);
            }
    }

        private void SearchByDateButton_Click(object sender, EventArgs e)
        {
            SearchResultsTextBox.Text = "";
            try
            {
                //search file based on user ID (exact match only)
                using (StreamReader stream = new StreamReader(PATHWAY))
                {
                    string Line = "";
                    int RecordLength = 7;
                    bool Success = false;
                    string Result = "";

                    // Read and write lines from the file until end of file is reached
                    while ((Line = stream.ReadLine()) != null)
                    {
                        Result += Line + Environment.NewLine;
                        for (int i = 0; i < RecordLength - 1; i++)
                        {                            
                            Line = stream.ReadLine();
                            if (i == 0)
                            {
                                //Check if the dates match
                                if (Line == SearchTermTextBox.Text)
                                {
                                    Success = true;
                                }
                            }
                            if (Success)
                            {
                                Result += Line + Environment.NewLine;
                            }

                        }

                        if (Success)
                        {
                            SearchResultsTextBox.Text += Result;
                            Success = false;
                        }
                    }

                }

            }

            catch (Exception e1)
            {
                MessageBox.Show("Match does not exist. Please try again." + e1.Message);
            }
        }        

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            SearchGroupBox.Visible = false;
            SummaryGroupBox.Visible = true;

            for (int i = FORMSTARTHEIGHT; i < FORMEXPANDHEIGHT; i += INCREMENT)
            {
                this.Size = new Size(FORMWIDTH, i);
                this.Update();
                System.Threading.Thread.Sleep(1);
            }

            //Read info from text file
            //full list of membership IDs, the total amount of membership fees, 
            //the average membership term and the average membership fee
            MembershipIDsTextBox.Text = "";

            try
            {
                //open file as text file and append client details to end of text file
                using (StreamReader stream = new StreamReader(PATHWAY))
                {                    
                    string Line = "";                    
                    int TotalMonths = 0;
                    int NumberOfMembers = 0;
                    decimal TotalValue = 0; 
                    //int RecordLength = 0;

                    // Read and write lines from the file until end of file is reached
                    while ((Line = stream.ReadLine()) != null)
                    {
                        NumberOfMembers++;                         
                        MembershipIDsTextBox.Text += Line + Environment.NewLine;

                        for(int i = 0; i < 6; i++)
                        {
                            Line = stream.ReadLine();
                            if(i == 4)
                            {
                                //Console.WriteLine("4 " + Line);
                                TotalMonths += Int32.Parse(Line);
                                
                            }
                            if(i == 5)
                            {
                                TotalValue += Decimal.Parse(Line, NumberStyles.Currency);
                                
                            }

                        }
                    }
                    
                    TotalCostMembershipFeesLabelOutput.Text = TotalValue.ToString("C", Locality);
                    AverageMembershipTermLabelOutput.Text = (TotalMonths / NumberOfMembers).ToString();
                    AverageMembershipFeeLabelOutput.Text =  (TotalValue / NumberOfMembers).ToString("C", Locality);                    
                }
                
            }

            catch(Exception e1)
            {
                MessageBox.Show("File does not exist. Please try again." + e1.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = true;

            for (int i = FORMSTARTHEIGHT; i < FORMEXPANDHEIGHT; i += INCREMENT)
            {
                this.Size = new Size(FORMWIDTH, i);
                this.Update();
                System.Threading.Thread.Sleep(1);
            }           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }   
    }
}
