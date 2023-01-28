using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Tuple_Nullable.Homework.task1
{
    public class TripleDictionary<T, U, V>
        where T : class
        where U : class, IPerson<int> 
        where V : Person
    {
        public T[]? TProp { get; set; }
        public U? UProp { get; set; }
        public V? VProp { get; set; }

        public T[] OrderBy()
        {
            List<T> t = TProp.ToList();
            t.Sort();
            return t.ToArray();
        }
        public T[] OrderByDesc()
        {
            return OrderBy().Reverse().ToArray();
        }

    }
}
