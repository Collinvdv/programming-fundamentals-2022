using System;

namespace methods_band
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // AWESOME BANDNAME GENERATOR with 3 words
            //  => give me 1 random item back
            //  => give me 1 random item back
            //  => give me 1 random item back
            // Command YES or ADD NEW  to add new band name, Command STOP to stop the game

            // O: New band Commands [YES, STOP]
            // I: Yes
            // O: The nice jebus

            // O: New band Commands [YES, STOP]
            // I: Yes
            // O: Not awesome student
            string commando = getCommando();

            while (commando != "stop")
            {
                // awesome band generator
                // O: The band is 
                generateBandName();

                // Input commando
                commando = getCommando();
            }
        }

        static void generateBandName() {
            string[] words1 = { "the", "a", "not", "all" };
            string[] words2 = { "ugly", "awesome", "nice", "perfect", "hardcore" };
            string[] words3 = { "pigeon", "student", "bird", "flower", "jebus", "santan" };

            Console.WriteLine($"{getRandomItem(words1)} {getRandomItem(words2)} {getRandomItem(words3)}");
        }

        static string getRandomItem(string[] list)
        {
            Random randomWord = new Random();

            int randomListIndex = randomWord.Next(0, list.Length);

            return list[randomListIndex];
        }

        static string getCommando()
        {
            Console.WriteLine("New band Commands [YES, STOP]");
            return Console.ReadLine().ToLower();
        }
    }
}
