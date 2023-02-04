using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_modul.Lesson2_Delegate2.Homework.Interfaces;
using _3_modul.Lesson2_Delegate2.Homework.States;

namespace _3_modul.Lesson2_Delegate2.Homework.DataBase
{
    public class Person : IPerson
    {
        public string? Password { get; set; }
        public string? Login { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public Status Status { get; set; }
    }
}
