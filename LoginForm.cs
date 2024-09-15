using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using AccessKeyDemo;
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
            //Cursor = Cursors.WaitCursor;
            //string myConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            //conn = new SqlConnection(myConnectionString);
            //conn.Open();
            //Cursor = Cursors.Default;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {

            //string username = UsernameTextBox.Text;
            //string password = passwordTextBox.Text;


            //using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            //{
            //    conn.Open();
            //    string query = "SELECT LicenseKey FROM User WHERE Username = @Username AND Password = @Password";

            //    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            //    {

            //        cmd.Parameters.AddWithValue("@Username", username);
            //        cmd.Parameters.AddWithValue("@Password", password);




            //        object result = cmd.ExecuteScalar();

            //        if (result != null)
            //        {
            //            string LicenseKey = result.ToString();
            //            UserClaim decryptedClaim = EncryptionHelper.Decrypt(LicenseKey);

            //            if (decryptedClaim != null)
            //            {
            //                if (decryptedClaim.ExpirationDate.HasValue)
            //                {
            //                    DateTime expirationDate = decryptedClaim.ExpirationDate.Value;
            //                    if (expirationDate.Date >= DateTime.Now.Date)
            //                    {

            //                        new Main().Show();
            //                    }
            //                    else
            //                    {

            //                        MessageBox.Show("Your license has expired.");
            //                    }
            //                }
            //            }
            //        }


            //        else
            //        {

            //            MessageBox.Show("Invalid username or password.");
            //        }
            //    }
            //}
            new Main().Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            new Register().Show();
            this.Hide();
        }
    }
}
