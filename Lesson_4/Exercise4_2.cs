using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Exercise4_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите желаемые числа через пробел: ");
            var sum = Console.ReadLine().Split().Select(int.Parse).Sum();
            Console.WriteLine("Сумма введенных чисел равна : " + sum);
        }

        //Второй вариант

        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;

        //    ShowProgrammFunctionality();

        //    /*
        //     * Прочитать строку из консоли - RecieveData();
        //     * Разделить строку на части(через пробел) - SplitData();
        //     * Сконвертировать строки в число(parse) - TransformData();
        //     * Просуммировать числа - CalculateData();
        //     * Вывести на консоль результат - DisplayResult();
        //     */
        //    string data = RecieveData();
        //    List<string> parts = SplitData(data);
        //    List<int> numbers = TransformData(parts);
        //    int result = CalculateData(numbers);
        //    DisplayResult(result);

        //}
        //private static void ShowProgrammFunctionality()
        //{
        //    Console.WriteLine("Программа, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке.");
        //}

        //private static string RecieveData()
        //{
        //    Console.Write("Введите строку: ");
        //    return Console.ReadLine();
        //}

        //private static List<string> SplitData(string data)
        //{
        //    List<string> parts = new List<string>();
        //    if (string.IsNullOrWhiteSpace(data))
        //    {
        //        return parts;
        //    }
        //    parts.AddRange(data.Split(' '));
        //    return parts;
        //}

        //private static List<int> TransformData(List<string> parts)
        //{
        //    List<int> numbers = new List<int>();
        //    foreach (var part in parts)
        //    {
        //        if (int.TryParse(part, out int number))
        //        {
        //            numbers.Add(number);
        //        }
        //    }
        //    return numbers;
        //}

        //private static int CalculateData(List<int> numbers)
        //{
        //    int result = 0;
        //    foreach (var number in numbers)
        //    {
        //        result += number;
        //    }
        //    return result;
        //}

        //private static void DisplayResult(int result)
        //{
        //    Console.WriteLine("Сумма чисел : " + result);
        //}

    }
}
