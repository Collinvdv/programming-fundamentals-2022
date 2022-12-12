using System;
using System.Collections.Generic;
using System.IO;

namespace goldenboot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // O: The winner is Lionel Messi with 3 votes
            string[] lines = File.ReadAllLines("votes.txt");
            Dictionary<string, List<string>> votingBook = new Dictionary<string, List<string>>();

            // ADD DATA IN OUR BEAUTIFULL VOTING BOOK
            foreach (string line in lines)
            {
                // getting the data
                string voter = line.Split('-')[0].Trim();
                string player = line.Split('-')[1].Trim();

                // adding it to my beautiful votingbook <3 <3 <3
                if (votingBook.ContainsKey(player))
                {
                    votingBook[player].Add(voter);
                } else
                {
                    votingBook[player] = new List<string>();

                    votingBook[player].Add(voter);
                }
            }

            string winner = getWinner(votingBook);
            Console.WriteLine(winner);

            string loser = getLoser(votingBook);
            Console.WriteLine(loser);
        }

        static string getWinner(Dictionary<string, List<string>> votingbook)
        {
            int votes = 0;
            string winner = "";

            foreach (var row in votingbook)
            {
                if (row.Value.Count > votes)
                {
                    votes = row.Value.Count;
                    winner = row.Key;
                } else if (row.Value.Count == votes)
                {
                    winner += $", {row.Key}";
                }
            }

            return winner;
        }

        static string getLoser(Dictionary<string, List<string>> votingbook)
        {
            int votes =  999999;
            string loser = "";

            foreach (var row in votingbook)
            {
                if (row.Value.Count < votes)
                {
                    votes = row.Value.Count;
                    loser = row.Key;
                }
                else if (row.Value.Count == votes)
                {
                    loser += $", {row.Key}";
                }
            }

            return loser;
        }
    }
}
