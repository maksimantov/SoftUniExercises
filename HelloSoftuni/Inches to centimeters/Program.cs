using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inch = double.Parse(Console.ReadLine());
            var cent = inch * 2.54;
            Console.WriteLine(cent);
        }
    }
}
