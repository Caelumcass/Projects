namespace EPOSGroupAssignment
{
    partial class SummaryForm
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
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.AverageTransactionAmountLabel = new System.Windows.Forms.Label();
            this.TotalSalesAmountLabel = new System.Windows.Forms.Label();
            this.NumberOfTransactionsLabel = new System.Windows.Forms.Label();
            this.AverageTransactionTextLabel = new System.Windows.Forms.Label();
            this.TotalSalesTextLabel = new System.Windows.Forms.Label();
            this.NumberOfTransactionsTextLabel = new System.Windows.Forms.Label();
            this.SummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.BackColor = System.Drawing.Color.White;
            this.SummaryGroupBox.Controls.Add(this.AverageTransactionAmountLabel);
            this.SummaryGroupBox.Controls.Add(this.TotalSalesAmountLabel);
            this.SummaryGroupBox.Controls.Add(this.NumberOfTransactionsLabel);
            this.SummaryGroupBox.Controls.Add(this.AverageTransactionTextLabel);
            this.SummaryGroupBox.Controls.Add(this.TotalSalesTextLabel);
            this.SummaryGroupBox.Controls.Add(this.NumberOfTransactionsTextLabel);
            this.SummaryGroupBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SummaryGroupBox.Location = new System.Drawing.Point(130, 96);
            this.SummaryGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SummaryGroupBox.Size = new System.Drawing.Size(541, 258);
            this.SummaryGroupBox.TabIndex = 1;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Company Summary";
            // 
            // AverageTransactionAmountLabel
            // 
            this.AverageTransactionAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AverageTransactionAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageTransactionAmountLabel.Location = new System.Drawing.Point(313, 184);
            this.AverageTransactionAmountLabel.Name = "AverageTransactionAmountLabel";
            this.AverageTransactionAmountLabel.Size = new System.Drawing.Size(202, 28);
            this.AverageTransactionAmountLabel.TabIndex = 5;
            // 
            // TotalSalesAmountLabel
            // 
            this.TotalSalesAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalSalesAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesAmountLabel.Location = new System.Drawing.Point(313, 121);
            this.TotalSalesAmountLabel.Name = "TotalSalesAmountLabel";
            this.TotalSalesAmountLabel.Size = new System.Drawing.Size(202, 27);
            this.TotalSalesAmountLabel.TabIndex = 4;
            // 
            // NumberOfTransactionsLabel
            // 
            this.NumberOfTransactionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberOfTransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfTransactionsLabel.Location = new System.Drawing.Point(313, 59);
            this.NumberOfTransactionsLabel.Name = "NumberOfTransactionsLabel";
            this.NumberOfTransactionsLabel.Size = new System.Drawing.Size(202, 28);
            this.NumberOfTransactionsLabel.TabIndex = 3;
            // 
            // AverageTransactionTextLabel
            // 
            this.AverageTransactionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageTransactionTextLabel.Location = new System.Drawing.Point(22, 184);
            this.AverageTransactionTextLabel.Name = "AverageTransactionTextLabel";
            this.AverageTransactionTextLabel.Size = new System.Drawing.Size(236, 29);
            this.AverageTransactionTextLabel.TabIndex = 2;
            this.AverageTransactionTextLabel.Text = "Average Transaction Amount\r\n\r\n";
            // 
            // TotalSalesTextLabel
            // 
            this.TotalSalesTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesTextLabel.Location = new System.Drawing.Point(22, 120);
            this.TotalSalesTextLabel.Name = "TotalSalesTextLabel";
            this.TotalSalesTextLabel.Size = new System.Drawing.Size(236, 29);
            this.TotalSalesTextLabel.TabIndex = 1;
            this.TotalSalesTextLabel.Text = "Total Sales";
            // 
            // NumberOfTransactionsTextLabel
            // 
            this.NumberOfTransactionsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfTransactionsTextLabel.Location = new System.Drawing.Point(22, 59);
            this.NumberOfTransactionsTextLabel.Name = "NumberOfTransactionsTextLabel";
            this.NumberOfTransactionsTextLabel.Size = new System.Drawing.Size(236, 29);
            this.NumberOfTransactionsTextLabel.TabIndex = 0;
            this.NumberOfTransactionsTextLabel.Text = "Number Of Transactions";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SummaryGroupBox);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.SummaryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.Label AverageTransactionAmountLabel;
        private System.Windows.Forms.Label TotalSalesAmountLabel;
        private System.Windows.Forms.Label NumberOfTransactionsLabel;
        private System.Windows.Forms.Label AverageTransactionTextLabel;
        private System.Windows.Forms.Label TotalSalesTextLabel;
        private System.Windows.Forms.Label NumberOfTransactionsTextLabel;
    }
}