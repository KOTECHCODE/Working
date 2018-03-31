using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirageloto
{
    class Program
    {
        
        static void Main(string[] args)
        {
          SearchRandomNumber();
        }

        static void SearchRandomNumber()
        {
            Random num = new Random();
            int[] board = new int[8];
            for (int i = 1; i < 8; i++)
            {
                int randomnumber = num.Next(1, 60); //59 inclus
                if (!board.Contains(randomnumber))
                {
                    board[i] = randomnumber;
                    Console.WriteLine($"Le tirage numéro {i} est le {board[i]}");
                }
            }
        }
    }
}
