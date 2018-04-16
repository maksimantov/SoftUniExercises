using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            int num = int.Parse(i.ToString() + k + j + l);
                            var lastdigit = num % 10;
                            num /= 10;
                            var thirddigit = num % 10;
                            num /= 10;
                            var seconddigit = num % 10;
                            num /= 10;
                            var firstdigit = num % 10;

                            if (firstdigit + seconddigit == thirddigit + lastdigit && n % (firstdigit + seconddigit) == 0)
                            {
                                Console.Write($"{firstdigit}{seconddigit}{thirddigit}{lastdigit} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
