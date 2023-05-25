using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //практическая работа 4 вариант 28
            //Юлдашева 24ИС

            int[,,] array = new int[3, 3, 3];
            Random random = new Random();

            //заполняем массив случайными числами
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        array[i, j, k] = random.Next(1, 10);
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[1, i, j] = i * j + 1; //формула для получения уникальных значений
                }
            }

            //выводим массив на экран
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }

public class HelloWorld
    {
        static public void Main()
        {
            //лабораторная работа 4 вариант 28
            //Юлдашева 24ИС

            int[] array = { 2, 4, 6, 8, 10, 12, 14, 16 };
            int n = array.Length;
            int count = 0;

            for (int i = 0; i < n / 2; i++)
            {
                if ((double)array[i] / array[n - i - 1] > 1)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество элементов, удовлетворяющих условию: " + count);
        }
    }
}
