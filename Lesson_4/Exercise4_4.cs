using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Exercise4_4
    {
        
        // Это рекурсивный метод.
        public int FactR(int n)
        {
            int result;
            if (n == 1) return 1;
            result = FactR(n - 1) * n;
            return result;
        }
        //// Это итерационный метод.
        //public int FactI(int n)
        //{
        //    int t, result;
        //    result = 1;
        //    for (t = 1; t <= n; t++) result *= t;
        //    return result;
        //}
    }

    class Recursion
    {
        static void Main()
        {
            Exercise4_4 f = new Exercise4_4();
            Console.WriteLine("Факториалы, рассчитанные рекурсивным методом.");
            Console.WriteLine("Факториал числа 3 равен " + f.FactR(3));
            Console.WriteLine("Факториал числа 4 равен " + f.FactR(4));
            Console.WriteLine("Факториал числа 5 равен " + f.FactR(5));
            //Console.WriteLine();
            //Console.WriteLine("Факториалы, рассчитанные итерационным методом.");
            //Console.WriteLine("Факториал числа 3 равен " + f.FactR(3));
            //Console.WriteLine("Факториал числа 4 равен " + f.FactR(4));
            //Console.WriteLine("Факториал числа 5 равен " + f.FactR(5));
        }

    }

}


