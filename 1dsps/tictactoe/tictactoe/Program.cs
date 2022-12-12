using System;

namespace tictactoe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // creating board 
            string[,] board = new string[3,3]
            {
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" },
            };

            // Print board
            printBoard(board);

            // fill board
            string userInput = Console.ReadLine();
            Boolean endGame = false;
            int counter = 0;
            while (endGame == false)
            {
                // Change the number
                counter++;
                board = fillInBoard(board, userInput, counter);
                printBoard(board);

                endGame = checkIfGameFinished(board);

                if (counter == 9 && endGame == false)
                {
                    Console.WriteLine("We got a draw");
                    endGame = true;
                }

                // Ask user info again
                if (endGame == false)
                {
                    userInput = Console.ReadLine();
                }
            }
            
        }

        static void printBoard(string[,] board)
        {
            for(var row = 0; row < board.GetLength(0); row++)
            {
                for (var column = 0; column < board.GetLength(1); column++)
                {
                    Console.Write(board[row, column] + " ");
                }
                Console.WriteLine();
            }
        }

        static Boolean checkIfGameFinished(string[,] board)
        {
            Boolean gameFinished = false;
            string[] symbols = { "x", "o" };

            foreach(string symbol in symbols)
            {
                // horizontal
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    Boolean rowCheck = true;

                    for (int column = 0; column < board.GetLength(1); column++)
                    {
                        if (board[row, column] != symbol)
                        {
                            rowCheck = false;
                        }
                    }

                    if (rowCheck)
                    {
                        Console.WriteLine($"{symbol} is the winner");
                        gameFinished = true;
                    }
                }


                if (
                    // vertically
                    (board[0, 0] == symbol && board[1, 0] == symbol && board[2, 0] == symbol) ||
                    (board[0, 1] == symbol && board[1, 1] == symbol && board[2, 1] == symbol) ||
                    (board[0, 2] == symbol && board[1, 2] == symbol && board[2, 2] == symbol) ||

                    // diagonally
                    (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol) ||
                    (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol) 
                )
                {
                    Console.WriteLine($"{symbol} is the winner");
                    gameFinished = true;
                }
            }
            return gameFinished;
        }

        static string[,] fillInBoard(string[,] board, string number, int counter)
        {
            for (var row = 0; row < board.GetLength(0); row++)
            {
                for (var column = 0; column < board.GetLength(1); column++)
                {
                    if(board[row, column] == number)
                    {
                        if (counter % 2 == 0)
                        {
                            board[row, column] = "x";
                        } else
                        {
                            board[row, column] = "o";
                        }
                    }
                }
            }

            return board;
        }
    }
}


// TIC TAC TOE 
// O: Welcome in the beautiful game of tic tac toe
// O: Current board 
// O: 1 2 3
// O: 4 5 6
// O: 7 8 9

// O: Player1: Pick a number to 
// I: 5
// O: Current board 
// O: 1 2 3
// O: 4 X 6
// O: 7 8 9

// O: Player2: Pick a number to 
// I: 6
// O: Current board 
// O: 1 2 3
// O: 4 X O
// O: 7 8 9