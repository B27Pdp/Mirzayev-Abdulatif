using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_modul.Lesson4_Regex.Classwork.Mafia;

namespace _3_modul.Lesson4_Regex.Classwork
{
    public class Shpion
    {
        public bool ShpionStart(object? obj, AnotherOrder eventHandler)
        {
            eventHandler.Invoke(default, new EventArgs());   
            return true;
        }
    }
}
