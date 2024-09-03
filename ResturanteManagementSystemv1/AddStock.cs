using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Collections;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ResturanteManagementSystemv1
{
    public partial class AddStock : Form
    {

        //strings for data 
        string StockName;
        string MeasurementUnit;
        string MinimumStockLimit;
        string StockAmount;
        string PricePerUnit;     
        string FileName;
        //bools for testing 
        
        bool StockAmountVal = false;
        bool PricePerUnitVal = false;
        bool MinimumStockLimitVal = false;
        bool StockNameVal = false;
        bool MeasurementUnitVal = false;

        public AddStock()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
        private async void NewStock_Click(object sender, EventArgs e)
        {
            StockName = EnterStockNameBox.Text;
            if (StockName == "Enter stock name")
            {
                StockNameVal = false;
            }
            else
            {
                StockNameVal = true;
            }
            //StockNameDone
            MeasurementUnit = MeasurementUnitBox.Text;
            if (MeasurementUnit == "Measurement unit")
            {
                MeasurementUnitVal = false;
            }
            else
            {
                MeasurementUnitVal = true;
            }
            
            //MeasurementUnitDone
            StockAmount = EnterAmountBox.Text;
            bool TestInt = float.TryParse(StockAmount, out float num);
            if (TestInt == true)
            {
                float TestNeg = float.Parse(StockAmount);
                if (TestNeg <= 0)
                {
                    StockAmountVal = false;
                }
                else
                {
                    StockAmountVal = true;
                }
            }
            else
            {
                StockAmountVal = false; 
            }
            //StockAmountDone
            MinimumStockLimit = EnterMinimumLimitBox.Text;
            bool TestInt1 = float.TryParse(MinimumStockLimit, out float num1);
            if (TestInt1 == true)
            {
                float TestNeg1 = float.Parse(MinimumStockLimit);
                if (TestNeg1 <= 0)
                {
                    MinimumStockLimitVal = false;
                }
                else
                {
                    MinimumStockLimitVal = true;
                }
            }
            else
            {
                MinimumStockLimitVal = false;
            }
            //MinimumStockLimitDone
            PricePerUnit = EnterPricePerUnitBox.Text;
            
            //makes sure price per unit has correct Decimals 
            if (PricePerUnit.Contains('.'))
            {
                // Find the position of the dot
                int dotIndex = PricePerUnit.IndexOf('.');

                // Extract the part after the dot
                string partAfterDot = PricePerUnit.Substring(dotIndex + 1);

                // Check if there is exactly one letter (or character) after the dot
                if (partAfterDot.Length == 1)
                {
                    PricePerUnit = (PricePerUnit + "0"); 
                }
                if (partAfterDot.Length == 0)
                {
                    PricePerUnit = (PricePerUnit + "00");
                }
              
            }
            else
            {
                PricePerUnit = (PricePerUnit + ".00");
            }


            bool TestInt2 = float.TryParse(PricePerUnit, out float num2);
            if (TestInt2 == true)
            {
                float TestNeg2 = float.Parse(PricePerUnit);
                if (TestNeg2 <= 0)
                {
                    PricePerUnitVal = false;
                }
                else
                {
                    PricePerUnitVal = true;
                }
            }
            else
            {
                PricePerUnitVal = false;
            }
            
            //float PricePerUnit = float.Parse(PricerPerUnitStr);          


            if ((StockNameVal == true) && (StockAmountVal == true) && (MinimumStockLimitVal == true) && (PricePerUnitVal == true) && (MeasurementUnitVal == true))
            {
                
                
                MessageBox.Text = ("Stock Added");
                string DirectoryPath = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\StockItems";             
                string FileName = StockName + ".txt";
                string FullPath = Path.Combine(DirectoryPath, FileName);
                using (StreamWriter File = new StreamWriter(FullPath))
                {
                    File.Write(StockName + "\r\n" + MeasurementUnit + "\r\n" + MinimumStockLimit + "\r\n" + StockAmount + "\r\n" + PricePerUnit);
                }

                MessageBox.Text = ("Stock Added");
                EnterStockNameBox.Text = "Enter stock name";
                MeasurementUnitBox.Text = "Enter measurement";
                EnterMinimumLimitBox.Text = "Enter minimum limit";
                EnterAmountBox.Text = "Enter Amount";
                EnterPricePerUnitBox.Text = "Enter price per unit";

                MessageBox.Text = ("Stock Added");
                MessageBox.Visible = true;
                await Task.Delay(3000);
                MessageBox.Text = ("  ");
                MessageBox.Visible = false;
            }
            else
            {
                MessageBox.Visible = true;
                MessageBox.Text = ("invalid inputs");
                await Task.Delay(3000);
                MessageBox.Visible = false;

            }

        }
     
    } 


}
