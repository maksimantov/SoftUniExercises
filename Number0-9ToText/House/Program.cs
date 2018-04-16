using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;

            if (n % 2 == 0)
            {
                stars++;
            }
            var rooflength = (int)Math.Ceiling(n / 2f);
           
            for (int i = 0; i < rooflength; i++)
            {
                var background = (n - stars) / 2;
                Console.Write(new string('-', background));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', background));
                stars += 2;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');
            }
        }
    }
}
