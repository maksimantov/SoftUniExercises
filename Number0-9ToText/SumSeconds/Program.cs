using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = int.Parse(Console.ReadLine());
            var s2 = int.Parse(Console.ReadLine());
            var s3 = int.Parse(Console.ReadLine());

            var resultInSeconds = s1 + s2 + s3;

            if (resultInSeconds <= 59)
            {
                if (resultInSeconds >= 10)
                { Console.WriteLine($"0:{resultInSeconds}"); }
                else
                { Console.WriteLine($"0:0{resultInSeconds}"); }
            }
            else if (resultInSeconds >= 60 && resultInSeconds <= 119)
            {
                if (resultInSeconds - 60 >= 10)
                { Console.WriteLine($"1:{resultInSeconds - 60}"); }
                else
                { Console.WriteLine($"1:0{resultInSeconds - 60}"); }
            }
            else if (resultInSeconds >= 120 && resultInSeconds <= 179)
            {
                if (resultInSeconds - 120 >= 10)
                { Console.WriteLine($"2:{resultInSeconds - 120}"); }
                else
                { Console.WriteLine($"2:0{resultInSeconds - 120}"); }
            }
            }
            }
}
