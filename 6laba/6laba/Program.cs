using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Практическая работа 6 вариант 28
            //Юлдашева 24ИС-21

            Console.Write("Введите количество чисел: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите точность: ");
            double precision = double.Parse(Console.ReadLine());

            Random rnd = new Random();
            StreamWriter sw = new StreamWriter("numbers.txt");

            for (int i = 0; i < n; i++)
            {
                double num = rnd.NextDouble();
                if (num < precision)
                {
                    num *= 1000;
                }
                sw.WriteLine(num);
            }

            sw.Close();
            Console.WriteLine("Файл numbers.txt создан.");
            Console.ReadKey();
        }
    }
}
