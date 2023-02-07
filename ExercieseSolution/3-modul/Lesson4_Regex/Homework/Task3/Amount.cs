using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson4_Regex.Homework.Task3
{
    public class Amount : EventArgs
    {
        public bool IsFinished { get; set; }
        public double AmountOfOrder { get; set; }
    }
}
