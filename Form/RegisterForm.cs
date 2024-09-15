using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using StandaloneSDKDemo.Models;

namespace StandaloneSDKDemo
{
    public partial class RegisterForm : UserControl
    {
        static HttpClient client = new HttpClient();
        public RegisterForm(Main Parent)
        {
            InitializeComponent();
            Register = Parent;
        }
        private Main Register;

        private async void registerButton_ClickAsync(object sender, EventArgs e)
        {

            // Put the following code where you want to initialize the class
            // It can be the static constructor or a one-time initializer
            client.BaseAddress = new Uri("http://localhost:8000");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                var registerRequest = new RegisterRequest() {
                email = emailTextBox.Text,
                password = passwordTextBox.Text,
                first_name = firstNameTextBox.Text,
                last_name = lastNameTextBox.Text,
                database_credential = new DbCredential()
                {
                    host= dbHostTextBox.Text,
                    port= int.Parse(dbPortTextBox.Text),
                    name= dbNameTextBox.Text,
                    user= dbUserTextBox.Text,
                    password= dbPasswordTextBox.Text,
                }

            };
            var response = await client.PostAsJsonAsync("api/account/register", registerRequest);
            if (response.IsSuccessStatusCode)
                MessageBox.Show("Register success");
        }

    }
}
