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
            //string username = UsernameTextBox.Text;
            //string password = passwordTextBox.Text;
            //string confirmpassword = cpasswordtextbox.Text;
            //string licenseKey = Keytextbox.Text;

            //if (password != confirmpassword)
            //{
            //    MessageBox.Show("Passwords do not match.");
            //    return;
            //}

            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(licenseKey))
            //{
            //    MessageBox.Show("All fields are required.");
            //    return;
            //}

            //using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            //{
            //    try
            //    {
            //        conn.Open();

            //        string query = "INSERT INTO User (Username, Password, LicenseKey) VALUES (@Username, @Password, @LicenseKey)";
            //        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@Username", username);
            //            cmd.Parameters.AddWithValue("@Password", password);
            //            cmd.Parameters.AddWithValue("@LicenseKey", licenseKey);

            //            int result = cmd.ExecuteNonQuery();

            //            if (result > 0)
            //            {
            //                MessageBox.Show("User registered successfully.");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Registration failed.");
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("An error occurred: " + ex.Message);
            //    }
            //}
            new LoginForm().Show();
            this.Hide();
        }

    }
}
