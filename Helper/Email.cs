using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StandaloneSDKDemo.Helper
{
    class Email
    {
        // Static HttpClient instance for reuse
        static HttpClient client = new HttpClient();

        // SendMail method that sends a single email
        public async Task SendMail()
        {
            // Configure HttpClient instance for sending requests
            client.BaseAddress = new Uri("http://localhost:8000");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Example: Sending the POST request with null content (you can adjust this to fit your needs)
            var content = new StringContent(""); // Adjust content as necessary

            try
            {
                // Make the HTTP POST request asynchronously
                var response = await client.PostAsync("/device/email", content);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Email sent successfully!");
                }
                else
                {
                    Console.WriteLine($"Failed to send email. Status: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Method to send multiple emails concurrently
        public async Task SendMultipleMails(int numberOfMails)
        {
            // List to hold tasks for concurrent execution
            List<Task> tasks = new List<Task>();

            // Example: Send multiple emails concurrently (you can change the number of requests as needed)
            for (int i = 0; i < numberOfMails; i++)
            {
                // Use Task.Run to execute SendMail asynchronously for each email
                tasks.Add(SendMail());
            }

            // Wait for all tasks to complete
            await Task.WhenAll(tasks);  // This ensures all emails are sent before continuing

            Console.WriteLine("All emails are being sent concurrently.");
        }
    }
}
