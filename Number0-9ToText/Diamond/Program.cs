using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int background = (n - 1) / 2;
            int Middle = 0;

            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', background),
                        new string('-', Middle)
                        );
                    background--;
                    Middle += 2;
                }
                int background2 = 1;
                int Middle2 = Middle - 4;
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', background2),
                        new string('-', Middle2)
                        );
                    background2++;
                    Middle2 -= 2;
                }
            }
            else
            {
                Console.WriteLine("{0}*{0}", new string('-', background));
                background--;
                Middle = 1;
                for (int i = 0; i < (n / 2); i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', background),
                        new string('-', Middle)
                        );
                    background--;
                    Middle += 2;
                }
                int background2 = 1;
                int Middle2 = Middle - 4;
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', background2),
                        new string('-', Middle2)
                        );
                    background2++;
                    Middle2 -= 2;
                }
                if (n == 1)
                {
                }
                else
                {
                    Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
                }
            }
        }
    }
}
