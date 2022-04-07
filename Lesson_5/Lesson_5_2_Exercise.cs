using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Lesson_5_2_Exercise
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";//создаем переменную filename и присваиваем ей файл startup.txt

            File.WriteAllText(filename, DateTime.Now.ToString("HH:mm:ss tt"));//записываем в файл startup.txt текущее время

            string fileText = File.ReadAllText(filename);//считываем значение текущего времени в переменную filetext

            Console.WriteLine("Я добавил в файл startup.txt текущее время, посмотрите на текущее время" + " " + fileText + ", " + "и проверьте");//выводим в консоль содержимое файла startup.txt
        }
    }
}
