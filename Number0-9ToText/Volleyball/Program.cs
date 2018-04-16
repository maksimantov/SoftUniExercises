using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            int WeekendsSofia = 48 - h;
            double gamesInSofia = (WeekendsSofia * 3.0 / 4) + (p * 2.0 / 3);
            double allgames = gamesInSofia + h;

            if (year == "leap")
                Console.WriteLine(Math.Floor(allgames + (allgames * 0.15)));
            else if (year == "normal")
                Console.WriteLine(Math.Floor(allgames));
        }
    }
}
