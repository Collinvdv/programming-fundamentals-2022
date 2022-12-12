using System;
using System.Collections.Generic;
using System.IO;

namespace goldenboot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Golden boot voting
            // Create text file 
            // Collin - Lionel Messi 
            // Elke - Kevin De Bruyne 
            // Tristan - Lionel Messi 
            // Charlie - Lionel Messi 
            // O: Lionel Messi is the winner
            string[] lines = File.ReadAllLines("result.txt");
            Dictionary<string, List<string>> votingboard = new Dictionary<string, List<string>>();

            // Reading the votes
            foreach(string line in lines)
            {
                string voter = line.Split('-')[0].Trim();
                string player = line.Split('-')[1].Trim();

                if (votingboard.ContainsKey(player))
                {
                    votingboard[player].Add(voter);
                } else
                {
                    votingboard[player] = new List<string>();
                    votingboard[player].Add(voter);
                }
            }

            // Output final result
            foreach(string player in votingboard.Keys)
            {
                Console.WriteLine($"{player} has {votingboard[player].Count} votes");
            }
        }
    }
}
