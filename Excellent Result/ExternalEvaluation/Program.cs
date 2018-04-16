using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var PoorMarkScore = 0;
            var SatisfactoryMarkScore = 0;
            var GoodMarkScore = 0;
            var VeryGoodMarkScore = 0;
            var ExcellentMarkScore = 0;

            for (int i = 0; i < n; i++)
            {
                var current = double.Parse(Console.ReadLine());
                if (current >= 0 && current < 22.5)
                {
                    PoorMarkScore++;
                }
                else if (current >= 22.5 && current < 40.5)
                {
                    SatisfactoryMarkScore++;
                }
                else if (current >= 40.5 && current < 58.5)
                {
                    GoodMarkScore++;
                }
                else if (current >= 58.5 && current < 76.5)
                {
                    VeryGoodMarkScore++;
                }
                else if (current >= 76.5 && current <= 100)
                {
                    ExcellentMarkScore++;
                }
                        }

            var PoorPercent = PoorMarkScore * 100.0 / n;
            var SatisfactoryPercent = SatisfactoryMarkScore * 100.0 / n;
            var GoodPercent = GoodMarkScore * 100.0 / n;
            var VeryGoodPercent = VeryGoodMarkScore * 100.0 / n;
            var ExcellentPercent = ExcellentMarkScore * 100.0 / n;

            Console.WriteLine($"{PoorPercent:F2}" + $"% poor marks");
            Console.WriteLine($"{SatisfactoryPercent:F2}" + $"% satisfactory marks");
            Console.WriteLine($"{GoodPercent:F2}" + $"% good marks");
            Console.WriteLine($"{VeryGoodPercent:F2}" + $"% very good marks");
            Console.WriteLine($"{ExcellentPercent:F2}" + $"% excellent marks");
        }
    }
}
