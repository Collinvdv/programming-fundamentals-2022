using System;
using System.Collections.Generic;

namespace band_generator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string commando = getCommando();

            while (commando != "stop")
            {
                Console.WriteLine(getRandomBandname());

                // Asking it again
                commando = getCommando();
            }
        }

        static string getRandomBandname()
        {
            // bandname creator
            List<string> words1 = new List<string>() { "the", "a", "not", "all" };
            List<string> words2 = new List<string>() { "ugly", "awesome", "nice", "perfect", "hardcore" };
            List<string> words3 = new List<string>() { "pigeon", "student", "bird", "flower", "jebus", "satan", "bro" };
            
            return $"{getRandomItem(words1)} {getRandomItem(words2)} {getRandomItem(words3)}";
        }

        static string getRandomItem(List<string> list)
        {
            Random randomWordIndex = new Random();

            return list[randomWordIndex.Next(0, list.Count)];
        }

        static string getCommando()
        {
            Console.WriteLine("Command YES to ask a new band name, Command STOP to stop the game");
            return Console.ReadLine().ToLower();
        }
    }
}
