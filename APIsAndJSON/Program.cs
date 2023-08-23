using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
     public class Program
    {
       

        static void Main(string[] args)
        {
            var client = new HttpClient(); // new object that allows request to be made to internet

            var kanyeURL = "https://api.kanye.rest/"; // api URL

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"{kanyeQuote}");
        }
       
        }
}
