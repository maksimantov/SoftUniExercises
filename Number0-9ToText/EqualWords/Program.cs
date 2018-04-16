using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {var firstword = Console.ReadLine();
         var secondword = Console.ReadLine();
         firstword = firstword.ToLower();
         secondword = secondword.ToLower();

            if (firstword == secondword)
            { Console.WriteLine("yes"); }
            else
            { Console.WriteLine("no"); }
        }
    }
}
