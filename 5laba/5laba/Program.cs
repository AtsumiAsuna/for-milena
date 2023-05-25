using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] genres = { "Классика", "Рок", "Джаз", "Фолк", "Кантри" };
            int selectedGenre = 0;
            ConsoleKeyInfo keyInfo;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Выберите интересующий музыкальный жанр:");

            do
            {
                Console.Clear();

                Console.WriteLine("Выберите интересующий музыкальный жанр:");
                for (int i = 0; i < genres.Length; i++)
                {
                    if (i == selectedGenre)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine(genres[i]);
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow && selectedGenre > 0)
                {
                    selectedGenre--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow && selectedGenre < genres.Length - 1)
                {
                    selectedGenre++;
                }
            } while (keyInfo.Key != ConsoleKey.N);

            Console.WriteLine("Вы выбрали жанр: " + genres[selectedGenre]);

            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.WriteLine("Выбранный жанр подтверждён.");
            }
        }
    }
}
