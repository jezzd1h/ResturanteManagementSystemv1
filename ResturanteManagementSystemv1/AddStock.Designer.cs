namespace ResturanteManagementSystemv1
{
    partial class AddStock
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
            this.EnterStockNameBox = new System.Windows.Forms.RichTextBox();
            this.EnterAmountBox = new System.Windows.Forms.RichTextBox();
            this.EnterMinimumLimitBox = new System.Windows.Forms.RichTextBox();
            this.SaveAndQuitButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.NewStock = new System.Windows.Forms.Button();
            this.EnterPricePerUnitBox = new System.Windows.Forms.RichTextBox();
            this.MeasurementUnitBox = new System.Windows.Forms.ComboBox();
            this.MessageBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // EnterStockNameBox
            // 
            this.EnterStockNameBox.Location = new System.Drawing.Point(173, 13);
            this.EnterStockNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnterStockNameBox.Name = "EnterStockNameBox";
            this.EnterStockNameBox.Size = new System.Drawing.Size(487, 62);
            this.EnterStockNameBox.TabIndex = 43;
            this.EnterStockNameBox.Text = "Enter stock name";
            // 
            // EnterAmountBox
            // 
            this.EnterAmountBox.Location = new System.Drawing.Point(173, 160);
            this.EnterAmountBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnterAmountBox.Name = "EnterAmountBox";
            this.EnterAmountBox.Size = new System.Drawing.Size(487, 62);
            this.EnterAmountBox.TabIndex = 42;
            this.EnterAmountBox.Text = "Enter Amount";
            // 
            // EnterMinimumLimitBox
            // 
            this.EnterMinimumLimitBox.Location = new System.Drawing.Point(173, 230);
            this.EnterMinimumLimitBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnterMinimumLimitBox.Name = "EnterMinimumLimitBox";
            this.EnterMinimumLimitBox.Size = new System.Drawing.Size(487, 62);
            this.EnterMinimumLimitBox.TabIndex = 41;
            this.EnterMinimumLimitBox.Text = "Enter Minimum limit";
            // 
            // SaveAndQuitButton
            // 
            this.SaveAndQuitButton.BackColor = System.Drawing.Color.White;
            this.SaveAndQuitButton.Location = new System.Drawing.Point(11, 160);
            this.SaveAndQuitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveAndQuitButton.Name = "SaveAndQuitButton";
            this.SaveAndQuitButton.Size = new System.Drawing.Size(155, 144);
            this.SaveAndQuitButton.TabIndex = 50;
            this.SaveAndQuitButton.Text = "Save and Quit ";
            this.SaveAndQuitButton.UseVisualStyleBackColor = false;
            this.SaveAndQuitButton.Click += new System.EventHandler(this.SaveAndQuitButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(11, 11);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(155, 144);
            this.HomeButton.TabIndex = 48;
            this.HomeButton.Text = "Home ";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // NewStock
            // 
            this.NewStock.BackColor = System.Drawing.Color.White;
            this.NewStock.Location = new System.Drawing.Point(11, 308);
            this.NewStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewStock.Name = "NewStock";
            this.NewStock.Size = new System.Drawing.Size(155, 144);
            this.NewStock.TabIndex = 51;
            this.NewStock.Text = "Add Stock";
            this.NewStock.UseVisualStyleBackColor = false;
            this.NewStock.Click += new System.EventHandler(this.NewStock_Click);
            // 
            // EnterPricePerUnitBox
            // 
            this.EnterPricePerUnitBox.Location = new System.Drawing.Point(174, 300);
            this.EnterPricePerUnitBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnterPricePerUnitBox.Name = "EnterPricePerUnitBox";
            this.EnterPricePerUnitBox.Size = new System.Drawing.Size(487, 62);
            this.EnterPricePerUnitBox.TabIndex = 53;
            this.EnterPricePerUnitBox.Text = "Enter Price Per Unit";
            // 
            // MeasurementUnitBox
            // 
            this.MeasurementUnitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeasurementUnitBox.FormattingEnabled = true;
            this.MeasurementUnitBox.Items.AddRange(new object[] {
            "Grams",
            "KG",
            "ML",
            "Litres",
            "Unit",
            "Cup",
            "Pounds ",
            "Table Spoons"});
            this.MeasurementUnitBox.Location = new System.Drawing.Point(173, 82);
            this.MeasurementUnitBox.Name = "MeasurementUnitBox";
            this.MeasurementUnitBox.Size = new System.Drawing.Size(487, 24);
            this.MeasurementUnitBox.TabIndex = 56;
            this.MeasurementUnitBox.Text = "Measurement unit";
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(173, 369);
            this.MessageBox.Margin = new System.Windows.Forms.Padding(4);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(487, 62);
            this.MessageBox.TabIndex = 59;
            this.MessageBox.Text = "";
            this.MessageBox.Visible = false;
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 467);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.MeasurementUnitBox);
            this.Controls.Add(this.EnterPricePerUnitBox);
            this.Controls.Add(this.NewStock);
            this.Controls.Add(this.SaveAndQuitButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.EnterStockNameBox);
            this.Controls.Add(this.EnterAmountBox);
            this.Controls.Add(this.EnterMinimumLimitBox);
            this.Name = "AddStock";
            this.Text = "AddStock";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox EnterStockNameBox;
        private System.Windows.Forms.RichTextBox EnterAmountBox;
        private System.Windows.Forms.RichTextBox EnterMinimumLimitBox;
        private System.Windows.Forms.Button SaveAndQuitButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button NewStock;
        private System.Windows.Forms.RichTextBox EnterPricePerUnitBox;
        private System.Windows.Forms.ComboBox MeasurementUnitBox;
        private System.Windows.Forms.RichTextBox MessageBox;
    }
}