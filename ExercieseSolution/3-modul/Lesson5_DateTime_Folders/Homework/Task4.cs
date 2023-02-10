using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson5_DateTime_Folders.Homework
{
    public class Task4
    {
        public static void Run()
        {
            string path1 = @"C:\Users\Asus\Desktop\Mirzayev-Abdulatif\ExercieseSolution\3-modul\Lesson5_DateTime_Folders\Test\copy.txt";
            string path2 = @"C:\Users\Asus\Desktop\Mirzayev-Abdulatif\ExercieseSolution\3-modul\Lesson5_DateTime_Folders\Test\t.txt";
            string path3 = @"C:\Users\Asus\Desktop\Mirzayev-Abdulatif\ExercieseSolution\3-modul\Lesson5_DateTime_Folders\Test\mergeFile.txt";

            //File.Create(path3);
            string[] str1 = File.ReadAllLines(path1);
            string[] str2 = File.ReadAllLines(path2);
            

            using (StreamWriter streamWriter = new(path3))
            {
                for (int i = 0; i < str1.Length || i < str2.Length; i++)
                {
                    if (i < str1.Length) streamWriter.WriteLine(str1[i]);
                    if(i < str2.Length) streamWriter.WriteLine(str2[i]);
                }
                Console.WriteLine("Successfully");
            }

            List<string> list = File.ReadAllLines(path3).ToList();

            list.ForEach(x => Console.WriteLine(x));
            
            

        }

        public static void CombinePath()
        {
            string path1 = @"C:\Users\Asus\Desktop\Mirzayev-Abdulatif\ExercieseSolution\3-modul\Lesson5_DateTime_Folders\Test\t.txt";
            string path2 = "copy.txt";

            string path3 = Path.Combine(path1, path2);

            Console.WriteLine(path3);
        }
    }
}
