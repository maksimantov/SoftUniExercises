using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstbrother = double.Parse(Console.ReadLine());
            var secondbrother = double.Parse(Console.ReadLine());
            var thirdbrother = double.Parse(Console.ReadLine());
            var fishing = double.Parse(Console.ReadLine());

            var withoutbreak = 1 / (1 / firstbrother + 1 / secondbrother + 1 / thirdbrother);
            var cleaningtime = withoutbreak + (withoutbreak * 0.15);

            Console.WriteLine("Cleaning time: {0:F2}", cleaningtime);

            if (fishing - cleaningtime > 0)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(fishing - cleaningtime));
            }

            if (cleaningtime - fishing >= 0)
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time - {0} hours", Math.Ceiling(cleaningtime - fishing));
            }
        }
    }
}
