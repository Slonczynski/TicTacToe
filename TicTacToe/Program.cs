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
            char[,] boardCopy = board.Clone() as char[,];

            bool endGame = false;
            bool playerMoveA = ture;
            for (int round = 0; round < board.Length; ++round)
            {
                Console.Clear();
                DrawBoard(board);
                    if (playerMoveA)
                    {
                        Console.WriteLine("Ruch wykonuje: " + gA.Name);
                        endGame = gA.MakeMove(board, boardCopy);
                        playerMoveA = false;
                    }  
                    else
                    {
                        Console.WriteLine("Ruch wykonuje: " + gB.Name);
                        endGame = gB.MakeMove(board, boardCopy);
                        playerMoveA = true;
                    }
            Console.ReadKey();
            }
        }
        static void DrawBoard(char[,] board, char[,] boardCopy) 
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
        bool MakeMove(char[,] board, char[,] boardCopy);
    }
    abstract class Player
    {
        public string Name { get; set; }
        public char Sign { get; set; }

        public bool CheckIfGameEnded(char[,] board)
        {
            int height = board.GetLength(0);
            int width = board.GetLength(1);
            if (height != width)
                throw new Exception("Plansza nie jest kwadratowa!");

            // check lines

            for (int i = 0; i < width; i++) 
            {
                int sumLine = 0;
                for (int i = 0; i < width; ++j)
                {
                if (board[i,j] == Sign)
                        ++sumLine;
                }
            if (sumLine == width)
                    return true;
            }
        
            for (int j = 0; j < height; i++) 
            {
                int sumLine = 0;
                for (int j = 0; j < height; ++j)
                {
                if (board[i,j] == Sign)
                        ++sumLine;
                }
            if (sumLine == height)
                    return true;
            }

        // Check crosses

        int sumCrossA = 0;
        int sumCrossB = 0;
        for (int k = 0; k < width; ++k)
        {
            if (board[k,k] == Sign)
                ++sumCrossA;
            if (board[k, width - 1 - k] == Sign)
                ++sumCrossB;
        }
        if (sumCrossA == width || sumCrossB == width)
                return true;


        // If doesnt match any
        return false;
        }

    class HumanPlayer : Player, IMove 
    {
        public bool MakeMove(char[,] board, char[,] boardCopy)
        {
            return CheckIfGameEnded(board);
        }
    }

    class ComputerPlayer : Player, IMove 
    {
        public bool MakeMove(char[,] board, char[,] boardCopy)
        {
            return CheckIfGameEnded(board);
        }
    }
}
