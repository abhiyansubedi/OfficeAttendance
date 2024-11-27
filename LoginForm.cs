using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using AccessKeyDemo;
using System.IO;
using System.Data.SQLite;

namespace StandaloneSDKDemo
{
    public partial class LoginForm : Form
    {
        //private string connectionString = @"Data Source=C:\Users\subed\OneDrive\Documents\NetFrameworkZKTecoAttLogsDemo2\Users.db;Version=3.40.0;";


       
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Office.db");
            string connectionString = $"Data Source={dbFilePath};";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Organization WHERE Username = @Username AND Password = @Password";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    conn.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            try
                            {
                                reader.Close();

                                string query2 = "SELECT LicenseKey FROM Organization ORDER BY Id DESC LIMIT 1";
                                using (SQLiteCommand command2 = new SQLiteCommand(query2, conn))
                                {
                                    using (SQLiteDataReader reader2 = command2.ExecuteReader())
                                    {
                                        if (reader2.Read())
                                        {
                                            string licenseKey = reader2["LicenseKey"].ToString();
                                            UserClaim decryptedClaim = EncryptionHelper.Decrypt(licenseKey);

                                            if (decryptedClaim != null && decryptedClaim.ExpirationDate.HasValue)
                                            {
                                                DateTime expirationDate = decryptedClaim.ExpirationDate.Value;
                                                if (expirationDate >= DateTime.Now)
                                                {
                                                    // Ensure sender is a Button before casting
                                                    if (sender is Button button)
                                                    {
                                                        // Create and show the main form6
                                                        Main mainForm = new Main();
                                                        mainForm.LoadPags(button, new Homepage()); // Pass the button to LoadPags
                                                        mainForm.Show(); // Display Main form
                                                        this.Hide(); // Hide the LoginForm after successful login
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Invalid sender. Please try again.");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Your license has expired.");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials.");
                        }
                    }
                }
            }
        }







        //catch (Exception ex)
        //{
        //    MessageBox.Show($"Error performing CRUD operation: {ex.Message}");
        //}





        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            new Register().Show();
            this.Hide();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            new DatabaseConnectionForm().Show();
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
