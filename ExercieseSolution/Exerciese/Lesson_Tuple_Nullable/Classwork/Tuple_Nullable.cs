using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Tuple_Nullable.Classwork
{
    public class Tuple_Nullable
    {
        public static void RunTuple()
        {
            (string, int) userInfo = ("James", 18);
            Console.WriteLine(userInfo);

            (string name, int age) userInfo1 = ("Yunjinsu", 45);
            Console.WriteLine(userInfo1);

            var infoUz = ("Uzbekistan", 30, "WhichOne");
            Console.WriteLine(infoUz);

            var n = (a: 5, b: "Ism");
            Console.WriteLine(n);

            string str1 = "Jonibek";
            string? str2 = str1;

            int? num = 45;
            
            Console.WriteLine(num.Value);
            Console.WriteLine(num.HasValue);

            int b = num ?? -1;
            Console.WriteLine(b);

            int? c = null;
            int g = c?? -1;
             
            Console.WriteLine(g);

        }
    }
    
}
