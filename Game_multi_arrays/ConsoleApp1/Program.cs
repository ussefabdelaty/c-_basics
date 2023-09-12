using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the game board
        char[,] board = new char[3, 3] {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        // Initialize the player and game status variables
        char currentPlayer = 'X';
        bool gameFinished = false;
        bool boardFull = false;

        // Main game loop
        while (!gameFinished && !boardFull)
        {
            // Display the current game board
            Console.Clear();
            Console.WriteLine("Current board:");
            DisplayBoard(board);

            // Get the current player's move
            int move = GetPlayerMove(currentPlayer, board);

            // Update the game board with the current player's move
            board[(move - 1) / 3, (move - 1) % 3] = currentPlayer;

            // Check for a winner or a tie
            if (CheckForWin(currentPlayer, board))
            {
                Console.Clear();
                Console.WriteLine("Current board:");
                DisplayBoard(board);
                Console.WriteLine("Player {0} wins!", currentPlayer);
                gameFinished = true;
            }
            else if (CheckForBoardFull(board))
            {
                Console.Clear();
                Console.WriteLine("Current board:");
                DisplayBoard(board);
                Console.WriteLine("The game is a tie.");
                boardFull = true;
            }
            else
            {
                // Switch to the other player
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }
        }

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Display the game board in the console window
    static void DisplayBoard(char[,] board)
    {
        Console.WriteLine(" {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
    }

    // Prompt the current player to enter their move and return the move
    static int GetPlayerMove(char currentPlayer, char[,] board)
    {
        bool validMove = false;
        int move = 0;

        while (!validMove)
        {
            Console.WriteLine("Player {0}, enter your move (1-9):", currentPlayer);
            string input = Console.ReadLine();
            bool parsed = int.TryParse(input, out move);

            if (parsed && move >= 1 && move <= 9)
            {
                int row = (move - 1) / 3;
                int col = (move - 1) % 3;

                if (board[row, col] == 'X' || board[row, col] == 'O')
                {
                    Console.WriteLine("That space is already taken. Please choose another.");
                }
                else
                {
                    validMove = true;
                }
            }
            else
            {
                Console.WriteLine("Invalidmove. Please enter a number between 1 and 9");
            }
        }
        return move;
    }

    // Check if the current player has won the game
    static bool CheckForWin(char currentPlayer, char[,] board)
    {
        // Check for three in a row horizontally
        for (int row = 0; row < 3; row++)
        {
            if (board[row, 0] == currentPlayer && board[row, 1] == currentPlayer && board[row, 2] == currentPlayer)
            {
                return true;
            }
        }

        // Check for three in a row vertically
        for (int col = 0; col < 3; col++)
        {
            if (board[0, col] == currentPlayer && board[1, col] == currentPlayer && board[2, col] == currentPlayer)
            {
                return true;
            }
        }

        // Check for three in a row diagonally
        if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
        {
            return true;
        }

        if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
        {
            return true;
        }

        // No three in a row found
        return false;
    }

    // Check if the game board is full
    static bool CheckForBoardFull(char[,] board)
    {
        // Check if each space on the board has been taken
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (board[row, col] != 'X' && board[row, col] != 'O')
                {
                    return false;
                }
            }
        }

        // The board is full
        return true;
    }
}

//This implementation uses a multi-dimensional array `board` to represent the game board,
//where each cell on the board can be either 'X', 'O', or a number from 1 to 9.
// The main game loop iterates until the game is finished or the board is full,
//and each iteration prompts the current player to enter their move,
//updates the game board with the move, and checks for a winner or a tie.
//The game board is displayed in the console window using the `DisplayBoard` method.

/*The GetValidMove method is used to prompt the player for their move and ensure that the move is valid. 
 * It checks that the move is a number between 1 and 9, 
 * and that the corresponding cell on the board is not already taken.

The CheckForWin method is used to check if the current player has won the game.
It checks for three in a row horizontally, vertically, and diagonally.

The CheckForBoardFull method is used to check if the game board is full and there are no more valid moves left.

Overall, this implementation demonstrates the use of a multi-dimensional array to represent a game board, 
as well as basic control structures such as loops and conditionals.
*/
