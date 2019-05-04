using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string nicknamePlayerA = "";
            string nicknamePlayerB = "";
            char markPlayerA = 'x';
            char markPlayerB = 'o';
            char[,] board = new char[3, 3] {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            bool endGame = false;
            while(!endGame)
            {
                Console.Clear();
                DrawBoard(board);
                Console.ReadKey();
            }

            Console.Write("Wpisz imie gracza A: ");
            nicknamePlayerA = Console.ReadLine();
            Console.Write("Wpisz imie gracza B: ");
            nicknamePlayerB = Console.ReadLine();
        }
        static void DrawBoard(char[,] board) 
        {
            int height = board.GetLength(0);
            int width = board.GetLength(1);

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
