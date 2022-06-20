using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5
{
    class Program
    {

        static void Main(string[] args)
        {
            //HomeWork_Lesson5_1

            string userString = "";

            //Приглашение пользователю
            Console.Write("Введите любую строку и нажмите клавишу Enter: ");

            /*
            * Получение веденной с клавиатуры строки,
            * введенная строка сохраняется в переменную userString
            */
            userString = Console.ReadLine();

            string filename = "text.txt";

            File.WriteAllText(filename, userString);//записываем в файл строку

            string fileText = File.ReadAllText(filename);

            Console.WriteLine(fileText);

        }
    }
}

