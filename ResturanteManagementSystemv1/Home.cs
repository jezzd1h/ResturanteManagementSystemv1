using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturanteManagementSystemv1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            NewOrder f2 = new NewOrder();
            f2.Show();
            this.Hide();
            
            //shows new form on button click, creates new local variable then hides previous form
        }

        private void ViewStockButton_Click(object sender, EventArgs e)
        {
            ViewStock f3 = new ViewStock();
            f3.Show();
            this.Hide();
        }

        private void OpenKitchenOrdersButton_Click(object sender, EventArgs e)
        {
            KitchenOrders f4 = new KitchenOrders();
            f4.Show();
            //does not need to hide 
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            Stats f5 = new Stats();
            f5.Show();
            this.Hide();
        }

        private void EnterMenuItemButton_Click(object sender, EventArgs e)
        {
            AddMenuItem f6 = new AddMenuItem();
            f6.Show();
            this.Hide();
        }

        private void EnterStockButton_Click(object sender, EventArgs e)
        {
            AddStock f7 = new AddStock();
            f7.Show();
            this.Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveAndQuitButton_Click(object sender, EventArgs e)
        {
            string OrderPath = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\Orders";
            // Get all files in the directory
            string[] files = Directory.GetFiles(OrderPath);

            // Iterate over each file and delete it
            foreach (string filePath in files)
            {
                // Delete the file
                File.Delete(filePath);
            }

            System.Windows.Forms.Application.Exit();
        }

        
    }
}
