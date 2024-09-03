using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ResturanteManagementSystemv1
{
    public partial class NewOrder : Form
    {


        bool CreateFile = true;
        string DirectoryPath;
        string FileName;
        string FullPath;
        string OrderName = "0";
        int highestOrderNumber;
        string ItemAdd;
        string MenuPath = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\MenuItems";
        string OrderPath = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\Orders";
        string StockItemsDirectory = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\StockItems";
        int OrderNameI = 0;
        string AddToOrder;
        string AddToOrder2;
        string Starter;
        string Main;
        string Desert;
        string Sides;
        string Drink;
        public NewOrder()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
           
            // finds menu items then prints them into relevant comboboxes.           
            if (Directory.Exists(MenuPath))
            {
                string[] files = Directory.GetFiles(MenuPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);

                    if (fileName.Contains(","))
                    {
                        string[] parts = fileName.Split(',');

                        if (parts.Length == 2)
                        {
                            string category = parts[0].Trim();
                            string menuItem = parts[1].Trim();

                            switch (category)
                            {
                                case "Starter":
                                    StarterBox.Items.Add(menuItem);
                                    break;
                                case "Main":
                                    MainBox.Items.Add(menuItem);
                                    break;
                                case "Desert":
                                    DesertBox.Items.Add(menuItem);
                                    break;
                                case "Sides":
                                    SidesBox.Items.Add(menuItem);
                                    break;
                                case "Drink":
                                    DrinksBox.Items.Add(menuItem);
                                    break;
                            }
                        }
                    }
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

        private void NextItem_Click(object sender, EventArgs e)
        {
            if (StarterBox.Text == (""))
            {
                Starter = ("");
            }
            else
            {
                Starter = ("Starter ," + StarterBox.Text);
            }
            if (MainBox.Text == (""))
            {
                Main = ("");
            }
            else
            {
                Main = ("Main," + MainBox.Text);
            }
            if (DesertBox.Text == (""))
            {
                Desert = ("");
            }
            else
            {
                Desert = "Desert," + DesertBox.Text;
            }
            if (SidesBox.Text == (""))
            {
                Sides = ("");
            }
            else
            {
                Sides = "Sides," + SidesBox.Text;
            }
            if (DrinksBox.Text == (""))
            {
                Drink = ("");
            }
            else
            {
                Drink = "Drink," + DrinksBox.Text;
            }
         
            AddToOrder = ( AddToOrder+"\r\n" + Starter + Main + Desert + Sides + Drink);

            CurrentOrderBox.Text = AddToOrder;
            StarterBox.Text = ("");
            MainBox.Text = ("");
            DesertBox.Text = ("");
            SidesBox.Text = ("");
            DrinksBox.Text = ("");
            
        }

        private async void SendOrder_Click(object sender, EventArgs e)
        {
            //creates orderfile and saves the name in the programs setting so user can enter different forms but then then the variable is still picked up and continued to be added to 
            OrderNameI = (OrderNameI + 1);
            Mods.Text = OrderNameI.ToString();
            string OrderName = OrderNameI.ToString();
            string FileName = (OrderName + ",Order.txt");
            string FullPath = Path.Combine(OrderPath, FileName);
            using (StreamWriter File = new StreamWriter(FullPath))
            {
                File.Write("Order " + OrderNameI + AddToOrder);
            }
            richTextBox6.Text = ("Order Created");
            CurrentOrderBox.Text = ("");
            await Task.Delay(3000);
            richTextBox6.Text = ("");
            Properties.Settings.Default.OrderNameI = OrderNameI;
            Properties.Settings.Default.Save();
            string DirectoryPath = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\MenuItems";
            string[] lines = File.ReadAllLines(FullPath);            
            AddToOrder = ("");

            // Process each line after the first one (first line contains OrderNumber, which is irrelevant)
            /*for (int i = 1; i < lines.Length; i++)
            {
                // Get the current line (in the format "Category,Name")
                string line = lines[i];

                // Generate the file name based on the Category and Name
                string fileName = line + ".txt";
                string filePath = Path.Combine(DirectoryPath, fileName);

                // Read and display the contents of the file
                string fileContent = File.ReadAllText(filePath);
                //richTextBox6.Text = (fileContent);

                string[] StockItems = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                for (int x = 4; x < StockItems.Length; x++)
                {
                    // Split each line by the comma to separate the filename and the amount
                    string[] parts = StockItems[x].Split(',');
                    string StockFileName = parts[1].Trim(); // Extracted file name
                    string StockNeeded = parts[2].Trim(); // Amount used (for your reference)

                    // Create the full path to the file in the StockItems directory
                    string StockFilePath = Path.Combine(StockItemsDirectory, StockFileName);
                   
                    richTextBox6.Text = (StockFileName);
                    // Read the content of the found file
                    string stockFileContent = File.ReadAllText(StockFilePath + ".txt");

                    // Print the file name and its contents in richTextBox6                   
                    string[] Stocklines = stockFileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                    // Extract the stock amount line
                    string fourthLine = Stocklines[3].Trim();

                    // Convert the extracted line to an integer
                    int StockAmount = int.Parse(fourthLine);
                    richTextBox6.Text = StockAmount.ToString();

                    int Stock = StockAmount - int.Parse(StockNeeded);
                    richTextBox6.Text = Stock.ToString();

                    string[] StockFileLines = File.ReadAllLines(StockFilePath);

                    // Modify the 4th line (index 3, since arrays are zero-indexed)
                    StockFileLines[3] = Stock.ToString();

                    // Write all the lines back to the file
                    using (StreamWriter writer = new StreamWriter(StockFilePath))
                    {
                        foreach (string StockFileline in StockFileLines)
                        {
                            writer.WriteLine(StockFileLines);
                        }
                    }



                }*/
            }


        }
    }

