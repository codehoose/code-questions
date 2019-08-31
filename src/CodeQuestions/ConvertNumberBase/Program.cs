using System;

namespace ConvertNumberBase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                8 / 2       4       0
                4 / 2       2       0
                2 / 2       1       0
                1 / 2       0       1

                1000b == 8d
             */

            var starting = 255;
            var number = starting;
            var radix = 8;

            var output = "";

            while (number != 0)
            {
                var remainder = number % radix;
                number = number / radix;
                output = remainder.ToString() + output;
            }

            Console.WriteLine($"{starting} in octal is {output}");
            Console.ReadLine();
        }
    }
}
