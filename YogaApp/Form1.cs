/* Student Name: Caitlin Hogan
 * Student ID: 20231704
 * Date: 25/01/2021
 * Assignment: 4
 * Assignment: Create an EPOS application for a business of your choice.
 */


using System;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Collections.Generic;


namespace yogi_ireland
{
    public partial class Form1 : Form 
    {
        //Array for the workshops
        public static string[] Workshops { get; set; } = { "Hatha", "Prenatal", "Vinyasa", "Bikram", "Iyengar", "Chakras",
                                                           "Aerial", "Jivamukti", "Partners" };
        
        //Array for the days
        public static int[] Days { get; set; } = { 5, 5, 4, 4, 4, 3, 3, 2, 1 };
        //Array for the workshop fees
        public static decimal[] Fees { get; set; } = { 1000m, 900m, 950m, 850m, 900m, 700m, 800m, 500m, 300m };
        // Array for the locations
        public static string[] Locations { get; set; } = { "Burren", "Clare", "Dingle", "Leitrim", "Louth", "Wicklow" };
        //Array for the lodging fees
        public static decimal[] LodgingFees { get; set; } = { 100m, 295m, 180m, 250m, 195m, 235m };

        const decimal TEACH_CERT_FEE = 100m;
        decimal CertCost = 0;

        // Creates a CultureInfo for Euro in Ireland
        private CultureInfo Locality = new CultureInfo("en-IE");        

        // order details file path
        const string ORDER_DETAILS = "C:\\Users\\caitl\\OneDrive\\Desktop\\Assignment 4\\Assignment 4\\Hogan_Caitlin_Assignment 4_MS806\\bin\\Debug\\OrderDetails.txt";

        //2D-Array for the Meal Prices based on customer meal and workshop selection
        public static string[] MealOptions { get; set; } = { "Vegan", "Veg", "Breakfast Only", "No Meal" };
        public static decimal[] MealCosts { get; set; } = { 10m, 8m, 5m, 0m };

        //use a list of arrays to store basket details
        List<int[]> Basket = new List<int[]> ();        

        //use a list of arrays to store sales (transaction) data
        List<string[]> SalesData = new List<string[]>();       

        //create int array store items from ItemBasket 
        List<int[]> AllTransactions { get; set; } = new List<int[]>();

        //2D-Array for the Places Available
        public static int[,] PlacesAvailable { get; set; } =  { { 25, 30, 15, 12, 22, 32}, 
                                                                { 10, 8, 8, 12, 15, 5}, 
                                                                { 20, 27, 32, 28, 15, 18}, 
                                                                { 40, 30, 20, 25, 25, 20}, 
                                                                { 40, 40, 40, 40, 40, 40}, 
                                                                { 30, 30, 30, 30, 30, 30}, 
                                                                { 8, 15, 12, 6, 4, 12}, 
                                                                { 22, 27, 16, 18, 14, 11}, 
                                                                { 4, 6, 8, 10, 10, 10} };

        //Array for live count of stock
        const int ROW_SIZE = 9, COLUMN_SIZE = 6;
        public static int[,] OpeningStock = new int[ROW_SIZE, COLUMN_SIZE];      
        
        //file reader and writer objects
        //StreamWriter OutputFile;
        StreamReader InputFile;

        //file names
        string DAILY_ITEM_SALES_FILE_NAME = "DailyItemSalesReport-" + System.DateTime.Today.ToString("yyyy-MM-dd") + ".txt";
        string CLOSING_STOCK_FILE_NAME = "ClosingStock.txt";
        string MGMT_REPORT_FILE_NAME = "MgmtReport-" + System.DateTime.Today.ToString("yyyy-MM-dd") + ".txt";   
                     
        
        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearButton_Click(sender, e);
            ManagementStockButton.Enabled = false;


            //Read Closing Stock of Yesterday; set as Opening Stock of Today
            if (File.Exists(CLOSING_STOCK_FILE_NAME))
            {
                try
                {
                    InputFile = File.OpenText(CLOSING_STOCK_FILE_NAME);

                    //Read File and Save to PlacesAvailable
                    for (int i = 0; i < Workshops.Length; i++)
                    {
                        for (int j = 0; j < Locations.Length; j++)
                        {
                            string Line = InputFile.ReadLine();

                            if (Line.IndexOf(":") >= 0)
                            {
                                Line = Line.Substring(Line.IndexOf(":") + 1);
                                OpeningStock[i, j] = int.Parse(Line);
                                PlacesAvailable[i, j] = int.Parse(Line);
                            }

                        }
                    }
                    InputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't read last Transaction day's file:" + ex.Message);
                }
            }

            //in case where there is no Closing Stock, the array PlacesAvailable is taken as Opening Stock
            else
            {
                for (int i = 0; i < Workshops.Length; i++)
                {
                    for (int j = 0; j < Locations.Length; j++)
                    {
                        OpeningStock[i, j] = PlacesAvailable[i, j];
                    }
                }
            }

        }


        private void DisplayButton_Click(object sender, EventArgs e)
        {
            int WorkshopIndex = WorkshopListBox.SelectedIndex;
            int LocationIndex = LocationListBox.SelectedIndex;
            int MealIndex = MealListBox.SelectedIndex;
            CertCost = 0;

            if (WorkshopListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a workshop.");
            }
            else if (LocationListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a location.");
            }

            else if (MealListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a meal plan.");
            }

            else if (NumPlaces.Value == 0)
            {
                MessageBox.Show("No. of Places should be more than 0.");
            }

            if (CertificateCheckBox.Checked)
            {
                CertCost = TEACH_CERT_FEE;
            }


            try
            {
                decimal TotalCost =   (Fees[WorkshopIndex] 
                                    + (Days[WorkshopIndex] * LodgingFees[LocationIndex]) 
                                    + (Days[WorkshopIndex] * MealCosts[MealIndex]) 
                                    + CertCost) 
                                    * NumPlaces.Value;

                CurrentCostValue.Text = TotalCost.ToString("C", Locality);

                int NumPlacesValue = Int32.Parse(NumPlaces.Value.ToString());
                decimal CurrentCost = Decimal.Parse(CurrentCostValue.Text.Remove(0, 1));

                if (NumPlaces.Value > 0)
                {
                    PricePerPersonLabel.Text = (CurrentCost / NumPlacesValue).ToString("C", Locality);
                }
            }

            catch (Exception e1)
            {
                PricePerPersonLabel.Text = "N/A";
                MessageBox.Show("Please ensure all selections are complete.");

            }

        }


        private void AddToBookingButton_Click(object sender, EventArgs e)
        {
            int WorkshopIndex = WorkshopListBox.SelectedIndex;
            int LocationIndex = LocationListBox.SelectedIndex;
            int MealIndex = MealListBox.SelectedIndex;


            if (WorkshopIndex == -1)
            {
                MessageBox.Show("You must select a workshop.");
            }
            else if (LocationIndex == -1)
            {
                MessageBox.Show("You must select a location.");
            }

            else if (MealIndex == -1)
            {
                MessageBox.Show("You must select a meal plan.");
            }

            else
            {
                //check that quantity is a number greater than 0
                int Quantity = 0;
                if (Int32.TryParse(NumPlaces.Text, out Quantity))
                {
                    if (Quantity > 0)
                    {
                        //check that you have enough places available to book
                        int available = PlacesAvailable[WorkshopIndex, LocationIndex];

                        //need to subtract quantity if item is already in the basket
                        for (int i = 0; i < Basket.Count; i++)
                        {
                            if (Basket[i][0] == WorkshopIndex && Basket[i][1] == LocationIndex)
                            {
                                available -= Basket[i][4];

                            }
                        }

                        if (Quantity > available)
                        {
                            MessageBox.Show("Not enough places available (" + available + ")");
                        }
                        else
                        {

                            //valid quant
                            string Certification = "Uncertified";
                            int CertificationValue = 0;
                            if (CertificateCheckBox.Checked)
                            {
                                Certification = "Certified   ";
                                CertificationValue = 1;
                            }
                            string Details = Workshops[WorkshopIndex] + "\t" + Locations[LocationIndex] + "\t" + 
                                             MealOptions[MealIndex] + "\t" + Certification + "\t" + Quantity;
                            ItemBasket.Items.Add(Details);
                            //MessageBox.Show(ItemBasket.Items.Count.ToString());


                            int[] ItemDetails = { WorkshopIndex, LocationIndex, MealIndex, CertificationValue, Quantity };
                            Basket.Add(ItemDetails);


                            CompleteOrderButton.Enabled = true;
                            CompleteOrderButton.Focus();

                            UpdateTotals();
                        }
                    }


                    //invalid quant for number of places
                    else
                    {
                        MessageBox.Show("Number of places needs to be greater than 0");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid number of places");
                }
            }
            NumPlaces.Value = 0;
            WorkshopListBox.Focus();
        }



        public void UpdateQuantity_Click(object sender, EventArgs e)
        {
            //allow user to update quantity of the selected basket item
            if (ItemBasket.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a basket item");
            }
            else
            {
                int NewQuantity = Int32.Parse(UpdateQuant.Value.ToString());
                if (NewQuantity < 0)
                {
                    MessageBox.Show("Quantity must be at least 0.");
                }
                else
                {
                    //if quantity is 0, remove the item
                    if (NewQuantity == 0)
                    {
                        //remove the item
                        Basket.RemoveAt(ItemBasket.SelectedIndex);
                        ItemBasket.Items.RemoveAt(ItemBasket.SelectedIndex);

                        //update total
                        UpdateTotals();
                    }
                    else
                    {
                        //check that you have enough places available to book
                        int available = PlacesAvailable[WorkshopListBox.SelectedIndex, LocationListBox.SelectedIndex];

                        //need to subtract quantity if item is already in the basket
                        for (int i = 0; i < Basket.Count; i++)
                        {
                            if ( i != ItemBasket.SelectedIndex && Basket[i][0] == WorkshopListBox.SelectedIndex && Basket[i][1] == LocationListBox.SelectedIndex)
                            {
                                available -= Basket[i][4];

                            }
                        }

                        if (NewQuantity > available)
                        {
                            MessageBox.Show("Sorry, there is/are only " + available + " place(s) left for the workshop chosen.");
                        }

                        else
                        {
                            string Certification = "Uncertified";
                            if (Basket[ItemBasket.SelectedIndex][3] == 1)
                            {
                                Certification = "Certified   ";
                            }
                            Basket[ItemBasket.SelectedIndex][4] = NewQuantity;
                            string Details = Workshops[Basket[ItemBasket.SelectedIndex][0]] + "\t" + Locations[Basket[ItemBasket.SelectedIndex][1]] +
                                "\t" + MealOptions[Basket[ItemBasket.SelectedIndex][2]] +
                                "\t" + Certification + "\t" + NewQuantity;
                            ItemBasket.Items[ItemBasket.SelectedIndex] = Details;
                            UpdateTotals();
                        }
                    }
                }
            }      
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //generate end-of-day reports

            //CLOSING_STOCK_FILE_NAME
            //if file does not exist, create it. 
            //Free unmanaged resources. Use method dispose() whenever there is a close() method -- see above         

            if (!File.Exists(CLOSING_STOCK_FILE_NAME))
            {
                File.CreateText(CLOSING_STOCK_FILE_NAME).Dispose();
            }

            try
            {
                //open file as text file and append client details to end of text file
                using (StreamWriter stream = new StreamWriter(CLOSING_STOCK_FILE_NAME))
                {  
                    for(int i = 0; i < Workshops.Length; i++)
                    {
                        for (int j = 0; j < Locations.Length; j++)
                        {
                            stream.WriteLine(Workshops[i] + ", " + Locations[j] + ":" + PlacesAvailable[i,j]);
                            
                        }
                    }

                }

            }

            catch (Exception e1)
            {
                MessageBox.Show("File does not exist. Please try again." + e1.Message);
            }


            
            //do similar process for DAILY_ITEM_SALES_FILE_NAME
            //if file does not exist, create it          

            if (!File.Exists(DAILY_ITEM_SALES_FILE_NAME))
            {
                File.CreateText(DAILY_ITEM_SALES_FILE_NAME).Dispose();
            }

            try
            {
                //open file as text file and append client details to end of text file
                using (StreamWriter stream = new StreamWriter(DAILY_ITEM_SALES_FILE_NAME, true))
                {

                    string DateInfo = "********* " + DateTime.Now.ToString("yyyy-MM-dd hh:mm") + " *********";
                    stream.WriteLine(DateInfo);

                    string Line = "Workshop, ";
                    for (int j = 0; j < Locations.Length; j++)
                    {
                        Line += Locations[j] + ", ";
                    }

                    stream.WriteLine(Line);

                    for (int i = 0; i < Workshops.Length; i++)
                    {
                        Line = Workshops[i] + ':';

                        for (int j = 0; j < Locations.Length; j++)
                        {
                            // (Fees[i] + (Days[i] * LodgingFees[j])) is the fee amount for the given selection
                            // OpeningStock[i,j] - PlacesAvailable[i,j] is the amount of selected item combo sold in one 'session'
                            // Hence, Cost gives the total cost of each item combo booked in current day
                            decimal Cost = (Fees[i] + (Days[i] * LodgingFees[j])) * (OpeningStock[i,j] - PlacesAvailable[i,j]);

                            //display how many places were available as opening stock, how many are currently available, and total sales of each item combo in one session
                            Line += OpeningStock[i, j].ToString() + "/" + PlacesAvailable[i, j] + "/" + Cost.ToString() + ',';                            

                        }

                        stream.WriteLine(Line);
                    }

                    //work out costs of meals and certificates
                    stream.WriteLine("Meal Costs");
                    int CertsCount = 0;
                    for (int i = 0; i < MealOptions.Length; i++)
                    {
                        int MealsCount = 0;
                        
                        for (int j = 0; j < AllTransactions.Count; j++)
                        {
                            if (AllTransactions[j][2] == i)
                            {
                                MealsCount += AllTransactions[j][4]; 
                            }
                            if (i == 0 && AllTransactions[j][3] == 1)
                            {
                                //make sure cert counts are only counted once
                                CertsCount += AllTransactions[j][4];
                            }
                            
                        }
                        Line = MealOptions[i] + " at " + MealCosts[i] + ", Qty " + MealsCount.ToString() + ", Total " + (MealsCount * MealCosts[i]).ToString();
                        stream.WriteLine(Line);
                    }
                    stream.WriteLine("Cert Costs");
                    Line = TEACH_CERT_FEE.ToString() + ", Qty " + CertsCount.ToString() + ", Total " + (CertsCount * TEACH_CERT_FEE).ToString();
                    stream.WriteLine(Line);
                }

            }

            catch (Exception e1)
            {
                MessageBox.Show("File does not exist. Please try again." + e1.Message);
            }          

        }

                

        private void SearchByDateButton_Click(object sender, EventArgs e)
        {
            SearchResultsTB.Text = "";
            string SearchTerm = SearchTermTextBox.Text;
            bool Result = false; 
            foreach (string[] t in SalesData)
            {
                if (t[1] == SearchTerm)
                {
                    SearchResultsTB.AppendText(t[0] + Environment.NewLine);
                    SearchResultsTB.AppendText(t[1] + Environment.NewLine);
                    SearchResultsTB.AppendText(t[2].Replace("\t", " ") + Environment.NewLine);

                    SearchResultsTB.AppendText(Environment.NewLine);
                    Result = true;
                }
            }

            if(Result == false)
            {
                MessageBox.Show("Result not found. Please try again.");
            }
            
        }

        private void SearchByIDButton_Click(object sender, EventArgs e)
        {
            SearchResultsTB.Text = "";
            string SearchTerm = SearchTermTextBox.Text;
            bool Result = false;
            foreach (string[] t in SalesData)
            {
                if (t[0] == SearchTerm)
                {
                    SearchResultsTB.AppendText(t[0] + Environment.NewLine);
                    SearchResultsTB.AppendText(t[1] + Environment.NewLine);
                    SearchResultsTB.AppendText(t[2].Replace("\t", " ") + Environment.NewLine);
                    Result = true;
                }
            }

            if (Result == false)
            {
                MessageBox.Show("Result not found. Please try again.");
            }
           
        }

        Form2 SecondForm = new Form2();

        private void ManagementStockButton_Click(object sender, EventArgs e)
        {
            SecondForm.Show();

            SecondForm.MgmtListBox.Items.Clear();

            //loop through locations and workshops to display stock for each combination
            string Line = " \t";
            for (int j = 0; j < Locations.Length; j++)
            {
                Line += Locations[j] + '\t';
            }
            SecondForm.MgmtListBox.Items.Add(Line);
            for (int i = 0; i < Workshops.Length ; i++)
            {
                Line = Workshops[i]+ '\t';

                for (int j = 0; j < Locations.Length; j++)
                {
                    Line += OpeningStock[i, j].ToString() + "/" + PlacesAvailable[i,j] + '\t';           
                    
                }

                SecondForm.MgmtListBox.Items.Add(Line);
            }                
                       
            ClearButton.Focus();
            
        }
               
        
        private void UpdateTotals()
        {
            //calculate and display basket totals
            decimal TotalCost = 0;
            int TotalPlaces = 0;
            for (int i = 0; i < Basket.Count; i++)
            {
                TotalCost +=    (Fees[Basket[i][0]] 
                             +  (Days[Basket[i][0]] * LodgingFees[Basket[i][1]]) 
                             +  (Days[Basket[i][0]] * MealCosts[Basket[i][2]]) 
                             +  (TEACH_CERT_FEE * Basket[i][3])) 
                             *  Basket[i][4];

                TotalPlaces += Basket[i][4];

            }
            LabelTotalSalesOrder.Text = TotalCost.ToString("C", Locality);
            LabelTotalPlaces.Text = TotalPlaces.ToString();

        }

        //public void UpdateListBox(string lstValue)
        //{
        //    ItemBasket.Items.Add(lstValue);
        //}

        private void Form2_Load(object sender, EventArgs e)
        {
            ClearButton_Click(sender, e);
            ManagementStockButton.Enabled = false;
        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            //ask user if details can be confirmed
            string Details = "";

            for (int i = 0; i < Basket.Count; i++)
            {
                string Certification = "";
                
                if (Basket[i][3] == 1)
                {
                    Certification = "Certified   ";                    
                }

                decimal TotalCost = (Fees[WorkshopListBox.SelectedIndex] +
                        (Days[WorkshopListBox.SelectedIndex] * LodgingFees[LocationListBox.SelectedIndex]) +
                        (Days[WorkshopListBox.SelectedIndex] * MealCosts[MealListBox.SelectedIndex]) +
                        CertCost) * NumPlaces.Value;
                                               
                //update details of each booking
                Details += Workshops[Basket[i][0]] + " in \t" + Locations[Basket[i][1]] + ", \t" + MealOptions[Basket[i][2]] + 
                    ", \t" + Certification + ", \t " + Basket[i][4] + " place(s), \n Total Price: €" + 
                    (Fees[Basket[i][0]] + (Days[Basket[i][0]] * LodgingFees[Basket[i][1]]) + (TEACH_CERT_FEE * Basket[i][3])
                    + (Days[Basket[i][0]] * MealCosts[Basket[i][2]])) * Basket[i][4] + "\n";                
            }

            //print out details of each booking to a message box before confirming order
            var result = MessageBox.Show("Order Details: " + "\t" + Details + "\n\n Total Cost of Sales Order: " + LabelTotalSalesOrder.Text + 
                " \n\n Do you wish to proceed ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);            


            if (result == DialogResult.Yes)
            {
                //confirm and save details
                int TransactionID = 123456;
                
                //generate random transaction ID value that is 6 characters long
                //integer generated is between 100000 and 999999                
                Random R = new Random(DateTime.Now.Millisecond);
                TransactionID = R.Next(100000, 999999);

                // Check if NewID is duplicate                                  
                while (CheckDuplicates(TransactionID) == true)
                {
                    R = new Random(DateTime.Now.Millisecond);
                    TransactionID = R.Next(100000, 999999);
                }                

                //get today's date       
                string OrderDate = DateTime.Now.ToString("yyyy-MM-dd");

                string[] T = { TransactionID.ToString(), OrderDate, Details };                               

                //add data to the AllTransactions list
                for (int i = 0; i < Basket.Count; i++)
                {
                    string Certification = "";
                    if (Basket[i][3] == 1)
                    {
                        Certification = "Certified   ";
                    }

                    //TransDetails += Workshops[Basket[i][0]] + "\t" + Locations[Basket[i][1]] + "\t" + MealOptions[Basket[i][2]] + 
                        //"\t" + Certification + "\t" + Basket[i][4] + '\n';

                    //adjust quantity available
                    PlacesAvailable[Basket[i][0], Basket[i][1]] -= Basket[i][4];
                    AllTransactions.Add(Basket[i]);
                }

                // we use the SalesData list to save sales info in memory so we may search
                SalesData.Add(T);                             

                MessageBox.Show("Order " + TransactionID + " Date " + OrderDate);

                //clear basket
                ClearButton_Click(sender, e);
                 
                ManagementStockButton.Enabled = true;
               }
        }


        private bool CheckDuplicates(int NewID)
        {
            try
            {
                //open file as text file and append client details to end of text file
                using (StreamReader stream = new StreamReader(ORDER_DETAILS))
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
                      
        private void ClearButton_Click(object sender, EventArgs e)
        {
            WorkshopListBox.SelectedIndex = -1;
            LocationListBox.SelectedIndex = -1;
            MealListBox.SelectedIndex = -1;
            CertificateCheckBox.Checked = false;
            
            CompleteOrderButton.Enabled = false;
            //DisplayButton.Enabled = true;
            Basket.Clear();
            ItemBasket.Items.Clear();
            UpdateQuant.Value = 0; 
            LabelTotalPlaces.Text = "";
            LabelTotalSalesOrder.Text = ""; 
        }     
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }  
    }

}