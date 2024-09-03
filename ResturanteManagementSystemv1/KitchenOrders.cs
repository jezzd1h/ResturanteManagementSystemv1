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
    public partial class KitchenOrders : Form
    {
        string OrderPath = @"D:\Visual Studio Projects\ResturanteManagementSystemv1\ResturanteManagementSystemv1\bin\Debug\Orders";
        string[] orderFiles;
        int currentIndex = 0;
        public KitchenOrders()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            orderFiles = Directory.GetFiles(OrderPath, "*.txt")
                               .Where(f => Path.GetFileNameWithoutExtension(f).Contains(",Order"))
                               .OrderBy(f => int.Parse(Path.GetFileNameWithoutExtension(f).Split(',')[0]))
                               .ToArray();

            // Display the first file
            if (orderFiles.Length > 0)
            {
                currentIndex = 0; // Start with the first file
                // Get the file name
                string fileName = Path.GetFileNameWithoutExtension(orderFiles[currentIndex]);
                // Read file
                string[] allLines = File.ReadAllLines(orderFiles[currentIndex]);
                string fileContent = string.Join(Environment.NewLine, allLines.Skip(1));               
                OrderCodeDisplay.Text = fileName;
                OrderDisplay.Text = fileContent;
            }         
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void NextOrder_Click(object sender, EventArgs e)
        {
            if (currentIndex < orderFiles.Length - 1)
            {
                currentIndex++;
                string fileName = Path.GetFileNameWithoutExtension(orderFiles[currentIndex]);
                string fileContent = File.ReadAllText(orderFiles[currentIndex]);
                OrderCodeDisplay.Text = fileName;
                OrderDisplay.Text = fileContent;
            }
        }

        private void LastOrder_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;            
                string fileName = Path.GetFileNameWithoutExtension(orderFiles[currentIndex]);               
                string fileContent = File.ReadAllText(orderFiles[currentIndex]);               
                OrderCodeDisplay.Text = fileName;
                OrderDisplay.Text = fileContent;
            }
        }

        private void SendOrder_Click(object sender, EventArgs e)
        {
            if (orderFiles.Length > 0 && currentIndex >= 0 && currentIndex < orderFiles.Length)
            {
                // Get the path of the current file
                string currentFilePath = orderFiles[currentIndex];

                // Delete the file
                File.Delete(currentFilePath);

                // Remove the file from the orderFiles array
                orderFiles = orderFiles.Where((source, index) => index != currentIndex).ToArray();

                // Adjust currentIndex
                if (currentIndex >= orderFiles.Length)
                {
                    currentIndex = orderFiles.Length - 1;
                }

                // Display the next file or clear the textboxes if there are no files left
                if (orderFiles.Length > 0 && currentIndex >= 0)
                {
                    string fileName = Path.GetFileNameWithoutExtension(orderFiles[currentIndex]);
                    string[] allLines = File.ReadAllLines(orderFiles[currentIndex]);
                    string fileContent = string.Join(Environment.NewLine, allLines.Skip(1));

                    OrderCodeDisplay.Text = fileName;
                    OrderDisplay.Text = fileContent;
                }
                else
                {
                    OrderCodeDisplay.Clear();
                    OrderDisplay.Clear();
                }
            }
        }
    }
}
