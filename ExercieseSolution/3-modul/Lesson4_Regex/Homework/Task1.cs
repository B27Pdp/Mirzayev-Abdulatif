using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_modul.Lesson4_Regex.Homework
{
    public class Task1
    {
        /*1. Ismlar to'plami berilgan. Regex yordamida to'plam ichidan bosh harfi
         * 'S' bilan boshlanuvchi ismlarni ajratib beruvchi dastur tuzing. (Qiyin)*/
        public static void IsValid(string[] strings)
        {
            string pattern = @"^[S]$";

            foreach (string s in strings)
            {
                if(Regex.IsMatch(s, @"^[S]\w+$"))
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void IsNumber(string str)
        {
            string s = Regex.Replace(str, "[ -/:-~]", "");
            Console.WriteLine(s);
        }

    }
}
