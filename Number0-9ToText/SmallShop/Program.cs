using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine();
            var town = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (productName == "coffee")
                    Console.WriteLine(quantity * 0.50);
                if (productName == "water")
                    Console.WriteLine(quantity * 0.80);
                if (productName == "beer")
                    Console.WriteLine(quantity * 1.20);
                if (productName == "sweets")
                    Console.WriteLine(quantity * 1.45);
                if (productName == "peanuts")
                    Console.WriteLine(quantity * 1.60);
            }
            if (town == "Plovdiv")
            {
                if (productName == "coffee")
                    Console.WriteLine(quantity * 0.40);
                if (productName == "water")
                    Console.WriteLine(quantity * 0.70);
                if (productName == "beer")
                    Console.WriteLine(quantity * 1.15);
                if (productName == "sweets")
                    Console.WriteLine(quantity * 1.30);
                if (productName == "peanuts")
                    Console.WriteLine(quantity * 1.50);
            }
            if (town == "Varna")
            {
                if (productName == "coffee")
                    Console.WriteLine(quantity * 0.45);
                if (productName == "water")
                    Console.WriteLine(quantity * 0.70);
                if (productName == "beer")
                    Console.WriteLine(quantity * 1.10);
                if (productName == "sweets")
                    Console.WriteLine(quantity * 1.35);
                if (productName == "peanuts")
                    Console.WriteLine(quantity * 1.55);
            }
        }
    }
}
