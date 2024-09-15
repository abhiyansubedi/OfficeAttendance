namespace StandaloneSDKDemo.Models
{
    class RegisterRequest
    {
        public string email { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DbCredential database_credential { get; set; }
    }
}
