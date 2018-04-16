using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000daysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            dateTime = dateTime.AddDays(999);
            Console.WriteLine(dateTime.ToString("dd-MM-yyyy"));
        }
    }
}
