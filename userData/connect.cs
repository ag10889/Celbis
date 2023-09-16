using System;
using System.IO;
using System.Net.Sockets;
using static System.Net.WebRequestMethods;

namespace userDatabase
{
    public class connect
    {
        static async Task Main()
        {
            try
            {
                string url = "https://par-x.vercel.app/reserve.html";
                HttpClient client = new HttpClient();

                // Send a GET request to the URL
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine("HTTP Request Failed: " + response.StatusCode);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
    }
}




