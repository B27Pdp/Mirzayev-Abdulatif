using Exerciese.Lesson_Indexer.Classwork;
using Exerciese.Lesson_Indexer.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Indexer
{
    public class LessonIndexer
    {
        public static void Run()
        {
            bool isActive = true;
            int n;
            while(isActive)
            {
                Console.Clear();
                Console.Write("Qanday List yaratmoqchisiz?\n1.Butun sonlar uchun\n" +
                    "2.Satrlar uchun\n3.Haqiqiy sonlar uchun\n4.Belgilar uchun\n" +
                    "5.Yuqoridagi barchasi uchun\n6.Obyektlar uchun\nBirini tanlang: ");
                string s = Console.ReadLine();
                int.TryParse(s, out n);

                switch (n)
                {
                    case 1: ListInUse<int> list1 = new(); list1.Run(); break;
                    case 2: ListInUse<string> list2 = new(); list2.Run(); break;
                    case 3: ListInUse<double> list3 = new(); list3.Run(); break;
                    case 4: ListInUse<char> list4 = new(); list4.Run(); break;
                    case 5: ListInUse<object> list5 = new(); list5.Run(); break;
                    default: break;
                }
            }
        }
    }
}
