using System;
using System.Collections.Generic;

namespace _01.Advertisement_Message
{
    class AdvertisementMessage
    {
        static void Main()
        {
            string[] phrases = {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };

            string[] events = {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfMsg = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < numberOfMsg; i++)
            {
                int randIndex = random.Next(phrases.Length);
                Console.Write(phrases[randIndex] + " ");
                randIndex = random.Next(events.Length);
                Console.Write(events[randIndex] + " ");
                randIndex = random.Next(authors.Length);
                Console.Write(authors[randIndex] + " - ");
                randIndex = random.Next(cities.Length);
                Console.WriteLine(cities[randIndex]);
            }
        }
    }
}
