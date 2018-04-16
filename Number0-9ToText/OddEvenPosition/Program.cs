using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            double OddSum = 0;
            double EvenSum = 0;
            var OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            var EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            for (var i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (element > OddMax)
                    {
                        OddMax = element;
                    }
                    if (element < OddMin)
                    {
                        OddMin = element;
                    }
                    OddSum += element;
                }
                else if (i % 2 > 0)
                {
                    if (element > EvenMax)
                    {
                        EvenMax = element;
                    }
                    if (element < EvenMin)
                    {
                        EvenMin = element;
                    }
                    EvenSum += element;
                }
            }

            Console.WriteLine("OddSum= " + OddSum);
            if (OddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin= No");
            }
            else
            {
                Console.WriteLine("OddMin= " + OddMin);
            }
            if (OddMax == double.MinValue)
            {
                Console.WriteLine("OddMax= No");
            }
            else
            {
                Console.WriteLine("OddMax= " + OddMax);
            }
            Console.WriteLine("EvenSum= " + EvenSum);
            if (EvenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin= No");
            }
            else
            {
                Console.WriteLine("EvenMin= " + EvenMin);
            }
            if (EvenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax= No");
            }
            else
            {
                Console.WriteLine("EvenMax= " + EvenMax);
            }
        }
    }
}