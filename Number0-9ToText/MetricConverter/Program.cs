using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();
            var inMeters = 0.0;

if (input == "m")
            { inMeters = value; }
            else if (input == "mm")
            { inMeters = value / 1000; }
            else if (input == "cm")
            { inMeters = value / 100; }
            else if (input == "mi")
            { inMeters = value / 0.000621371192; }
            else if (input == "in")
            { inMeters = value / 39.3700787; }
            else if (input == "km")
            { inMeters = value / 0.001; }
            else if (input == "ft")
            { inMeters = value / 3.2808399; }
            else if (input == "yd")
            { inMeters = value / 1.0936133; }

            if (output == "m")
            { Console.WriteLine($"{inMeters:F8}"); }
            else if (output == "mm")
            { Console.WriteLine($"{(inMeters * 1000):F8}"); }
            else if (output == "cm")
            { Console.WriteLine($"{(inMeters * 100):F8}"); }
            else if (output == "mi")
            { Console.WriteLine($"{(inMeters * 0.000621371192):F8}"); }
            else if (output == "in")
            { Console.WriteLine($"{(inMeters * 39.3700787):F8}"); }
            else if (output == "km")
            { Console.WriteLine($"{(inMeters * 0.001):F8}"); }
            else if (output == "ft")
            { Console.WriteLine($"{(inMeters * 3.2808399):F8}"); }
            else if (output == "yd")
            { Console.WriteLine($"{(inMeters * 1.0936133):F8}"); }
        }
    }
}
