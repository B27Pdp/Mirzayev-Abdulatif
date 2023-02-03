using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson2_Delegate2.Classwork 
{
    public class LambdaExpression
    {
        public delegate int SumDelegate(int x, int y);

        public static void Run()
        {
            SumDelegate sum = (num1, num2) => num1 + num2;
            int a = sum.Invoke(5, 8);
            
            Console.WriteLine(a);
        }
    }
}
