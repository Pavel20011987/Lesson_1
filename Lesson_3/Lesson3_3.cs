using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Lesson3_3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку для ее перевода в обратном порядке: ");
            string str = Console.ReadLine();

            if (str != null)
                Console.WriteLine(new string(str.Reverse().ToArray()));
        }
    }
}
