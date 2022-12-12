using System;

namespace chatbot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "stop")
            {
                // answer bot
                answerBot(userInput);

                // user input
                userInput = Console.ReadLine();
            }
        }

        static void answerBot(string userInput)
        {
            // Answers 
            string[] good = { "Nice", "sweet", "Yihaah" };
            string[] neutral = { "I can imagine", "whuuuut", "what the hell" };
            string[] bad = { "Oh no", "Such a shame", "Tell me more" };

            // Response
            if (userInput.Contains("good")) {
                Console.WriteLine(randomWord(good));
            } else if (userInput.Contains("bad"))
            {
                Console.WriteLine(randomWord(bad));
            } else
            {
                Console.WriteLine(randomWord(neutral));
            }
        }

        static string randomWord(string[] words)
        {
            Random random = new Random();
            return words[random.Next(0, words.Length)];
        }
    }
}

// Chatbot 
// O: Hello HumanBeing, I am an ChatBot. 
// O: End when they type STOP
// O: How are you?
// I: Good, 
// O: that is nice! 
// I: I think that weather is bad today
// O: Oh no.. 
// I: Yes, is going to rain.
// O: Really? 
// I: Yes. I hate programming
// O: I can imagine
// GOOD → [Nice, Sweet, Yihaah]
// NEUTRAL → [I can imagine, okay, tell me more, .. ] 
// BAD → [Oh no, tell me more, ..]