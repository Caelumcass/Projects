namespace EPOSGroupAssignment
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
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BasketListBox = new System.Windows.Forms.ListBox();
            this.AddToBasketButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StockButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FinishOrderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ShoeSizeListbox = new System.Windows.Forms.ListBox();
            this.ShoeListbox = new System.Windows.Forms.ListBox();
            this.SearchOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchResulstListBox = new System.Windows.Forms.ListBox();
            this.SearchOptionLabel = new System.Windows.Forms.Label();
            this.TransactionHistorySearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DateRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.TransactionNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.DateTextLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SearchOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPriceLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TotalPriceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalPriceLabel.Location = new System.Drawing.Point(137, 529);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(0, 0);
            this.TotalPriceLabel.TabIndex = 47;
            this.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(37, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 0);
            this.label3.TabIndex = 46;
            this.label3.Text = "Total: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BasketListBox
            // 
            this.BasketListBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.BasketListBox.ForeColor = System.Drawing.Color.White;
            this.BasketListBox.FormattingEnabled = true;
            this.BasketListBox.ItemHeight = 20;
            this.BasketListBox.Location = new System.Drawing.Point(12, 255);
            this.BasketListBox.Name = "BasketListBox";
            this.BasketListBox.Size = new System.Drawing.Size(216, 284);
            this.BasketListBox.TabIndex = 45;
            // 
            // AddToBasketButton
            // 
            this.AddToBasketButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddToBasketButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddToBasketButton.Location = new System.Drawing.Point(565, 227);
            this.AddToBasketButton.Name = "AddToBasketButton";
            this.AddToBasketButton.Size = new System.Drawing.Size(125, 48);
            this.AddToBasketButton.TabIndex = 43;
            this.AddToBasketButton.Text = "&Add to Basket";
            this.AddToBasketButton.UseVisualStyleBackColor = false;
            this.AddToBasketButton.Click += new System.EventHandler(this.AddToBasketButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(560, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Shoe Size ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(285, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Price";
            // 
            // StockButton
            // 
            this.StockButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.StockButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StockButton.Location = new System.Drawing.Point(268, 445);
            this.StockButton.Margin = new System.Windows.Forms.Padding(4);
            this.StockButton.Name = "StockButton";
            this.StockButton.Size = new System.Drawing.Size(100, 40);
            this.StockButton.TabIndex = 40;
            this.StockButton.Text = "S&tock";
            this.StockButton.UseVisualStyleBackColor = false;
            this.StockButton.Click += new System.EventHandler(this.StockButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SearchButton.Location = new System.Drawing.Point(449, 445);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 40);
            this.SearchButton.TabIndex = 39;
            this.SearchButton.Text = "&Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FinishOrderButton
            // 
            this.FinishOrderButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.FinishOrderButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FinishOrderButton.Location = new System.Drawing.Point(268, 493);
            this.FinishOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.FinishOrderButton.Name = "FinishOrderButton";
            this.FinishOrderButton.Size = new System.Drawing.Size(100, 40);
            this.FinishOrderButton.TabIndex = 38;
            this.FinishOrderButton.Text = "&Finish Order";
            this.FinishOrderButton.UseVisualStyleBackColor = false;
            this.FinishOrderButton.Click += new System.EventHandler(this.FinishOrderButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EPOSGroupAssignment.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 210);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(449, 541);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 40);
            this.CloseButton.TabIndex = 36;
            this.CloseButton.Text = "C&lose";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearButton.Location = new System.Drawing.Point(268, 541);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 40);
            this.ClearButton.TabIndex = 35;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SummaryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SummaryButton.Location = new System.Drawing.Point(449, 493);
            this.SummaryButton.Margin = new System.Windows.Forms.Padding(4);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(100, 40);
            this.SummaryButton.TabIndex = 34;
            this.SummaryButton.Text = "&Summary";
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ShoeSizeListbox
            // 
            this.ShoeSizeListbox.BackColor = System.Drawing.Color.RoyalBlue;
            this.ShoeSizeListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoeSizeListbox.ForeColor = System.Drawing.Color.White;
            this.ShoeSizeListbox.FormattingEnabled = true;
            this.ShoeSizeListbox.ItemHeight = 25;
            this.ShoeSizeListbox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.ShoeSizeListbox.Location = new System.Drawing.Point(565, 84);
            this.ShoeSizeListbox.Name = "ShoeSizeListbox";
            this.ShoeSizeListbox.Size = new System.Drawing.Size(125, 129);
            this.ShoeSizeListbox.TabIndex = 33;
            // 
            // ShoeListbox
            // 
            this.ShoeListbox.BackColor = System.Drawing.Color.RoyalBlue;
            this.ShoeListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoeListbox.ForeColor = System.Drawing.Color.White;
            this.ShoeListbox.FormattingEnabled = true;
            this.ShoeListbox.ItemHeight = 25;
            this.ShoeListbox.Items.AddRange(new object[] {
            "Jordans\t\t100",
            "Dunks\t\t90        ",
            "Sambas  \t\t85",
            "Crocs\t\t50",
            "Yeezy\t\t95",
            "Birkenstocks \t70",
            "Rollerskates\t40",
            "Vans\t\t55\t",
            "Asics\t\t60",
            "Tiempo\t\t110",
            "Mercurial\t\t120",
            "Copa\t\t105",
            "AirMax\t\t75"});
            this.ShoeListbox.Location = new System.Drawing.Point(268, 84);
            this.ShoeListbox.Name = "ShoeListbox";
            this.ShoeListbox.Size = new System.Drawing.Size(281, 354);
            this.ShoeListbox.TabIndex = 32;
            // 
            // SearchOrderGroupBox
            // 
            this.SearchOrderGroupBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchOrderGroupBox.Controls.Add(this.SearchResulstListBox);
            this.SearchOrderGroupBox.Controls.Add(this.SearchOptionLabel);
            this.SearchOrderGroupBox.Controls.Add(this.TransactionHistorySearchButton);
            this.SearchOrderGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchOrderGroupBox.Controls.Add(this.DateRadioButton);
            this.SearchOrderGroupBox.Controls.Add(this.SearchByLabel);
            this.SearchOrderGroupBox.Controls.Add(this.TransactionNumberRadioButton);
            this.SearchOrderGroupBox.Controls.Add(this.DateTextLabel);
            this.SearchOrderGroupBox.ForeColor = System.Drawing.Color.White;
            this.SearchOrderGroupBox.Location = new System.Drawing.Point(766, 45);
            this.SearchOrderGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchOrderGroupBox.Name = "SearchOrderGroupBox";
            this.SearchOrderGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchOrderGroupBox.Size = new System.Drawing.Size(420, 494);
            this.SearchOrderGroupBox.TabIndex = 48;
            this.SearchOrderGroupBox.TabStop = false;
            this.SearchOrderGroupBox.Text = "Search";
            this.SearchOrderGroupBox.Visible = false;
            // 
            // SearchResulstListBox
            // 
            this.SearchResulstListBox.FormattingEnabled = true;
            this.SearchResulstListBox.ItemHeight = 20;
            this.SearchResulstListBox.Location = new System.Drawing.Point(14, 252);
            this.SearchResulstListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchResulstListBox.Name = "SearchResulstListBox";
            this.SearchResulstListBox.Size = new System.Drawing.Size(390, 224);
            this.SearchResulstListBox.TabIndex = 13;
            // 
            // SearchOptionLabel
            // 
            this.SearchOptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOptionLabel.Location = new System.Drawing.Point(9, 154);
            this.SearchOptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchOptionLabel.Name = "SearchOptionLabel";
            this.SearchOptionLabel.Size = new System.Drawing.Size(381, 25);
            this.SearchOptionLabel.TabIndex = 4;
            this.SearchOptionLabel.Text = "Search";
            // 
            // TransactionHistorySearchButton
            // 
            this.TransactionHistorySearchButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.TransactionHistorySearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionHistorySearchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TransactionHistorySearchButton.Location = new System.Drawing.Point(273, 178);
            this.TransactionHistorySearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransactionHistorySearchButton.Name = "TransactionHistorySearchButton";
            this.TransactionHistorySearchButton.Size = new System.Drawing.Size(117, 36);
            this.TransactionHistorySearchButton.TabIndex = 10;
            this.TransactionHistorySearchButton.Text = "S&earch";
            this.TransactionHistorySearchButton.UseVisualStyleBackColor = false;
            this.TransactionHistorySearchButton.Click += new System.EventHandler(this.TransactionHistorySearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(14, 184);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(240, 26);
            this.SearchTextBox.TabIndex = 15;
            // 
            // DateRadioButton
            // 
            this.DateRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRadioButton.Location = new System.Drawing.Point(14, 99);
            this.DateRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateRadioButton.Name = "DateRadioButton";
            this.DateRadioButton.Size = new System.Drawing.Size(285, 30);
            this.DateRadioButton.TabIndex = 17;
            this.DateRadioButton.Text = "Date (dd-MM-yyyy)";
            this.DateRadioButton.UseVisualStyleBackColor = true;
            this.DateRadioButton.CheckedChanged += new System.EventHandler(this.DateRadioButton_CheckedChanged);
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByLabel.Location = new System.Drawing.Point(10, 36);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(86, 20);
            this.SearchByLabel.TabIndex = 18;
            this.SearchByLabel.Text = "Search By:";
            // 
            // TransactionNumberRadioButton
            // 
            this.TransactionNumberRadioButton.Checked = true;
            this.TransactionNumberRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionNumberRadioButton.Location = new System.Drawing.Point(14, 60);
            this.TransactionNumberRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransactionNumberRadioButton.Name = "TransactionNumberRadioButton";
            this.TransactionNumberRadioButton.Size = new System.Drawing.Size(196, 30);
            this.TransactionNumberRadioButton.TabIndex = 16;
            this.TransactionNumberRadioButton.TabStop = true;
            this.TransactionNumberRadioButton.Text = "Transaction Number";
            this.TransactionNumberRadioButton.UseVisualStyleBackColor = true;
            this.TransactionNumberRadioButton.CheckedChanged += new System.EventHandler(this.TransactionNumberRadioButton_CheckedChanged);
            // 
            // DateTextLabel
            // 
            this.DateTextLabel.AutoSize = true;
            this.DateTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextLabel.Location = new System.Drawing.Point(9, 128);
            this.DateTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTextLabel.Name = "DateTextLabel";
            this.DateTextLabel.Size = new System.Drawing.Size(0, 25);
            this.DateTextLabel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(22, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Total Cost";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TotalCostLabel.ForeColor = System.Drawing.Color.White;
            this.TotalCostLabel.Location = new System.Drawing.Point(127, 503);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalCostLabel.TabIndex = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 636);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchOrderGroupBox);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BasketListBox);
            this.Controls.Add(this.AddToBasketButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.FinishOrderButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.ShoeSizeListbox);
            this.Controls.Add(this.ShoeListbox);
            this.Name = "Form1";
            this.Text = "LifeStyleSportsEPOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SearchOrderGroupBox.ResumeLayout(false);
            this.SearchOrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox BasketListBox;
        private System.Windows.Forms.Button AddToBasketButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StockButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button FinishOrderButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.ListBox ShoeSizeListbox;
        private System.Windows.Forms.ListBox ShoeListbox;
        private System.Windows.Forms.GroupBox SearchOrderGroupBox;
        private System.Windows.Forms.ListBox SearchResulstListBox;
        private System.Windows.Forms.Label SearchOptionLabel;
        private System.Windows.Forms.Button TransactionHistorySearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.RadioButton DateRadioButton;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.RadioButton TransactionNumberRadioButton;
        private System.Windows.Forms.Label DateTextLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalCostLabel;
    }
}

