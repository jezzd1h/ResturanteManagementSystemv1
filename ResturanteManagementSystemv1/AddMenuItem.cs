using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace ResturanteManagementSystemv1
{
    public partial class AddMenuItem : Form
    {
        string StockItem;
        string ReadFolderPath;
        string MenuItemName;
        string AmountNeeded;
        string FileName;
        string Catagory;
        bool CreateNewFile = true;
        string DirectoryPath;
        string FullPath;
        string Price;


        bool MenuItemNameVal;
        bool StockItemVal;
        bool AmountNeededVal;
        bool CatagoryVal;
        bool PriceVal;

        public AddMenuItem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            string FolderPath = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\StockItems";
            // Get all files
            string[] filePaths = Directory.GetFiles(FolderPath);
            // Add each file name to the combobox
            foreach (string FilePath in filePaths)
            {
                // Get the file name without the directory path and extension
                string fileName = Path.GetFileNameWithoutExtension(FilePath);
                // Add the file name to the RichTextBox
                StockBox.Items.Add(fileName);
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

        private async void AddItem_Click(object sender, EventArgs e)
        {
            if (CreateNewFile == true)
            {
                MenuItemName = EnterItemNameBox.Text;
                if (MenuItemName == "Enter item name")
                {
                    MenuItemNameVal = false;
                }
                else
                {
                    MenuItemNameVal = true;
                }
                Catagory = CatagoryBox.Text;
                if (Catagory == "Add catagory")
                {
                    CatagoryVal = false;
                }
                else
                {
                    CatagoryVal = true;
                }
                
                Price = PriceBox.Text;
                bool TestInt = float.TryParse(Price, out float num);
                if (TestInt == true)
                {
                    float TestNeg = float.Parse(Price);
                    if (TestNeg <= 0)
                    {
                        PriceVal = false;
                    }
                    else
                    {
                        PriceVal = true;
                    }

                }


                if ((MenuItemNameVal == true) && (CatagoryVal == true) && (PriceVal = true ) && (StockItemVal = true))
                {
                    string DirectoryPath = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\MenuItems";
                    string FileName = Catagory + "," + MenuItemName + ".txt";
                    string FullPath = Path.Combine(DirectoryPath, FileName);
                    using (StreamWriter File = new StreamWriter(FullPath))
                    {
                        File.Write(MenuItemName + "\r\n" + Catagory + "\r\n" + Price + "\r\n" + StockItem + "," + AmountNeeded + "\r\n");
                                             

                    }
                    CreateNewFile = false;

                }
                else
                {
                    MessageBox.Visible = true;
                    MessageBox.Text = ("Invalid input");
                    await Task.Delay(3000);
                    MessageBox.Text = ("  ");
                    MessageBox.Visible = false;
                }
            }
            
            
            
            
            
            if ((StockItemVal == true) && (AmountNeededVal == true) && (MenuItemNameVal == true) && (CatagoryVal == true))
            {               
                EnterItemNameBox.Text = ("Enter item name");
                StockBox.Text = ("Add item ");
                CatagoryBox.Text = ("Add catagaory");
                StockAmountBox.Text = ("Enter amount of stock");
                MessageBox.Visible = true;
                MessageBox.Text = ("Menu item added");
                await Task.Delay(3000);
                MessageBox.Text = ("  ");
                MessageBox.Visible = false;
                
            }
            else
            {
                MessageBox.Visible = true;
                MessageBox.Text = ("Invalid input");
                await Task.Delay(3000);
                MessageBox.Text = ("  ");
                MessageBox.Visible = false;
            }

        }

        private async void NextStock_Click(object sender, EventArgs e)
        {           
            while (CreateNewFile == true)
            {                     
                MenuItemName = EnterItemNameBox.Text;
                if (MenuItemName == "Enter item name")
                {
                    //MenuItemNameVal = false;
                }
                else
                {
                    MenuItemNameVal = true;
                }
                Catagory = CatagoryBox.Text;
                if (Catagory == "Add catagory")
                {
                    //CatagoryVal = false;
                }
                else
                {
                    CatagoryVal = true;
                }
                Price = PriceBox.Text;
                bool TestInt1 = float.TryParse(Price, out float num1);
                if (TestInt1 == true)
                {
                    float TestNeg = float.Parse(Price);
                    if (TestNeg <= 0)
                    {
                        PriceVal = false;
                    }
                    else
                    {
                        PriceVal = true;
                    }

                }

                if ((MenuItemNameVal == true)&&(CatagoryVal == true)&&(PriceVal == true))
                {
                    string DirectoryPath = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\MenuItems";
                    string FileName = Catagory + ","+ MenuItemName + ".txt";
                    string FullPath = Path.Combine(DirectoryPath, FileName);
                    using (StreamWriter File = new StreamWriter(FullPath))
                    {
                        File.Write(MenuItemName+"\r\n"+Catagory);
                        File.WriteLine(StockItem + "," + AmountNeeded + "\r\n");

                    }
                    CreateNewFile = false;
                    
                }
                else
                {
                    MessageBox.Visible = true;
                    MessageBox.Text = ("Invalid input");
                    await Task.Delay(3000);
                    MessageBox.Text = ("  ");
                    MessageBox.Visible = false;
                }

            }
            
            StockItem = StockBox.Text;
            if (StockItem == "Enter amount of stock")
            {
                StockItemVal = false;
            }
            else
            {
                StockItemVal = true;
            }
            AmountNeeded = StockAmountBox.Text;
            bool TestInt = float.TryParse(AmountNeeded, out float num);
            if (TestInt == true)
            {
                float TestNeg = float.Parse(AmountNeeded);
                if (TestNeg <= 0)
                {
                    AmountNeededVal = false;
                }
                else
                {
                    AmountNeededVal = true;
                }
                
            }
 
            if ((StockItemVal == true) && (AmountNeededVal == true))
            {
                string DirectoryPath = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\MenuItems";
                string FileName = Catagory + "," + MenuItemName + ".txt";
                string FullPath = Path.Combine(DirectoryPath, FileName);
               using (StreamWriter file = new StreamWriter(FullPath, append:true))
               {
                    file.WriteLine(StockItem + "," + AmountNeeded + "\r\n");
                    StockBox.Text = ("AddItem");
                    StockAmountBox.Text = ("Enter amount");
               }
            }
            else
            {
                MessageBox.Visible = true;
                MessageBox.Text = ("Invalid input");
                await Task.Delay(3000);
                MessageBox.Text = ("  ");
                MessageBox.Visible = false;
            }
        }

    }
}   
