using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Lesson2_3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четное или нечетное число:");


            byte num = byte.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Четное число");
            }


            else
            {
                Console.WriteLine("Нечетное число");
            }

        }
    }
}
