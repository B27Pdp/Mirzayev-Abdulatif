using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson5_DateTime_Folders.Homework
{
    public class Task2
    {
        public static void Run()
        {
            string path = @"C:\Users\Asus\Desktop\Mirzayev-Abdulatif\ExercieseSolution\3-modul\Lesson5_DateTime_Folders\Test\t.txt";
                
            var lines = File.ReadAllLines(path).Count();

            var length = File.ReadAllText(path).Length;

            Console.WriteLine("count of lines: " + lines);

            Console.WriteLine("lenght: " + length);

        }
    }
}
