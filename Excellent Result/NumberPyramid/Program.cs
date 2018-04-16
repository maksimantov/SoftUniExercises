using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 1;
            for (var row = 1; row <= n; row++)
            {
                for (var column = 1; column <= row; column++)
                {
                    if (column > 1)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(number);
                    number++;
                    if (number > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (number > n)
                {
                    break;
                }
            }
        }
    }
}
