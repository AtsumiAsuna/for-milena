using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //индивидуальное задание практическая 2 вариант 26
            //задание 1
            Console.WriteLine("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите p: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите g: ");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double Q;
            //Высчитываем b
            if (g > Math.Sin(a)) { b = g; }
            else if (g == Math.Sin(a)) { b = a; }
            else if (g < Math.Sin(a)) { b = p; }
            //Высчитываем g
            if ((-2 > a) && (a > 2)) { g = Math.Sin(a); }
            else { g = Math.Cos(a); }
            //Высчитываем Q
            Q = ((a * a) + b) / (p + (g * g));
            Console.WriteLine(Convert.ToString(Q));
        }
    }
}
