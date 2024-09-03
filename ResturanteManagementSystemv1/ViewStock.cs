using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturanteManagementSystemv1
{
    public partial class ViewStock : Form
    {
        string StockDirectory = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\StockItems";
        string Amounts;
        public ViewStock()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //sorts files    
            var SortedFiles = Directory.GetFiles(StockDirectory).OrderBy(f => f).ToArray();


            foreach (string filePath in SortedFiles)
            {
                // Open the file using StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {

                    string StockName = reader.ReadLine();
                    string StockUnit = reader.ReadLine();
                    reader.ReadLine();
                    string StockAmount = reader.ReadLine();
                    string StockAmountNum = StockAmount;
                    string PricePerUnit = reader.ReadLine();
                    float PricePerUnitF = float.Parse(PricePerUnit);
                    float StockAmountF = float.Parse(StockAmountNum);
                    float PriceOfStockF = StockAmountF * PricePerUnitF;
                    string PriceOfStock = ("£" + (PriceOfStockF.ToString()));

                    if (PriceOfStock.Contains('.'))
                    {
                        // Find the position of the dot
                        int dotIndex = PriceOfStock.IndexOf('.');

                        // Extract the part after the dot
                        string partAfterDot = PriceOfStock.Substring(dotIndex + 1);

                        // Check if there is exactly one letter (or character) after the dot
                        if (partAfterDot.Length == 1)
                        {
                            PriceOfStock = (PriceOfStock + "0");
                        }
                        if (partAfterDot.Length == 0)
                        {
                            PriceOfStock = (PriceOfStock + "00");
                        }

                    }
                    else
                    {
                        PriceOfStock = (PriceOfStock + ".00");
                    }




                    if (StockUnit == "Unit")
                    {
                        
                        Amounts = StockAmount;

                    }
                    else
                    {
                        Amounts = StockAmount + " " + StockUnit;
                    }


                    // displays variables 

                    int RowIndex = dataGridView1.Rows.Add();

                    // Access the new row using the row index
                    DataGridViewRow NewRow = dataGridView1.Rows[RowIndex];
                    //Displays Data 
                    NewRow.Cells["Name"].Value = StockName;
                    NewRow.Cells["Amount"].Value = Amounts;
                    NewRow.Cells["PriceOfStock"].Value = PriceOfStock;

                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home f8 = new Home();
            f8.Show();
            this.Hide();
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

        private void EnterStockButton_Click(object sender, EventArgs e)
        {
            AddStock f7 = new AddStock();
            f7.Show();
            this.Hide();
        }
    }
}
