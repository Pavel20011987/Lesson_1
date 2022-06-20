using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings.Default.Greeting + " " + Properties.Settings.Default.UserName);
            Console.WriteLine("Версия приложения: " + Properties.Settings.Default.Version);

            if(string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите ваши новые данные: ");
                GetData();
            }
            else
            {
                Console.WriteLine("Ваши старые данные: ");
                ShowData();

                Console.WriteLine("Хотите изменить старые данные: y/n?");

                string UserInput = Console.ReadLine();

                if(UserInput == "y")
                {
                    Console.WriteLine("Введите новые данные старые данные: ");
                    GetData();
                    Properties.Settings.Default.Version++;
                }

                else
                {
                    Console.WriteLine("Всего доброго!!! Удачи!!!");
                }
            }

            Properties.Settings.Default.Save();

            Console.WriteLine("Нажмите любую клавишу, чтобы завершить работу программы");
            Console.ReadKey(true);
        }

        public static void ShowData()
        {
            Console.WriteLine(Properties.Settings.Default.UserName);

            Console.WriteLine(Properties.Settings.Default.Age);

            Console.WriteLine(Properties.Settings.Default.Occupation);
        }

        public static void GetData()
        {
            Console.WriteLine("Введите ваше имя: ");
            Properties.Settings.Default.UserName = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            Properties.Settings.Default.Age = Console.ReadLine();
            Console.WriteLine("Введите ваш род деятельности: ");
            Properties.Settings.Default.Occupation = Console.ReadLine();

        }
    }
}
