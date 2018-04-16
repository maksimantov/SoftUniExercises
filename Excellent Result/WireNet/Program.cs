using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var priceperm = double.Parse(Console.ReadLine());
            var weightperm = double.Parse(Console.ReadLine());

            var wirelength = 2 * length + 2 * width;
            var wireprice = wirelength * priceperm;
            var area = wirelength * height;
            var wireweight = area * weightperm;

            Console.WriteLine(wirelength);
            Console.WriteLine("{0:F2}", wireprice);
            Console.WriteLine("{0:F3}", wireweight);
        }
    }
}
