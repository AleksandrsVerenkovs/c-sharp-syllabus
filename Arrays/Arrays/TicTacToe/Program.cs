using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            bool gameWon = false;

            Random random = new Random();
            char playerTurn = ' ';
            int countMoves = 0;
            playerTurn = random.Next(0, 2) == 0 ? 'X' : 'O';
         
            Console.WriteLine($"{playerTurn} goes first!\n");
            InitBoard();
            while (!gameWon)
            {
                if(Winner() == 'X' || Winner() == 'O')
                {
                    DisplayBoard();
                    Console.WriteLine($"{Winner()} is winner!");
                    break;
                }
               
                DisplayBoard();

                Console.Write($"{playerTurn}, choose your location (row, column): ");
                var inputX = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.Write(" ");
                var inputY = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine();

                if (board[inputX,inputY] == ' ')
                {
                    board[inputX, inputY] = playerTurn;
                    playerTurn = playerTurn == 'X' ? 'O' : 'X';
                }
                if (countMoves == 8 && Winner() == '-')
                {
                    Console.WriteLine("It's a tie!");
                    break;
                }
                countMoves++;
            }
            Console.ReadLine();
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
            
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine();
        }
        private static char Winner()
        {
            //Horizontal
            if(board[0,0] == board[0,1] && board[0,1] == board[0, 2])
            {
                return board[0,0];
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                return board[1, 0];
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                return board[2, 0];
            }
            //Vertical
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                return board[0, 0];
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            {
                return board[0, 1];
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                return board[0, 2];
            }
            //Diagonal
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 0];
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[0, 2])
            {
                return board[0, 2];
            }
            else
            {
                return '-';
            }
        }
    }
}
