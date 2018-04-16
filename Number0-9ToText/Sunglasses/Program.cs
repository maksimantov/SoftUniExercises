using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n >= 3 && n <= 100)
            {
                Console.Write(new string('*', 2 * n));
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', 2 * n));
            }
            else
            {
                Console.WriteLine();
            }

            for (int i = 1; i <= n - 2; i++)
            {
                if (i == (n - 1) / 2)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', 2 * n - 2));
                    Console.Write("*" + new string('|', n) + "*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.WriteLine("*");
                }
                else if (n < 3 && n > 100)
                {
                    Console.WriteLine();
                }
                else if (i != (n - 1) / 2 && n >= 3 && n <= 100)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', 2 * n - 2));
                    Console.Write("*" + new string(' ', n) + "*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.WriteLine("*");
                }
                }

            if (n >= 3 && n <= 100)
            {
                Console.Write(new string('*', 2 * n));
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', 2 * n));
            }
            else
            {
                Console.WriteLine();
            }

        }
    }
}
