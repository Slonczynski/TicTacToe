using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanPlayer gA = new HumanPlayer();
            ComputerPlayer gB = new ComputerPlayer();

            gA.Name = "User";
            gB.Name = "Computer";
            gA.Sign = "x";
            gB.Sign = "o";

       
            char[,] board = new char[3, 3] {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            bool endGame = false;
            bool playerMoveA = ture;
            while(!endGame)
            {
                Console.Clear();
                DrawBoard(board);
                if (playerMoveA)
                    {
                Console.WriteLine("Ruch wykonuje: " + gA.Name);
                endGame = gA.MakeMove(board);
                playerMoveA = false;
                    }  
                else
                    {
                Console.WriteLine("Ruch wykonuje: " + gB.Name);
                    endGame = gB.MakeMove(board);
                    playerMoveA = true;
}
                Console.ReadKey();
            }
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
    interface IMove
    {
        bool MakeMove(char[,] board);
    }
    abstract class Player
    {
        public string Name { get; set; }
        public char Sign { get; set; }
    }
        class HumanPlayer : Player, IMove 
        {
        public bool MakeMove(char[,] board)
        {
        return false;
        }
        }

       class ComputerPlayer : Player, IMove 
        {
            public bool MakeMove(char[,] board)
            {
            return false;
            }
        }
}
