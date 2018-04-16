using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 3 * n + 6;
            var heigth = 3 * n + 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n));
                Console.WriteLine("~ ~ ~");
            }
            Console.WriteLine(new string('=', width - 1));

            for (int i = 1; i <= n - 2; i++)
            {
                if (i == n / 2)
                {
                    Console.Write("|");
                    Console.Write(new string('~', n));
                    Console.Write("JAVA");
                    Console.Write(new string('~', n));
                    Console.Write("|");
                    Console.Write(new string(' ', n - 1));
                    Console.WriteLine("|");
                }
                else
                {
                    Console.Write("|");
                    Console.Write(new string('~', n));
                    Console.Write("~~~~");
                    Console.Write(new string('~', n));
                    Console.Write("|");
                    Console.Write(new string(' ', n - 1));
                    Console.WriteLine("|");
                }
            }
                Console.WriteLine(new string('=', width - 1));

            var middle = 2 * n + 4;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write("\\");
                Console.Write(new string('@', middle));
                Console.WriteLine("/");
                middle -= 2;
            }
            Console.WriteLine(new string('=', width - n));
        }
    }
}
