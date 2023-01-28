using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Tuple_Nullable.Homework.task1
{
    public class Person : IPerson<int>
    {
        public int Id { get ; set; }
        public byte Age { get; set; }
        public string? Name { get; set; }
    }
}
