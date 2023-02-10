using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson5_DateTime_Folders.Homework
{
    public class Task3
    {
        public static void Run()
        {
            string path1 = @"C:\Users\Asus\Desktop\Mirzayev-Abdulatif\ExercieseSolution\3-modul\Lesson5_DateTime_Folders\Test\t.txt";
            string path2 = @"C:\Users\Asus\Desktop\Mirzayev-Abdulatif\ExercieseSolution\3-modul\Lesson5_DateTime_Folders\Test\copy.txt";

            try
            {
                File.Copy(path1, path2, true);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
