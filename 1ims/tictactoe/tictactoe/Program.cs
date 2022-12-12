using System;

namespace tictactoe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Start new 
            string[] currentBoard = newCurrentBoard();

            // Show current board
            showCurrentBoard(currentBoard);

            // Fill in the board
            Boolean endGame = false;
            int counter = 0;
            while (endGame == false)
            {
                // fill in the symbol
                currentBoard = fillCurrentBoard(currentBoard, counter);
                counter++;

                // Show current board
                showCurrentBoard(currentBoard);

                // Check if game eneded
                string winner = checkGameEnded(currentBoard);

                if (winner.Length != 0)
                {
                    Console.WriteLine("Winner is " + winner);
                    endGame = true;
                }

                if (counter == 9 && endGame == false)
                {
                    Console.WriteLine("This game ended in a draw");
                }
            }
        }

        static string checkGameEnded(string[] currentBoard)
        {
            string[] symbols = { "x", "o" };
            string winner = "";

            foreach (string symbol in symbols)
            {
                if (
                    // Horizontal
                    (currentBoard[0] == symbol && currentBoard[1] == symbol && currentBoard[2] == symbol) ||
                    (currentBoard[3] == symbol && currentBoard[4] == symbol && currentBoard[5] == symbol) ||
                    (currentBoard[6] == symbol && currentBoard[7] == symbol && currentBoard[8] == symbol) ||

                    // vertizal
                    (currentBoard[0] == symbol && currentBoard[3] == symbol && currentBoard[6] == symbol) ||
                    (currentBoard[1] == symbol && currentBoard[4] == symbol && currentBoard[7] == symbol) ||
                    (currentBoard[2] == symbol && currentBoard[5] == symbol && currentBoard[8] == symbol) ||

                    // diagonal
                    (currentBoard[0] == symbol && currentBoard[5] == symbol && currentBoard[8] == symbol) ||
                    (currentBoard[2] == symbol && currentBoard[4] == symbol && currentBoard[6] == symbol) 
                )
                {
                    winner = symbol;
                }

            }
            return winner;
        }
        static string[] fillCurrentBoard(string[] board, int counter)
        {
            string symbol = "x";

            if (counter % 2 == 0)
            {
                symbol = "o";
            }
            int player1choice = Convert.ToInt16(Console.ReadLine());

            board[player1choice - 1] = symbol;

            return board;
        }

        static void showCurrentBoard(string[] board)
        {
            for (var index = 0; index < board.Length; index++)
            {
                Console.Write(board[index] + " ");

                if ((index + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        static string[] newCurrentBoard()
        {
            string[] board = new string[9];

            for(var index = 1; index <= 9; index ++)
            {
                board[index - 1] = Convert.ToString(index);
            }

            return board;
        }
    }
}
