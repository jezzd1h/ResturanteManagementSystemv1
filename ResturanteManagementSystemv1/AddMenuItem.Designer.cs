namespace ResturanteManagementSystemv1
{
    partial class AddMenuItem
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
            this.AddItem = new System.Windows.Forms.Button();
            this.SaveAndQuitButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.NextStock = new System.Windows.Forms.Button();
            this.EnterItemNameBox = new System.Windows.Forms.RichTextBox();
            this.StockBox = new System.Windows.Forms.ComboBox();
            this.StockAmountBox = new System.Windows.Forms.RichTextBox();
            this.MessageBox = new System.Windows.Forms.RichTextBox();
            this.CatagoryBox = new System.Windows.Forms.ComboBox();
            this.PriceBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.Color.White;
            this.AddItem.Location = new System.Drawing.Point(17, 459);
            this.AddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(155, 144);
            this.AddItem.TabIndex = 39;
            this.AddItem.Text = "Add item";
            this.AddItem.UseVisualStyleBackColor = false;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // SaveAndQuitButton
            // 
            this.SaveAndQuitButton.BackColor = System.Drawing.Color.White;
            this.SaveAndQuitButton.Location = new System.Drawing.Point(17, 161);
            this.SaveAndQuitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveAndQuitButton.Name = "SaveAndQuitButton";
            this.SaveAndQuitButton.Size = new System.Drawing.Size(155, 144);
            this.SaveAndQuitButton.TabIndex = 51;
            this.SaveAndQuitButton.Text = "Save and Quit ";
            this.SaveAndQuitButton.UseVisualStyleBackColor = false;
            this.SaveAndQuitButton.Click += new System.EventHandler(this.SaveAndQuitButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(17, 11);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(155, 144);
            this.HomeButton.TabIndex = 49;
            this.HomeButton.Text = "Home ";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // NextStock
            // 
            this.NextStock.BackColor = System.Drawing.Color.White;
            this.NextStock.Location = new System.Drawing.Point(17, 309);
            this.NextStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextStock.Name = "NextStock";
            this.NextStock.Size = new System.Drawing.Size(155, 144);
            this.NextStock.TabIndex = 53;
            this.NextStock.Text = "Next stock in menu item";
            this.NextStock.UseVisualStyleBackColor = false;
            this.NextStock.Click += new System.EventHandler(this.NextStock_Click);
            // 
            // EnterItemNameBox
            // 
            this.EnterItemNameBox.Location = new System.Drawing.Point(178, 13);
            this.EnterItemNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnterItemNameBox.Name = "EnterItemNameBox";
            this.EnterItemNameBox.Size = new System.Drawing.Size(487, 62);
            this.EnterItemNameBox.TabIndex = 55;
            this.EnterItemNameBox.Text = "Enter item name";
            // 
            // StockBox
            // 
            this.StockBox.FormattingEnabled = true;
            this.StockBox.Location = new System.Drawing.Point(178, 82);
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(487, 24);
            this.StockBox.TabIndex = 58;
            this.StockBox.Text = "Add Item ";
            // 
            // StockAmountBox
            // 
            this.StockAmountBox.Location = new System.Drawing.Point(179, 161);
            this.StockAmountBox.Margin = new System.Windows.Forms.Padding(4);
            this.StockAmountBox.Name = "StockAmountBox";
            this.StockAmountBox.Size = new System.Drawing.Size(487, 62);
            this.StockAmountBox.TabIndex = 59;
            this.StockAmountBox.Text = "Enter amount of stock ";
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(179, 541);
            this.MessageBox.Margin = new System.Windows.Forms.Padding(4);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(487, 62);
            this.MessageBox.TabIndex = 60;
            this.MessageBox.Text = "";
            this.MessageBox.Visible = false;
            // 
            // CatagoryBox
            // 
            this.CatagoryBox.FormattingEnabled = true;
            this.CatagoryBox.Items.AddRange(new object[] {
            "Starter ",
            "Main",
            "Desert",
            "Sides ",
            "Drink"});
            this.CatagoryBox.Location = new System.Drawing.Point(178, 231);
            this.CatagoryBox.Name = "CatagoryBox";
            this.CatagoryBox.Size = new System.Drawing.Size(488, 24);
            this.CatagoryBox.TabIndex = 61;
            this.CatagoryBox.Text = "Add catagory ";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(178, 311);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(487, 62);
            this.PriceBox.TabIndex = 62;
            this.PriceBox.Text = "Enter price of item";
            // 
            // AddMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 629);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.CatagoryBox);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.StockAmountBox);
            this.Controls.Add(this.StockBox);
            this.Controls.Add(this.EnterItemNameBox);
            this.Controls.Add(this.NextStock);
            this.Controls.Add(this.SaveAndQuitButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.AddItem);
            this.Name = "AddMenuItem";
            this.Text = "AddMenuItem";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button SaveAndQuitButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button NextStock;
        private System.Windows.Forms.RichTextBox EnterItemNameBox;
        private System.Windows.Forms.ComboBox StockBox;
        private System.Windows.Forms.RichTextBox StockAmountBox;
        private System.Windows.Forms.RichTextBox MessageBox;
        private System.Windows.Forms.ComboBox CatagoryBox;
        private System.Windows.Forms.RichTextBox PriceBox;
    }
}