using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var row = 0; row < n; row++)
            {
                for (var column = 0; column < n; column++)
                {
                    var number = row + column + 1;
                    if (number > n)
                    {
                        number = 2 * n - number;
                    }
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
