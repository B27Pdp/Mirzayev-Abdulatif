using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson3_Events.Homework
{
    public class task1
    {
        public static int Length(string str)
        {
            try
            {
                if(str.Length == 0) { throw new ArgumentException(); }
                return str.Length;
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Kiritilgan matn bo’sh bo’lmasligi kerak");
            }
        }
    }
}
