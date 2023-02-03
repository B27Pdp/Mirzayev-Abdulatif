using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson2_Delegate2.Classwork
{
    public class MyAction
    {
        public static void Run()
        {
            Action<int, string> myAction = (age, name) => { Console.WriteLine($"age: {age}\tname: {name}"); };

            myAction.Invoke(18, "Abdulatif");

        }
    }
}
