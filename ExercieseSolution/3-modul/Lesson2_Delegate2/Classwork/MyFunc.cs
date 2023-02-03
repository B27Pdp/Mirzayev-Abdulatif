using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson2_Delegate2.Classwork
{
    public class MyFunc
    {
        public static void Run()
        {
            Func<int, string, Action<string>> myFunction = (birthYear, name) => 
            {
                Action<string> action = str => { str = name; Console.WriteLine(str + $", {birthYear}"); };

                return action; 
            };

            myFunction.Invoke(2000, "Abdullajon").Invoke("sad");

            Func<string> func = GetHello;
            Console.WriteLine(func.Invoke());

            Action act = Hi;
            act();

            //answer.Invoke("hello");

            //Console.WriteLine(answer);
        }
        public static string GetHello()
        {
            return "Hello World";
        }
        public static void Hi()
        {
            Console.WriteLine("My name is James Bond");
        }
    }
}
