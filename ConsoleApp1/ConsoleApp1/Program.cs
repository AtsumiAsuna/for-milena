using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(x));
            Console.WriteLine(Math.Max(x, y));
            Console.WriteLine(Math.Sqrt(x));
            Console.WriteLine(Math.Truncate(32.7865m));
            //индивидуальное задание 26
            double result;
            result = Math.Sqrt(Math.Sqrt((((40 * 7 / 30) - (38 * 5 / 12)) / 1.9 + (7 / 8 - 7 / 30) * (1 * 9 / 11)) * 4.2) / 0.008) - (1 - Math.Sqrt(Math.Pow(1.12, 5)));
            Console.WriteLine(result);
        }
    }
}
