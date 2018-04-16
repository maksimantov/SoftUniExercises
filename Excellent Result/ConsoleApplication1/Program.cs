using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstnum = n % 10;
            n = n / 10;
            var secondnum = n % 10;
            n = n / 10;
            var lastnum = n % 10;

            for (int i = 1; i <= firstnum; i++)
            {
                for (int j = 1; j <= secondnum; j++)
                {
                    for (int k = 1; k <= lastnum; k++)
                    {
                        var result = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {result} ");
                    }

                  }
            }
        }
    }
}
