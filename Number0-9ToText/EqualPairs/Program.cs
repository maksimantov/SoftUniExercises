using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int newSum = 0;
            int oldSum = 0;
            int diff = 0;
            int maxDiff = 0;

            for (int i = 0; i < n; i++)
            {
                oldSum = newSum;
                newSum = 0;
                newSum = newSum + int.Parse(Console.ReadLine());
                newSum = newSum + int.Parse(Console.ReadLine());
                if (i != 0)
                {
                    diff = Math.Abs(newSum - oldSum);
                    if (diff != 0 && diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                            }
                        }
            if (newSum == oldSum || n == 1)
            {
                Console.WriteLine("Yes, value=" + newSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + maxDiff);
            }
        }
    }
}
