using AccessKeyDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;

namespace StandaloneSDKDemo
{
    public partial class Register : Form
    {
        //string connectionString = "data source=Resources\\Users.db;Version=3.40.0;";
        //data source = C:\Users\subed\OneDrive\Documents\NetFrameworkZKTecoAttLogsDemo2\Resources\Users.db


        public Register()
        {
            InitializeComponent();
        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {

            ////string configFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dbconfig.txt");


            //if (!File.Exists(configFile))
            //{
            //    MessageBox.Show("Database not registered. Please register the database first.");
            //    return;
            //}

            //string[] dbDetails = File.ReadAllText(configFile).Split(',');
            //string serverName = dbDetails[0];
            //string databaseName = dbDetails[1];
            string Organization_ID = textBox1.Text;
            string username = UsernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmpassword = cpasswordtextbox.Text;
            string licensekey = txtboxLicense.Text;
            DateTime issuedate = DateTime.Now;
            UserClaim decryptedClaim = EncryptionHelper.Decrypt(licensekey);
            DateTime expiresdate = decryptedClaim.ExpirationDate.Value;
            PostLicenseKey(Organization_ID, issuedate, expiresdate,licensekey);


            //if (string.IsNullOrEmpty(serverName) || string.IsNullOrEmpty(databaseName))
            //{
            //    MessageBox.Show("Please connect to the server ");
            //    return;
            //}

            if (password != confirmpassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (string.IsNullOrEmpty(Organization_ID) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(licensekey))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Office.db");
            string connectionString = $"Data Source={dbFilePath};";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Organization (Organization_ID,Username, Password,LicenseKey) VALUES (@Organization_ID,@Username, @Password, @LicenseKey)";
                    SQLiteCommand command = new SQLiteCommand(query, conn);
                    command.Parameters.AddWithValue("Organization_ID", Organization_ID);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("LicenseKey", licensekey);
                    command.ExecuteNonQuery();

                    MessageBox.Show("User registered successfully!");
                    new LoginForm().Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            
        }

        public async void PostLicenseKey(string Organization_ID, DateTime issuedate, DateTime expiresdate,string licensekey)
        {
            using (HttpClient hc = new HttpClient())
            {
                hc.BaseAddress = new Uri("http://103.140.0.164:8000/api/license");
                var data = new
                {
                  organization = int.Parse(Organization_ID),
                  issue_date= issuedate,
                  expires_date=expiresdate,
                  licensekey
                };

                StringContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                try
                {
                    HttpResponseMessage addlicense = await hc.PostAsync("", content);

                    if (addlicense.IsSuccessStatusCode)
                    {
                        string responsedata = await addlicense.Content.ReadAsStringAsync();
                        Console.WriteLine("Data posted successfully. Response: " + responsedata);

                    }
                    if (!addlicense.IsSuccessStatusCode)
                    {
                        string errorResponse = await addlicense.Content.ReadAsStringAsync();

                        Console.WriteLine($"Error: {addlicense.StatusCode} - {addlicense.ReasonPhrase}");
                        Console.WriteLine("Error Response: " + errorResponse);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    Console.WriteLine($"Exception: {ex.Message}");
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Prevent the character from being entered into the control
                e.Handled = true;
            }
        }
    }
}
