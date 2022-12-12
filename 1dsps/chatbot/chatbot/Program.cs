using System;

namespace chatbot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // the beginning of the conversation
            Console.WriteLine(" Hello HumanBeing, I am an ChatBot. ");
            Console.WriteLine(" Type stop to leave the conversation ");
            Console.WriteLine(" How are you?");

            //
            string userInput = Console.ReadLine();

            while (userInput != "stop")
            {
                // chatbot will speak
                botAnswers(userInput);
                
                // user input
                userInput = Console.ReadLine();
            }
        }

        static void botAnswers(string phrase)
        {
            string[] positiveAnswers = { "Niceeeeee", "Sweeeet", "Good for youuuu" };
            string[] negativeAnswers = { "Oh no...", "Such a shame", "I feel bad for you" };
            string[] neutralAnswers = { "Go on", "Oh", "Continue", "Tell me more" };

            string vibe = getVibeOfPhrase(phrase);

            switch (vibe)
            {
                case "positive":
                    Console.WriteLine(getRandomWord(positiveAnswers));
                    break;
                case "negative":
                    Console.WriteLine(getRandomWord(negativeAnswers));
                    break;
                case "neutral":
                    Console.WriteLine(getRandomWord(neutralAnswers));
                    break;
            }

        }

        static string getRandomWord(string[] phrases)
        {
            Random random = new Random();
            return phrases[random.Next(0, phrases.Length)];
        }

        static string getVibeOfPhrase(string phrase)
        {
            string vibe = "neutral";

            // lets check if is positive
            if(phrase.ToLower().Contains("good"))
            {
                vibe = "positive";
            } else if (phrase.ToLower().Contains("bad"))
            {
                vibe = "negative";
            }

            return vibe;
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