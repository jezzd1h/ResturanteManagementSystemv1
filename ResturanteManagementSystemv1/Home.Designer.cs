namespace ResturanteManagementSystemv1
{
    partial class Home
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
            this.ViewStockButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.StatsButton = new System.Windows.Forms.Button();
            this.EnterMenuItemButton = new System.Windows.Forms.Button();
            this.EnterStockButton = new System.Windows.Forms.Button();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.OpenKitchenOrdersButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndQuitButton
            // 
            this.SaveAndQuitButton.BackColor = System.Drawing.Color.White;
            this.SaveAndQuitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveAndQuitButton.Location = new System.Drawing.Point(4, 325);
            this.SaveAndQuitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAndQuitButton.Name = "SaveAndQuitButton";
            this.SaveAndQuitButton.Size = new System.Drawing.Size(280, 316);
            this.SaveAndQuitButton.TabIndex = 20;
            this.SaveAndQuitButton.Text = "Save and Quit ";
            this.SaveAndQuitButton.UseVisualStyleBackColor = false;
            this.SaveAndQuitButton.Click += new System.EventHandler(this.SaveAndQuitButton_Click);
            // 
            // ViewStockButton
            // 
            this.ViewStockButton.BackColor = System.Drawing.Color.Blue;
            this.tableLayoutPanel1.SetColumnSpan(this.ViewStockButton, 2);
            this.ViewStockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewStockButton.Location = new System.Drawing.Point(292, 325);
            this.ViewStockButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewStockButton.Name = "ViewStockButton";
            this.ViewStockButton.Size = new System.Drawing.Size(568, 316);
            this.ViewStockButton.TabIndex = 17;
            this.ViewStockButton.Text = "View stock ";
            this.ViewStockButton.UseVisualStyleBackColor = false;
            this.ViewStockButton.Click += new System.EventHandler(this.ViewStockButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.White;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeButton.Location = new System.Drawing.Point(4, 3);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(280, 316);
            this.HomeButton.TabIndex = 16;
            this.HomeButton.Text = "Home ";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // StatsButton
            // 
            this.StatsButton.BackColor = System.Drawing.Color.Turquoise;
            this.StatsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsButton.Location = new System.Drawing.Point(292, 647);
            this.StatsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(280, 317);
            this.StatsButton.TabIndex = 15;
            this.StatsButton.Text = "Stats ";
            this.StatsButton.UseVisualStyleBackColor = false;
            this.StatsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // EnterMenuItemButton
            // 
            this.EnterMenuItemButton.BackColor = System.Drawing.Color.Fuchsia;
            this.EnterMenuItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnterMenuItemButton.Location = new System.Drawing.Point(580, 647);
            this.EnterMenuItemButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EnterMenuItemButton.Name = "EnterMenuItemButton";
            this.EnterMenuItemButton.Size = new System.Drawing.Size(280, 317);
            this.EnterMenuItemButton.TabIndex = 14;
            this.EnterMenuItemButton.Text = "Enter menu items  ";
            this.EnterMenuItemButton.UseVisualStyleBackColor = false;
            this.EnterMenuItemButton.Click += new System.EventHandler(this.EnterMenuItemButton_Click);
            // 
            // EnterStockButton
            // 
            this.EnterStockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EnterStockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnterStockButton.Location = new System.Drawing.Point(868, 647);
            this.EnterStockButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EnterStockButton.Name = "EnterStockButton";
            this.EnterStockButton.Size = new System.Drawing.Size(283, 317);
            this.EnterStockButton.TabIndex = 13;
            this.EnterStockButton.Text = "Enter stock  ";
            this.EnterStockButton.UseVisualStyleBackColor = false;
            this.EnterStockButton.Click += new System.EventHandler(this.EnterStockButton_Click);
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel1.SetColumnSpan(this.NewOrderButton, 2);
            this.NewOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewOrderButton.Location = new System.Drawing.Point(292, 3);
            this.NewOrderButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(568, 316);
            this.NewOrderButton.TabIndex = 12;
            this.NewOrderButton.Text = "New Order ";
            this.NewOrderButton.UseVisualStyleBackColor = false;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // OpenKitchenOrdersButton
            // 
            this.OpenKitchenOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OpenKitchenOrdersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenKitchenOrdersButton.Location = new System.Drawing.Point(4, 647);
            this.OpenKitchenOrdersButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OpenKitchenOrdersButton.Name = "OpenKitchenOrdersButton";
            this.OpenKitchenOrdersButton.Size = new System.Drawing.Size(280, 317);
            this.OpenKitchenOrdersButton.TabIndex = 11;
            this.OpenKitchenOrdersButton.Text = "Open kitchen orders";
            this.OpenKitchenOrdersButton.UseVisualStyleBackColor = false;
            this.OpenKitchenOrdersButton.Click += new System.EventHandler(this.OpenKitchenOrdersButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(868, 5);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.tableLayoutPanel1.SetRowSpan(this.richTextBox1, 2);
            this.richTextBox1.Size = new System.Drawing.Size(283, 634);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.HomeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewStockButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.NewOrderButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveAndQuitButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OpenKitchenOrdersButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.EnterStockButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.EnterMenuItemButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.StatsButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1155, 967);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 967);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveAndQuitButton;
        private System.Windows.Forms.Button ViewStockButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button StatsButton;
        private System.Windows.Forms.Button EnterMenuItemButton;
        private System.Windows.Forms.Button EnterStockButton;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button OpenKitchenOrdersButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

