namespace EPOSGroupAssignment
{
    partial class StockForm
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
            this.StockListBox = new System.Windows.Forms.ListBox();
            this.Size8Label = new System.Windows.Forms.Label();
            this.Size9Label = new System.Windows.Forms.Label();
            this.Size10Label = new System.Windows.Forms.Label();
            this.Size11Label = new System.Windows.Forms.Label();
            this.Size12Label = new System.Windows.Forms.Label();
            this.BlankLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StockListBox
            // 
            this.StockListBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.StockListBox.ForeColor = System.Drawing.Color.White;
            this.StockListBox.FormattingEnabled = true;
            this.StockListBox.ItemHeight = 20;
            this.StockListBox.Location = new System.Drawing.Point(68, 44);
            this.StockListBox.Name = "StockListBox";
            this.StockListBox.Size = new System.Drawing.Size(689, 444);
            this.StockListBox.TabIndex = 0;
            // 
            // Size8Label
            // 
            this.Size8Label.AutoSize = true;
            this.Size8Label.BackColor = System.Drawing.Color.RoyalBlue;
            this.Size8Label.ForeColor = System.Drawing.Color.White;
            this.Size8Label.Location = new System.Drawing.Point(189, 13);
            this.Size8Label.Name = "Size8Label";
            this.Size8Label.Size = new System.Drawing.Size(53, 20);
            this.Size8Label.TabIndex = 1;
            this.Size8Label.Text = "Size 8";
            // 
            // Size9Label
            // 
            this.Size9Label.AutoSize = true;
            this.Size9Label.BackColor = System.Drawing.Color.RoyalBlue;
            this.Size9Label.ForeColor = System.Drawing.Color.White;
            this.Size9Label.Location = new System.Drawing.Point(270, 13);
            this.Size9Label.Name = "Size9Label";
            this.Size9Label.Size = new System.Drawing.Size(53, 20);
            this.Size9Label.TabIndex = 2;
            this.Size9Label.Text = "Size 9";
            // 
            // Size10Label
            // 
            this.Size10Label.AutoSize = true;
            this.Size10Label.BackColor = System.Drawing.Color.RoyalBlue;
            this.Size10Label.ForeColor = System.Drawing.Color.White;
            this.Size10Label.Location = new System.Drawing.Point(344, 13);
            this.Size10Label.Name = "Size10Label";
            this.Size10Label.Size = new System.Drawing.Size(62, 20);
            this.Size10Label.TabIndex = 3;
            this.Size10Label.Text = "Size 10";
            // 
            // Size11Label
            // 
            this.Size11Label.AutoSize = true;
            this.Size11Label.BackColor = System.Drawing.Color.RoyalBlue;
            this.Size11Label.ForeColor = System.Drawing.Color.White;
            this.Size11Label.Location = new System.Drawing.Point(415, 13);
            this.Size11Label.Name = "Size11Label";
            this.Size11Label.Size = new System.Drawing.Size(62, 20);
            this.Size11Label.TabIndex = 4;
            this.Size11Label.Text = "Size 11";
            // 
            // Size12Label
            // 
            this.Size12Label.AutoSize = true;
            this.Size12Label.BackColor = System.Drawing.Color.RoyalBlue;
            this.Size12Label.ForeColor = System.Drawing.Color.White;
            this.Size12Label.Location = new System.Drawing.Point(495, 13);
            this.Size12Label.Name = "Size12Label";
            this.Size12Label.Size = new System.Drawing.Size(62, 20);
            this.Size12Label.TabIndex = 5;
            this.Size12Label.Text = "Size 12";
            // 
            // BlankLabel
            // 
            this.BlankLabel.AutoSize = true;
            this.BlankLabel.Location = new System.Drawing.Point(25, 501);
            this.BlankLabel.Name = "BlankLabel";
            this.BlankLabel.Size = new System.Drawing.Size(0, 20);
            this.BlankLabel.TabIndex = 6;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 550);
            this.Controls.Add(this.BlankLabel);
            this.Controls.Add(this.Size12Label);
            this.Controls.Add(this.Size11Label);
            this.Controls.Add(this.Size10Label);
            this.Controls.Add(this.Size9Label);
            this.Controls.Add(this.Size8Label);
            this.Controls.Add(this.StockListBox);
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StockListBox;
        private System.Windows.Forms.Label Size8Label;
        private System.Windows.Forms.Label Size9Label;
        private System.Windows.Forms.Label Size10Label;
        private System.Windows.Forms.Label Size11Label;
        private System.Windows.Forms.Label Size12Label;
        private System.Windows.Forms.Label BlankLabel;
    }
}