using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if ((a >= 100 && a <= 200) || a == 0)
            {
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
