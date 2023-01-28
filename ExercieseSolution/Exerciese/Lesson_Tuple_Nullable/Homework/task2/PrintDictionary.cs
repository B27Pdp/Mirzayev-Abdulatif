using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Tuple_Nullable.Homework.task2
{
    public static class PrintDictionary
    {
        public static void PrintDictionary1<T, U>(Dictionary<T, U> d)
        { foreach (var k in d) Console.WriteLine($"Key: {d.Keys}, Value: {d.Values}"); }
    }
}
