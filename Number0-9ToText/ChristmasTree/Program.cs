using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = "*";

            Console.Write(new string(' ', n + 1));
            Console.WriteLine('|');

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(stars);
                Console.Write(" | ");
                Console.WriteLine(stars);
                stars += "*";
            }
        }
    }
}
