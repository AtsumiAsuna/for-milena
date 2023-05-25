using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //практическая работа 3 вариант 28
            //Юлдашева 24ИС

            double a = 1.5;
            int n0 = 2;
            int nk = 8;
            int deltaN = 2;
            double x = 2.3;
            double b = 0.7;

            for (int n = n0; n <= nk; n += deltaN)
            {
                double xb = x * b;
                double cosValue = Math.Cos(xn - b);
                double denominator = Math.Pow(x, 2) - (b * Math.Sqrt(b));
                double tgValue = Math.Tan(Math.Pow(n, 3));

                double result = 0.5 * xb + (cosValue / denominator) + tgValue;

                Console.WriteLine("n = " + n + ", Z = " + result);


                //лабораторная работа 3 вариант 28
                double sum = 0;
                for (int k = 1; k <= 10; k++)
                {
                    double innerSum = 0;
                    for (int n = 1; n <= k; n++)
                    {
                        innerSum += Math.Tan(10 * n);
                    }
                    sum += innerSum / k;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
