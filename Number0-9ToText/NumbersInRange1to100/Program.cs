using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInRange1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            while (1 > n || n > 100)
            {     
                    Console.WriteLine("Invalid number!");
                    n = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("The number is: " + n);
        }
    }
}
