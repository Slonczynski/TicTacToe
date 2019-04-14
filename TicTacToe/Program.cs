using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.Write("Wpisz imie gracza A: ");
            nicknamePlayerA = Console.ReadLine();
            Console.Write("Wpisz imie gracza B: ");
            nicknamePlayerB = Console.ReadLine();
        }
    }
}
