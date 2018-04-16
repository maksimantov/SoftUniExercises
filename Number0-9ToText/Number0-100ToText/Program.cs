using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int d1 = 0;
            int d2 = 0;

            if (num >= 0 && num <= 19)
            {
                if (num == 0)
                    Console.WriteLine("zero");

                else if (num == 1)
                    Console.WriteLine("one");

                else if (num == 2)
                    Console.WriteLine("two");

                else if (num == 3)
                    Console.WriteLine("three");

                else if (num == 4)
                    Console.WriteLine("four");

                else if (num == 5)
                    Console.WriteLine("five");

                else if (num == 6)
                    Console.WriteLine("six");

                else if (num == 7)
                    Console.WriteLine("seven");

                else if (num == 8)
                    Console.WriteLine("eight");

                else if (num == 9)
                    Console.WriteLine("nine");

                else if (num == 10)
                    Console.WriteLine("ten");

                else if (num == 11)
                    Console.WriteLine("eleven");

                else if (num == 12)
                    Console.WriteLine("twelve");

                else if (num == 13)
                    Console.WriteLine("thirteen");

                else if (num == 14)
                    Console.WriteLine("fourteen");

                else if (num == 15)
                    Console.WriteLine("fifteen");

                else if (num == 16)
                    Console.WriteLine("sixteen");

                else if (num == 17)
                    Console.WriteLine("seventeen");

                else if (num == 18)
                    Console.WriteLine("eighteen");

                else if (num == 19)
                    Console.WriteLine("nineteen");
            }

            else if (num >= 10 && num <= 99)
            {
                d1 = num / 10;
                d2 = num % 10;

                if (d1 == 2)
                    Console.Write("twenty");

                else if (d1 == 3)
                    Console.Write("thirty");

                else if (d1 == 4)
                    Console.Write("forty");

                else if (d1 == 5)
                    Console.Write("fifty");

                else if (d1 == 6)
                    Console.Write("sixty");

                else if (d1 == 7)
                    Console.Write("seventy");

                else if (d1 == 8)
                    Console.Write("eighty");

                else if (d1 == 9)
                    Console.Write("ninety");

                if (d2 == 1)
                    Console.WriteLine(" one");

                else if (d2 == 2)
                    Console.WriteLine(" two");

                else if (d2 == 3)
                    Console.WriteLine(" three");

                else if (d2 == 4)
                    Console.WriteLine(" four");

                else if (d2 == 5)
                    Console.WriteLine(" five");

                else if (d2 == 6)
                    Console.WriteLine(" six");

                else if (d2 == 7)
                    Console.WriteLine(" seven");

                else if (d2 == 8)
                    Console.WriteLine(" eight");

                else if (d2 == 9)
                    Console.WriteLine(" nine");
            }

            else if (num == 100)
                Console.WriteLine("one hundred");

            else
                Console.WriteLine("invalid number");
        }
    }
}