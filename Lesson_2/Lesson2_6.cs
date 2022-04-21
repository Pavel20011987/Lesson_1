using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Lesson2_6
    {
        [Flags]
        enum Days
        {
            Not = 0b00000000,
            Monday = 0b00000001,
            Tuesday = 0b00000010,
            Wednesday = 0b00000100,
            Thursday = 0b00001000,
            Friday = 0b00010000,
            Saturday = 0b00100000,
            Sunday = 0b01000000,
            //флаги можно комбинировать создавая наборы с помощью констант
            WorkingDays = Monday | Tuesday | Wednesday | Thursday | Friday, //0b00011111
                                                                            //или используя значения
            Weekend = 0b01100000 //Sat|Sun
        }
        static void Main(string[] args)
        {
            //проверка битового флага
            if ((Days.WorkingDays) != 0)
            {
                Console.WriteLine("Usually the working days are Monday, Tuesday,  Wednesday, Thursday, Friday.");
            }

            //var goodDays = Days.Thu | Days.Tue;
            //var badDays = Days.Fri | Days.Mon;
            Console.WriteLine($"The business office №1 is open from {Days.Tuesday} to {Days.Friday}, but on the {Days.Weekend} it doesn't work.");
            Console.WriteLine($"The business office №2 is open from {Days.Monday} to {Days.Sunday}.");

            Console.ReadLine();
        }
    }
}
