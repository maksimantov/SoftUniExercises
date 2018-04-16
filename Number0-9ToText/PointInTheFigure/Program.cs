using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            bool outofrectangle = (x > 3 * h || x < 0) || (y > h || y < 0);
            bool outofrectangle2 = (x > 2 * h || x < h) || (y < 0 || y > 4 * h);
            bool insiderectangle = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            bool insiderectangle2 = (x > h && x < 2 * h) && (y > h && y < 4 * h);
            bool commonborder = (x > h && x < 2 * h) && (y == h);

                if (outofrectangle && outofrectangle2)
                {
                Console.WriteLine("outside");
                }
            else if (insiderectangle || insiderectangle2 || commonborder)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("border");
                }
        }
    }
}
