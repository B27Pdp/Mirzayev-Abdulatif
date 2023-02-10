using _3_modul.Lesson4_Regex.Classwork;
using _3_modul.Lesson4_Regex.Homework;
using _3_modul.Lesson4_Regex.Homework.Josus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_modul.Lesson4_Regex
{
    public class RegexStart
    {
        public static void Run()
        {
            Mafia mafia = new Mafia();
            Shpion shpion = new Shpion();

            mafia.Order += shpion.ShpionStart;
            mafia.Run();



        }
    }
}
