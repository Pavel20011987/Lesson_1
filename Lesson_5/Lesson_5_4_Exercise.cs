using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Lesson_5
{
    class Lesson_5_4_Exercise
    {
        const string file = "temp.txt";
        private const char Intend = ' ';
        private const string Marker = ">";

        static void Main(string[] args)
        {

            Console.WriteLine("Input path to directory, to see what inside");
            var path = Console.ReadLine();

            if (string.IsNullOrEmpty(path) || string.IsNullOrWhiteSpace(path))
            {
                Console.WriteLine("Incorrect input");
                return;
            }


            if (!Path.IsPathFullyQualified(path) || !Path.IsPathRooted(path))
            {
                File.WriteAllText(file, GetRecurseStructOfPath(path));
            }
            else
            {
                Console.WriteLine("Path not supported");

                return;
            }
        }




        private static string GetRecurseStructOfPath(string path)
        {
            var builder = new StringBuilder();
            var paths = path.Split('\\');
            var currentPath = Path.GetPathRoot(path);

            builder.AppendLine(">  " + currentPath);
            builder.AppendLine(NextDirectory(currentPath, paths[1], 3, paths, 1));

            return builder.ToString();
        }

        private static string NextDirectory(string current, string next, int indentSize, IReadOnlyList<string> fullPath, int pathIndex)
        {
            var sb = new StringBuilder();
            var directories = new DirectoryInfo(current).GetFileSystemInfos().ToArray();
            for (var i = 0; i < directories.Length; i++)
            {
                if (i != 0) sb.Append("\r\n");
                if (next is not null && directories[i].Name == next)
                {
                    sb.AppendLine($"{new string(Intend, indentSize)}{Marker} {directories[i].Name}");
                    sb.Append(NextDirectory(Path.Combine(current, next),
                        pathIndex + 1 == fullPath.Count ? null : fullPath[pathIndex + 1],
                        indentSize + 2,
                        fullPath,
                        pathIndex + 1));
                }
                else sb.Append($"{new string(Intend, indentSize)}  {directories[i].Name}");
            }

            return sb.ToString();
        }
    }
}
