using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOSGroupAssignment
{
    // Arrays for shoe types, sizes, prices, and stock information
    public partial class Form1 : Form
    {
        static readonly string[] ShoeTypeArray =
             {"Jordans           ", "Dunks         ", "Sambas        ", "Crocs        ", "Yeezy        ", "Birkenstocks        ", "Rollerskates        ", "Vans        ", "Asics        ", "Tiempo        ", "Mercurial        ", "Copa        ", "Airmax        ",};
        static readonly string[] ShoeSizeArray =
            { "8", "9", "10", "11", "12"};
        static readonly decimal[] Price =
            {100m, 90m, 85m, 50m, 95m, 70m, 40m, 55m, 60m, 110m, 120m, 105m, 75m};
        decimal[,] ShoePrices = new decimal[13, 5]
        {
            { 100m, 110m, 120m, 130m, 140m},
            { 90m, 100m, 110m, 120m, 130m},
            { 85m, 95m, 105m, 115m, 125m},
            { 50m, 60m, 70m, 80m, 90m},
            { 95m, 105m, 115m, 125m, 135m},
            { 70m, 80m, 90m, 100m, 110m},
            { 40m, 50m, 60m, 70m, 80m},
            { 55m, 65m, 75m, 85m, 95m},
            { 60m, 70m, 80m, 90m, 100m},
            { 110m, 120m, 130m, 140m, 150m},
            { 120m, 130m, 140m, 150m, 160m},
            { 105m, 115m, 125m, 135m, 145m},
            { 75m, 85m, 95m, 105m, 115m}
        };
        int[,] StockArray = new int[13, 5]
        {
            { 0, 27, 30, 15, 16 },
            { 18, 24, 28, 21, 19 },
            { 25, 26, 27, 29, 20 },
            { 26, 27, 28, 29, 21 },
            { 27, 28, 29, 29, 21 },
            { 22, 21, 19, 20, 18 },
            { 20, 29, 21, 18, 19 },
            { 19, 28, 21, 18, 19 },
            { 21, 23, 24, 26, 30 },
            { 23, 24, 27, 27, 27 },
            { 24, 28, 26, 26, 23 },
            { 24, 27, 27, 27, 27 },
            { 22, 21, 17, 12, 22 }
        };
        // Variables to track total order price, selected shoe type and size, and transaction number
        decimal TotalOrderPrice;
        string ShoeType, ShoeSize;
        int TransactionNumber;
        // Properties to track total company transactions and sales amount
        public static int TotalCompanyTransactions { get; private set; } = 0;
        public static decimal TotalSalesAmountToDate { get; private set; }
        // Constants for file paths and date format
        const string STOCKFILE = "Stock.txt", ORDERFILE = "Orders.txt", DATE_FORMAT = "dd-MM-yyyy";

        // Method to clear selected indices in form elements
        private void ClearSelectedIndex()
        {
            ShoeListbox.SelectedIndex = -1;
            ShoeSizeListbox.SelectedIndex = -1;
        }


        

        public Form1()
        {
            InitializeComponent();
        }
        // Method to write stock information to a file using StreamWriter and handling exceptions with MessageBox
        public void WriteStockToFile(String StockFile, int[,] StockArray)
        {
            int Row = 0;
            int[] RecordRow = new int[StockArray.GetLength(1)];
            try
            {
                StreamWriter StockValue = File.CreateText(StockFile);

                for (Row = 0; Row < StockArray.GetLength(0); Row++)
                {
                    for (int col = 0; col < StockArray.GetLength(1); col++)
                    {
                        RecordRow[col] = StockArray[Row, col];
                    }
                    StockValue.WriteLine(String.Join(",", RecordRow));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // Event handler for close button click, closes the form and writes stock information to a file
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.WriteStockToFile(STOCKFILE, StockArray);
        }
        // Method to clear form elements including list boxes, labels, and group box visibility
        private void ClearForm()
        {
            ShoeListbox.SelectedIndex = -1;
            ShoeSizeListbox.SelectedIndex = -1;
            BasketListBox.Items.Clear();
            TotalCostLabel.Text = "";

            SearchResulstListBox.Items.Clear();
            TransactionNumberRadioButton.Checked = true;
            SearchOptionLabel.Text = "Please Enter a Transaction Number";
            SearchOrderGroupBox.Visible = false;
        }
       
        // Event handler for clear button click, calls the ClearForm method to clear form elements
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        // Event handler for transaction history search button click, searches transaction history based on user input

        private void TransactionHistorySearchButton_Click(object sender, EventArgs e)
        {
            decimal TotalSale;
            int Index = 0;

            if (SearchTextBox.Text != "")
            {
                SearchResulstListBox.Items.Clear();
                String Search = SearchTextBox.Text;

                try
                {
                    String[] InputFile = File.ReadAllLines(ORDERFILE);
                    do
                    {
                        Index = Array.IndexOf(InputFile, Search, Index);

                        if (Index != -1)
                        {
                            if (!TransactionNumberRadioButton.Checked)
                            {
                                Index--;
                            }
                            SearchResulstListBox.Items.Add("TX N0.: " + InputFile[Index]);
                            SearchResulstListBox.Items.Add("Date : " + InputFile[Index + 1]);
                            TotalSale = decimal.Parse(InputFile[Index + 2]);
                            Index += 3;
                            while (Index < InputFile.Length && !String.IsNullOrEmpty(InputFile[Index]))
                            {
                                SearchResulstListBox.Items.Add(InputFile[Index]);
                                Index++;
                            }
                            SearchResulstListBox.Items.Add("Total:\t\t" + String.Format("{0:C}", TotalSale));
                            SearchResulstListBox.Items.Add("~~~~~~~~~~~~~~~~~~~~~");
                            SearchResulstListBox.Items.Add("");

                            Index++;
                        }
                        else
                        {

                            if (SearchResulstListBox.Items.Count < 0)
                            {
                                SearchResulstListBox.Items.Add("There is no transaction matching these requirements");
                            }
                            break;
                        }





                    } while (!TransactionNumberRadioButton.Checked);


                }
                catch
                {

                    MessageBox.Show("Please ensure you have selected the correct search method", "There has been an error reading from file", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {

                MessageBox.Show("Please Enter a Transaction Number or Email", "No Input Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        // Event handler for transaction number radio button checked change, updates search option label and clears search result list box
        private void TransactionNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchOptionLabel.Text = "Please Enter Transaction Number";
            SearchResulstListBox.Items.Clear();
        }
        // Event handler for date radio button checked change, updates search option label and clears search result list box

        private void DateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchOptionLabel.Text = "Please Enter Date";
            SearchResulstListBox.Items.Clear();
        }
        // Event handler for search button click, makes the search order group box visible

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchOrderGroupBox.Visible = true;
        }
        // Method to read stock information from a file and populate the StockArray

        public void ReadStockFromFile(String StockFile, ref int[,] StockArray)
        {
            int Row = 0;
            string[] RecordRow, AllRecordRows;
            try
            {
                AllRecordRows = File.ReadAllLines(StockFile);
                for (Row = 0; Row < AllRecordRows.Length; Row++)
                {
                    RecordRow = AllRecordRows[Row].Split(',');

                    for (int col = 0; col < RecordRow.Length; col++)
                    {
                        StockArray[Row, col] = int.Parse(RecordRow[col]);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        // Event handler for stock button click, opens a new StockForm, loads stock information, and clears the form

        private void StockButton_Click(object sender, EventArgs e)
        {
            StockForm NewForm = new StockForm();

            NewForm.loadStock(ShoeTypeArray, ShoeSizeArray, StockArray);

            NewForm.ShowDialog();
            ClearForm();
        }
        // Event handler for summary button click, opens a new SummaryForm and clears the form

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            SummaryForm NewForm = new SummaryForm();
            NewForm.ShowDialog();
            ClearForm();
        }
        // Event handler for finish order button click, processes the order, generates a unique transaction number,
        // writes order details to file, updates total sales amount and transaction count, and clears form elements
        private void FinishOrderButton_Click(object sender, EventArgs e)
        {
            StreamWriter FileWriter;

            try
            {

                try
                {
                    Boolean UniqueNum = true;
                    {
                        StreamReader InputFile = File.OpenText(ORDERFILE);

                        do
                        {
                            
                            Random Generator = new Random();
                            TransactionNumber = Generator.Next(10000000, 99999999);

                            while (!InputFile.EndOfStream && UniqueNum)
                            {
                                if (TransactionNumber.Equals(InputFile.ReadLine()))
                                {
                                    UniqueNum = false;
                                }


                            }

                            InputFile.Close();

                        } while (!UniqueNum);
                    }

                    FileWriter = File.AppendText(ORDERFILE);
                    FileWriter.WriteLine(TransactionNumber.ToString());
                    FileWriter.WriteLine(DateTime.Today.ToString(DATE_FORMAT));
                    FileWriter.WriteLine(TotalOrderPrice);
                    
                    foreach (var Item in BasketListBox.Items)
                    {
                        FileWriter.WriteLine(Item.ToString());
                    }


                    FileWriter.WriteLine();
                    FileWriter.Close();


                    MessageBox.Show("This order has been saved to file. \n\nThe Total Price of this Order is €" + TotalOrderPrice + "\n\n The Transaction Number is " + TransactionNumber.ToString() + "\n\n The Date is " + DateTime.Today.ToString(DATE_FORMAT));




                    TotalCostLabel.Text = "";
                    TotalSalesAmountToDate += TotalOrderPrice;
                    TotalCompanyTransactions++;

                    BasketListBox.Items.Clear();
                    ClearSelectedIndex();


                    TotalOrderPrice = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Event handler for add to basket button click, adds selected shoe to the basket,
        // calculates total order price, updates stock information, and handles exceptions
        private void AddToBasketButton_Click(object sender, EventArgs e)
        {
            int ProductIndex = 0, ShoeSizeIndex = 0, StockIndex = 0;
            decimal ShoePrice, TotalShoePrice;
            try
            {
                if (ShoeListbox.SelectedIndex != -1 && ShoeSizeListbox.SelectedIndex != -1)
                {
                    this.ReadStockFromFile(STOCKFILE, ref StockArray);

                    ProductIndex = ShoeListbox.SelectedIndex;
                    ShoeSizeIndex = ShoeSizeListbox.SelectedIndex;

                    ShoeType = ShoeTypeArray[ProductIndex];
                    ShoePrice = Price[ProductIndex];
                    ShoeSize = ShoeSizeArray[ShoeSizeIndex];

                    StockIndex = StockArray[ProductIndex, ShoeSizeIndex];

                    if (StockIndex > 0)
                    {
                        TotalShoePrice = ShoePrices[ProductIndex, ShoeSizeIndex];
                        BasketListBox.Items.Add(ShoeType.ToString() + "\t" + TotalShoePrice.ToString("C"));

                        TotalOrderPrice += TotalShoePrice;


                        TotalCostLabel.Text = TotalOrderPrice.ToString("C");

                        FinishOrderButton.Enabled = true;
                        StockArray[ProductIndex, ShoeSizeIndex] -= 1;
                        this.WriteStockToFile(STOCKFILE, StockArray);
                        ClearSelectedIndex();



                    }
                    else
                    {
                        MessageBox.Show("Sorry, this Shoe is out of stock in this size.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearSelectedIndex();
                    }
                }
                else
                {

                    MessageBox.Show("Please Select a Shoe and it size", "No Input Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("An error occurred while processing your order. Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearSelectedIndex();
            }
        }
        // Event handler for form load, reads stock information from file and populates the StockArray
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ReadStockFromFile(STOCKFILE, ref StockArray);
            
        }
    }
}
