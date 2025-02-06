using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOSGroupAssignment
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }
        // Method to load stock information into the StockForm ListBox
        public void loadStock(String[] StockItems, String[] Sizes, int[,] StockLevels)
        {
            int row = 0;
            String StockItem;

            try
            {
                BlankLabel.Text = "";

                for (int col = 0; col < StockLevels.GetLength(1); col++)
                {
                    BlankLabel.Text += Sizes[col] + "\t";
                }


                StockListBox.Items.Clear();
                for (row = 0; row < StockLevels.GetLength(0); row++)
                {
                    StockItem = StockItems[row];

                    for (int col = 0; col < StockLevels.GetLength(1); col++)
                    {
                        StockItem += "\t" + StockLevels[row, col].ToString();
                    }
                    StockListBox.Items.Add(StockItem);

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void StockForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}
