using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("Enter even number: ");
                    var n = double.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: " + n);
                        return;
                    }
                    if (n % 2 == 1)
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                    Console.WriteLine("Enter even number: ");
                    var n = double.Parse(Console.ReadLine());
                   }
                 }
            while (true);
            }
       }
    }