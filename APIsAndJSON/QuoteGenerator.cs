using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient(); // new object that allows request to be made to internet

            var kanyeURL = "https://api.kanye.rest/"; // api URL

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"------");
            Console.WriteLine($"{kanyeQuote}");
            Console.WriteLine($"------");
        }
        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Trim();

            Console.WriteLine($"------");
            Console.WriteLine($"{ronQuote}");
            Console.WriteLine($"------");
        }

      
        

            
        
    }
}

