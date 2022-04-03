using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Exercise_4_3
    {
        enum Season { nan, winter, spring, summer, autumn }
        static Season ofmonth(int n)
        {
            try
           {
                if (n <= 0 || n > 12)
                   throw new Exception("ошибка: введите число от 1 до 12");
                switch ((n % 12) / 3)
                {
                    case 0:
                        return Season.winter;
                    case 1:
                        return Season.spring;
                    case 2:
                        return Season.summer;
                    default: return Season.autumn;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Season.nan;
           }
       }
        static string season(Season s)
        {
            switch (s)
            {
                case Season.winter:
                    return "зима";
                case Season.spring:
                    return "весна";
                case Season.summer:
                    return "лето";
                case Season.autumn:
                    return "осень";
                default: return "";
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("введите номер месяца: ");
                Console.WriteLine(season(ofmonth(Convert.ToInt32(Console.ReadLine()))));
            }
            while (true);
       }


    }
}
