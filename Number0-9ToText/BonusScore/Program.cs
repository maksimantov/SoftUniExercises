using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            { Console.Write("Enter score: ");}
            var number = int.Parse(Console.ReadLine());
            double bonusScore = 0;

            if (number <= 100)
            { bonusScore = bonusScore + 5; }

            if (number > 100)
            { bonusScore = number * 0.20; }

            if (number > 1000)
            { bonusScore = number * 0.10; }

            if (number % 2 == 0)
            { bonusScore = bonusScore + 1; }

            if (number % 10 == 5)
            { bonusScore += 2; }

            Console.WriteLine("Bonus score: {0}", bonusScore);
            Console.WriteLine("Total score: {0}", number + bonusScore);
        }
    }
}
