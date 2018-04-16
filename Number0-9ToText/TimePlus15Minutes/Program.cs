using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            TimeSpan time = new TimeSpan(hour, minutes, 0);
            TimeSpan time2 = new TimeSpan(0, 15, 0);
            TimeSpan newtime = time + time2;

            Console.WriteLine("{0:h\\:mm}", newtime);
        }
    }
}
