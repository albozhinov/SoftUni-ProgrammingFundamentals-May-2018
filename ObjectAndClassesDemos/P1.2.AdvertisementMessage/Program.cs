using System;

namespace P1._2.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
                      
            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category",
                "Exceptional product.",
                "I can't live without this product."
            };
            
            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now i feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!",
            };
            
            string[] authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            Random number = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                var phrase = number.Next(0, phrases.Length - 1);
                var randomEvent = number.Next(0, events.Length - 1);
                var author = number.Next(0, authors.Length - 1);
                var city = number.Next(0, cities.Length - 1);
                
                Console.WriteLine($"{phrases[phrase]} {events[randomEvent]} {authors[author]} - {cities[city]}");
            }
        }
    }
}
