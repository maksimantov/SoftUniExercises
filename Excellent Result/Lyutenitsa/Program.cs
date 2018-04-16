using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var tomatoes = double.Parse(Console.ReadLine());
            var boxes = double.Parse(Console.ReadLine());
            var jars = int.Parse(Console.ReadLine());

            var lutenica = tomatoes / 5;
            var amountjars = lutenica / 0.535;
            var possboxes = amountjars / jars;

            Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(lutenica));

            if (possboxes >= boxes)
            {
                    Console.WriteLine("{0} boxes left.", Math.Floor(possboxes - boxes));
                    Console.WriteLine("{0} jars left.", Math.Floor(amountjars - (jars * boxes)));
                }
            else
                    {
                Console.WriteLine("{0} more boxes needed.", Math.Floor(boxes - possboxes));
                Console.WriteLine("{0} more jars needed.", Math.Floor((jars * boxes) - amountjars));
            }
        }
        }
}
