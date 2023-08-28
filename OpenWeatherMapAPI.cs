using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace OpenWeatherMap_Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            // Console.Writeline("Pleas eenter your API key:");
            var key = "25203b0d192fe0fd09e15a918c180fd4";
            var city = "Atlanta";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?lat=44.34&lon=10.99&appid={key}";
            var response = client.GetStringAsync(weatherURL).Result;

            JObject formattedResponse = JObject.Parse(response);
            var temp = formattedResponse["list"][0]["main"]["temp"];
            Console.WriteLine(temp);

        https://www.newtonsoft.com/json/help/html/QueryingLINQtoJSON.htm
            
            while (true) 
            {
                Console.WriteLine();
                Console.WriteLine("Please eneter the city name: ");
                var city_name = Console.ReadLine();
                Console.WriteLine();

                var resposnse = client.GetStringAsync($"https://api.openweathermap.org/data/2.5/weather?q={city_name}&units=imperial&appid={key}").Result;
                Console.WriteLine($"The current Tempaerature is{JObject.Parse(JObject.Parse(resposnse).GetValue("main").ToString()).GetValue("temp")}degrees Farhrenheit");
                AddSpaces(2);
                Console.WriteLine("Would you like to exit?");
                var userInput = Console.ReadLine(); 
                AddSpaces(2);

                if (userInput.ToLower().Trim() == "yes")
                {
                    break;
                }
            }
    }
        static void AddSpaces(int numberOfSpaces)
        {
            while (numberOfSpaces != 0)
            {
                Console.WriteLine();
                numberOfSpaces--;
            }
        }

    }
}
