using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StandaloneSDKDemo.Helper
{
    class Email
    {
        static HttpClient client = new HttpClient();
        public void SendMail()
        {
            
            client.BaseAddress = new Uri("http://localhost:8000");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ0b2tlbl90eXBlIjoiYWNjZXNzIiwiZXhwIjoxNzA4MTc1MDMwLCJpYXQiOjE3MDgxNzQ0MzAsImp0aSI6IjIwZTRiMWQ1YjI2ODQ4ODQ5ZTgwNGE3NThmZjdhMWMwIiwidXNlcl9pZCI6ImQ5NDlkOTk0LTk3YjAtNDE0Zi1iNTUxLTlmMzE1ZGY4YmY3NiJ9.hG3MDCfW9oLxdqiWGTCjWAAWEy4q9E6_QV4sONuZQJk");
            var response = client.PostAsync("api/device/email", null);
        }


    }
}
