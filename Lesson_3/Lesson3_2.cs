using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Lesson3_2
    {
        static void Main(string[] args)
        {
            var phone_contacts = new string[5, 2]
               {
                {"Fedor", "+7 934 123 12 34"},
                {"Stepan", "stepan123@gmail.com"},
                {"Ulia", "+5 324 112 33 54"},
                {"Marina", "marina27@mail.bk"},
                {"Alex", "+1 234 456 76 23"},
               };

            for (var i = 0; i < phone_contacts.GetLength(0); i++)
            {
                for (var j = 0; j < phone_contacts.GetLength(1); j++)
                    Console.Write(phone_contacts[i, j] + " ");
                Console.WriteLine();
            }

            // Программа останавливается
            Console.ReadLine();

        }
    }
}
