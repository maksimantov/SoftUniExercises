﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");
                for (int j = 0; j < row - 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int row = n - 1; row > 0; row--)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");
                for (int j = 0; j < row - 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

        }
    }
    }
