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
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }
        // Event handler for summary form load, displays total company transactions, total sales amount, and average transaction amount
        private void SummaryForm_Load(object sender, EventArgs e)
        {
            NumberOfTransactionsLabel.Text = Form1.TotalCompanyTransactions.ToString("N0");
            TotalSalesAmountLabel.Text = Form1.TotalSalesAmountToDate.ToString("c");
            AverageTransactionAmountLabel.Text = (Form1.TotalSalesAmountToDate / Form1.TotalCompanyTransactions).ToString("C");
        }
    }
}
