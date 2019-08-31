using System;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            char square = ' ';

            for (int i = 0; i < 64; i++)
            {
                Console.Write(square);
                
                if ((i + 1) % 8 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    square = square == ' ' ? '#' : ' ';
                }
            }

            Console.ReadLine();
        }
    }
}
