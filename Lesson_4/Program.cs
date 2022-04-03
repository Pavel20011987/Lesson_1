using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            getfullname("Петров", "Валерий", "Валерьевич");
            getfullname("Сидоров", "Вадимир", "Иванович");
            getfullname("Саврасов", "Петр", "Евгеньевич");// вызов метода в методе main
        }
        static void getfullname(string lastname, string firstname, string patronymic)// метод getfullname с аргументами и выводящая в консоль значения аргументов
        {
            Console.WriteLine($"{lastname} {firstname} {patronymic}");
        }
    
    
    }
}