using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int raws = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double seats = raws * columns;

            if (projection == "Premiere")
            {
                Console.WriteLine("{0:F2}", seats * 12);
            }
            else if (projection == "Normal")
            {
                Console.WriteLine("{0:F2}", seats * 7.50);
            }
            else if (projection == "Discount")
            {
                Console.WriteLine("{0:F2}", seats * 5);
            }
        }
    }
}
