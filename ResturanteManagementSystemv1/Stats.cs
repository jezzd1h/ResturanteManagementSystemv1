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
    public partial class Stats : Form
    {
        public Stats()
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
    }
}
