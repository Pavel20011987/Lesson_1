using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_5_Exercise
{
    class Program
    {
        private const string TempFile = "tasks.json";
        private static ToDo _todo;
        private static readonly StringBuilder Buffer = new();

        static void Main(string[] args)
        {
            _todo = ToDo.Load(TempFile);

            var isWorkDone = false;
            do
            {
                RefreshTasks();

                Console.WriteLine(
@"Input number if you wanna set task as Done, 
if you wana add new task input it's name and press enter, 
press Esc to exit");

                do
                {
                    var inputKey = Console.ReadKey();

                    if (inputKey.Key == ConsoleKey.Escape)
                    {
                        isWorkDone = true;
                        break;
                    }

                    // handle moving horizontally, deleting char's

                    if (inputKey.Key == ConsoleKey.Enter)
                        break;

                    Buffer.Append(inputKey.KeyChar);
                } while (true);

                if (Buffer.Length <= 0) continue;

                var temp = Buffer.ToString();
                if (int.TryParse(temp, out var index))
                {
                    try
                    {
                        _todo.SetTaskAsDone(index);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        _todo.AddTask(temp);
                    }
                }
                else _todo.AddTask(temp);

                RefreshTasks();
                Buffer.Clear();


            } while (!isWorkDone);

            _todo.Save(TempFile);
        }

        private static void RefreshTasks()
        {
            Console.Clear();
            PrintTasks(_todo.GetTasks());
        }

        private static void PrintTasks(IEnumerable<string> tasks)
        {
            foreach (var task in tasks)
                Console.WriteLine(task);
        }
    }
}

