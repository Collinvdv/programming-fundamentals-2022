using System;
using System.Collections.Generic;
using System.Timers;

namespace methods_practicum
{
    class MainClass
    {
        private static int seconds;
        public static void Main(string[] args)
        {
            Timer timer = new Timer(1000);
            timer.Enabled = true;
            timer.Elapsed += OnTimedEvent;
            string word = Console.ReadLine();
            Console.WriteLine(word);
            Console.WriteLine($"Stop seconds {seconds}");
        }

        static Dictionary<char, int> countCharsFromWord(string word)
        {
            Dictionary<char, int> countChars = new Dictionary<char, int>();

            foreach(char c in word)
            {
                if (countChars.ContainsKey(c))
                {
                    countChars[c] = countChars[c] + 1;
                } else
                {
                    countChars[c] = 1;
                }
            }

            return countChars;
        }

        static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            seconds++;
        }

    }
}


// A word in which no letter of the alphabet occurs more than once is an isogram. Read in a word and check if it is an isogram!

// TESTCASES
// I: dermatoglyphics
// O: true
// I: patterns
// O: false

