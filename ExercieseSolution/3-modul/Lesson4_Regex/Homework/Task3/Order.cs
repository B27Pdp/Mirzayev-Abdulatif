using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson4_Regex.Homework.Task3
{
    public class Order : EventArgs
    {
        public string? OrderOfBoss { get; set; }
        public string? DescriptionOfOrder { get; set; }
        public DateTime DateTime { get; set; }
    }
}
