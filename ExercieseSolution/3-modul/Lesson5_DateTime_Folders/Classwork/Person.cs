using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson5_DateTime_Folders.Classwork
{
    public class Person
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nPhoneNumber: {PhoneNumber}\n";
        }
    }
}
