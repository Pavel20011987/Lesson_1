using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double avgTemp = 0;// задаем переменную средней температуры
            // создаем массив из 8 отрезков времени за сутки
            string[] hourOfDay = new string[8] { "с 0 часов до 3 часов", "с 3 часов до 6 часов", "с 6 часов до 9 часов", "с 9 часов до 12 часов", "с 12 часов до 15 часов", "с 15 часов до 18 часов", "с 18 часов до 21 часов", "с 21 часов до 24 часов" };
            int[] tempOfPeriod = new int[8];
            Console.WriteLine($"Введите температуру за определенный период суток: ");
            for (int i = 0; i < hourOfDay.Length; i++)
            {
                Console.Write($"{hourOfDay[i]} -> ");
                tempOfPeriod[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in tempOfPeriod)
                Console.Write($"{item} ");
            Console.WriteLine();
            foreach (var item in tempOfPeriod)
                avgTemp += item;
            avgTemp /= 8;
            Console.WriteLine($"Средняя температура за сутки: {Math.Round(avgTemp, 2)}");
            Console.WriteLine($"Максимальная температура: {hourOfDay[Array.IndexOf(tempOfPeriod, tempOfPeriod.Max())]} - {tempOfPeriod.Max()}");
            Console.WriteLine($"Минимальная температура: {hourOfDay[Array.IndexOf(tempOfPeriod, tempOfPeriod.Min())]} - {tempOfPeriod.Min()}");
        }
    }
}
