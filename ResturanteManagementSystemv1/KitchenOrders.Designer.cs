namespace ResturanteManagementSystemv1
{
    partial class KitchenOrders
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
            this.SaveAndQuitButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LastOrder = new System.Windows.Forms.Button();
            this.ModsNotes = new System.Windows.Forms.RichTextBox();
            this.NextOrder = new System.Windows.Forms.Button();
            this.KitchenAlerts = new System.Windows.Forms.RichTextBox();
            this.OrderDisplay = new System.Windows.Forms.RichTextBox();
            this.OrderCodeDisplay = new System.Windows.Forms.RichTextBox();
            this.SendOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveAndQuitButton
            // 
            this.SaveAndQuitButton.BackColor = System.Drawing.Color.White;
            this.SaveAndQuitButton.Location = new System.Drawing.Point(12, 159);
            this.SaveAndQuitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveAndQuitButton.Name = "SaveAndQuitButton";
            this.SaveAndQuitButton.Size = new System.Drawing.Size(155, 144);
            this.SaveAndQuitButton.TabIndex = 23;
            this.SaveAndQuitButton.Text = "Save and Quit ";
            this.SaveAndQuitButton.UseVisualStyleBackColor = false;
            this.SaveAndQuitButton.Click += new System.EventHandler(this.SaveAndQuitButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(12, 11);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(155, 144);
            this.HomeButton.TabIndex = 21;
            this.HomeButton.Text = "Home ";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LastOrder
            // 
            this.LastOrder.BackColor = System.Drawing.Color.White;
            this.LastOrder.Location = new System.Drawing.Point(12, 456);
            this.LastOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastOrder.Name = "LastOrder";
            this.LastOrder.Size = new System.Drawing.Size(155, 144);
            this.LastOrder.TabIndex = 24;
            this.LastOrder.Text = "<<";
            this.LastOrder.UseVisualStyleBackColor = false;
            this.LastOrder.Click += new System.EventHandler(this.LastOrder_Click);
            // 
            // ModsNotes
            // 
            this.ModsNotes.Location = new System.Drawing.Point(173, 458);
            this.ModsNotes.Name = "ModsNotes";
            this.ModsNotes.Size = new System.Drawing.Size(310, 142);
            this.ModsNotes.TabIndex = 28;
            this.ModsNotes.Text = "Mods and notes";
            // 
            // NextOrder
            // 
            this.NextOrder.BackColor = System.Drawing.Color.White;
            this.NextOrder.Location = new System.Drawing.Point(489, 456);
            this.NextOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextOrder.Name = "NextOrder";
            this.NextOrder.Size = new System.Drawing.Size(155, 144);
            this.NextOrder.TabIndex = 29;
            this.NextOrder.Text = ">>";
            this.NextOrder.UseVisualStyleBackColor = false;
            this.NextOrder.Click += new System.EventHandler(this.NextOrder_Click);
            // 
            // KitchenAlerts
            // 
            this.KitchenAlerts.Location = new System.Drawing.Point(489, 12);
            this.KitchenAlerts.Name = "KitchenAlerts";
            this.KitchenAlerts.Size = new System.Drawing.Size(155, 440);
            this.KitchenAlerts.TabIndex = 30;
            this.KitchenAlerts.Text = "Alerts ";
            // 
            // OrderDisplay
            // 
            this.OrderDisplay.Location = new System.Drawing.Point(173, 159);
            this.OrderDisplay.Name = "OrderDisplay";
            this.OrderDisplay.Size = new System.Drawing.Size(310, 289);
            this.OrderDisplay.TabIndex = 31;
            this.OrderDisplay.Text = "Order ";
            // 
            // OrderCodeDisplay
            // 
            this.OrderCodeDisplay.Location = new System.Drawing.Point(173, 13);
            this.OrderCodeDisplay.Name = "OrderCodeDisplay";
            this.OrderCodeDisplay.Size = new System.Drawing.Size(310, 142);
            this.OrderCodeDisplay.TabIndex = 32;
            this.OrderCodeDisplay.Text = "OrderCode ";
            // 
            // SendOrder
            // 
            this.SendOrder.BackColor = System.Drawing.Color.White;
            this.SendOrder.Location = new System.Drawing.Point(12, 308);
            this.SendOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendOrder.Name = "SendOrder";
            this.SendOrder.Size = new System.Drawing.Size(155, 144);
            this.SendOrder.TabIndex = 33;
            this.SendOrder.Text = "Send order";
            this.SendOrder.UseVisualStyleBackColor = false;
            this.SendOrder.Click += new System.EventHandler(this.SendOrder_Click);
            // 
            // KitchenOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 622);
            this.Controls.Add(this.SendOrder);
            this.Controls.Add(this.OrderCodeDisplay);
            this.Controls.Add(this.OrderDisplay);
            this.Controls.Add(this.KitchenAlerts);
            this.Controls.Add(this.NextOrder);
            this.Controls.Add(this.ModsNotes);
            this.Controls.Add(this.LastOrder);
            this.Controls.Add(this.SaveAndQuitButton);
            this.Controls.Add(this.HomeButton);
            this.Name = "KitchenOrders";
            this.Text = "KitchenOrders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveAndQuitButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button LastOrder;
        private System.Windows.Forms.RichTextBox ModsNotes;
        private System.Windows.Forms.Button NextOrder;
        private System.Windows.Forms.RichTextBox KitchenAlerts;
        private System.Windows.Forms.RichTextBox OrderDisplay;
        private System.Windows.Forms.RichTextBox OrderCodeDisplay;
        private System.Windows.Forms.Button SendOrder;
    }
}