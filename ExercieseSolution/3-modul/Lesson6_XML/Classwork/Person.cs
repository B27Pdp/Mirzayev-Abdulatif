using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_modul.Lesson6_XML.Classwork
{
    public class Person
    {
        public Guid Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public Person()
        {
            Id = Guid.NewGuid();
        }
    }
}
