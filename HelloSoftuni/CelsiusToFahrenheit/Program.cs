﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine(fahrenheit);
        }
    }
}
