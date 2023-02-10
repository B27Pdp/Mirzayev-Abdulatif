using System.IO;

namespace _3_modul.Lesson5_DateTime_Folders.Homework
{
    public class Task1
    {
        public static void Run()
        {
            string path = @"C:\Users\Asus\Desktop\Mirzayev-Abdulatif\ExercieseSolution\3-modul\Lesson5_DateTime_Folders\Test";

            var directoryInfo = new DirectoryInfo(path);

            var files = directoryInfo.EnumerateFiles();
            var directories = directoryInfo.EnumerateDirectories();

            foreach ( var file in files )
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("-------------------------");

            foreach (var dir in directories)
            {
                Console.WriteLine(dir);
            }
            Console.WriteLine("-------------------------");

            if (files.Count() > 0) Console.WriteLine("have files");
            else Console.WriteLine("No folders");
            if (directories.Count() > 0) Console.WriteLine("have folders");
            else Console.WriteLine("No folders");
        }

    }
}
