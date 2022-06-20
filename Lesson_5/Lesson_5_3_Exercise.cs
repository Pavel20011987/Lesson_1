using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Lesson_5_3_Exercise
    {
        static void Main(string[] args)
        {
            const string file = "test.bin";

            Console.WriteLine("Ввести с клавиатуры произвольный набор чисел [0..255] через пробел!");
            var input = Console.ReadLine()?.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            if (input is null)
            {
                Console.WriteLine("Неправильный ввод данных");
                return;
            }

            var array = new byte[input.Length];
            for (var i = 0; i < array.Length; i++)
            {
                if (!byte.TryParse(input[i], out var number))
                {
                    Console.WriteLine($"Неправильное число {input[i]}");
                    return;
                }

                array[i] = number;
            }
            using (var bw = new BinaryWriter(File.OpenWrite(file)))
            {
                bw.Write(array);
                bw.Flush();
            }

            Console.WriteLine("Посмотрим, что сейчас находится в файле test.bin");

            Console.WriteLine("Я прочитал файл test.bin");
            byte[] newData;
            using (var br = new BinaryReader(File.OpenRead(file)))
            {
                newData = br.ReadBytes(array.Length);
            }

            for (var i = 0; i < newData.Length; i++)
            {
                Console.Write(newData[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
