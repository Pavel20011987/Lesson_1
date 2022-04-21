using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            DateTime now = DateTime.Now;
            Console.WriteLine(value: $"Привет, { name}, сегодня { now.ToString("D") } ");
        }
    }
}
