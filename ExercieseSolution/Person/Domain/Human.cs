using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Domain
{
    public class Human
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nLogin: {Login}\nPassword: {Password}\n";
        }
    }
}
