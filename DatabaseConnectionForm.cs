using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandaloneSDKDemo
{
    public partial class DatabaseConnectionForm : Form
    {
        public DatabaseConnectionForm()
        {
            InitializeComponent();
        }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string LicenseKey { get; set; }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            ServerName = txtServerName.Text;
            DatabaseName = txtDatabaseName.Text;
            LicenseKey = txtLicenseKey.Text.Trim();

            if (string.IsNullOrEmpty(ServerName) || string.IsNullOrEmpty(DatabaseName))
            {
                MessageBox.Show("Please connect to the server.");
                return;
            }

            if (string.IsNullOrEmpty(LicenseKey))
            {
                MessageBox.Show("Please enter the License Key.");
                return;
            }

            try
            {
                string configFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dbconfig.txt");

                // Check if the file exists
                if (!File.Exists(configFile))
                {
                    File.WriteAllText(configFile, $"{ServerName},{DatabaseName}");
                    MessageBox.Show("Configuration file created successfully!");
                }
                else
                {
                    MessageBox.Show("Configuration file already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to write to config file: {ex.Message}");
            }


            string connectionString = $"Data Source={ServerName};Initial Catalog={DatabaseName};Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                  
                    string checkQuery = "SELECT COUNT(*) FROM tbllicense WHERE LicenseKey IS NOT NULL";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, conn);

                    int count = (int)checkCommand.ExecuteScalar(); 

                  
                    if (count > 0)
                    {
             
                        string updateQuery = "UPDATE tbllicense SET LicenseKey = @LicenseKey";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                        updateCommand.Parameters.AddWithValue("@LicenseKey", LicenseKey);
                        updateCommand.ExecuteNonQuery();

                        MessageBox.Show("License Key updated successfully!");
                    }
                    else
                    {
                     
                        string insertQuery = "INSERT INTO tbllicense (LicenseKey) VALUES (@LicenseKey)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
                        insertCommand.Parameters.AddWithValue("@LicenseKey", LicenseKey);
                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("License Key inserted successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            this.DialogResult = DialogResult.OK;

          
            new Register().Show();
            this.Hide();
        }




        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
