using System;
using System.Collections.Generic;
using System.IO;

namespace blackjack
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // New dictionairy
            int playerTotalPoints = playerCards();

            if (playerTotalPoints < 21)
            {
                int computerTotalPoints = computerCards();

                finishGame(computerTotalPoints, playerTotalPoints);
            }
            else
            {
                Console.WriteLine("COMPUTER WINS, player was bust");
            }
        }

        static void finishGame(int computerTotalPoints, int playerTotalPoints)
        {
            if (computerTotalPoints > 21)
            {
                Console.WriteLine("PLAYER WINS, computer was bust");
            }
            else
            {
                if (computerTotalPoints == playerTotalPoints)
                {
                    Console.WriteLine("WE GOT A DRAW");
                }
                else if (computerTotalPoints > playerTotalPoints)
                {
                    Console.WriteLine($"COMPUTER WINS, COMPUTER {computerTotalPoints} - PLAYER {playerTotalPoints}");
                }
                else
                {
                    Console.WriteLine($"PLAYER WINS, COMPUTER {computerTotalPoints} - PLAYER {playerTotalPoints}");
                }
            }
        }
        static int playerCards()
        {
            int score = 0;
            string newCard = "";

            while (newCard != "no")
            {
                int randomCard = getRandomCard();
                Console.WriteLine($"Your card is {randomCard}");

                if (randomCard == 1)
                {
                    Console.WriteLine("1 is an ace . Option A: 1 point, Option B: 11 points [A or B]");
                    string option = Console.ReadLine().ToLower();

                    if (option == "a")
                    {
                        score += 1;
                    } else
                    {
                        score += 11;
                    }
                } else
                {
                    score += randomCard;
                }
                
                Console.WriteLine($"Your total points are {score}");

                // Ask if they want a new card
                if (score > 21)
                {
                    Console.WriteLine("Player is bust");
                    newCard = "no";
                } else
                {
                    Console.WriteLine("Do you want a new card?");
                    newCard = Console.ReadLine();
                }
            }
            return score;
        }

        static int computerCards()
        {
            int score = 0;
            Boolean computerIsDone = false;

            while (computerIsDone == false)
            {
                int randomCard = getRandomCard();
                score += randomCard;

                Console.WriteLine($"The dealer has card {randomCard}, so {score} in total;");

                if (score > 21)
                {
                    computerIsDone = true;
                    Console.WriteLine("The computer is bust");
                } else if (score == 21) {
                    computerIsDone = true;
                    Console.WriteLine("Computer will stop because he has 21");
                } else if (score >= 12) {
                    Random random = new Random();

                    if (random.Next(0, 2) == 0)
                    {
                        computerIsDone = true;
                        Console.WriteLine("Computer is afraid, and he wants to stop");
                    } else
                    {
                        Console.WriteLine("Computer is feeling confident, he wants a new card");
                    }
                }
            }


            return score;
        }
        static int getRandomCard()
        {
            Random random = new Random();

            
            return random.Next(1, 14);
        }

   
    }
}
// Blackjack
// O: Welcome to the blackjack table 
// O: Commands
//      ----- CASE 1 ------
//      O: Your card is 5
//.     O:, Your total points are 5 want a new card? [Yes or No]
//      I: Yes
//      O: Your card is 1
//.     O: 1 is an ace . Option A: 1 point, Option B: 11 points [A or B]
//.     I: B
//.     O: Your total points are 16 want a new card? [Yes or No]
//      I: Yes
//      O: Your card is 3
//      O: Your total points are 19 want a new card? [Yes or No]
//.      I: No
//      O: Your total points are 19, lets see what the dealer does.
//      O: The dealer has card 5, so 5 in total;
//      O: The dealer wants a new card
//      O: The dealer has card 10, so 15 in total;
//      O: The dealer wants a new card
//      O: The dealer has card 8, so 23 in total;
//      O: The dealer is broke, player1 wins