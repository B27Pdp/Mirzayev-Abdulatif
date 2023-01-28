using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Tuple_Nullable.Homework.task3
{
    public static class LastItem
    {
        public static void GetLastItem<T>(T[] a) => Console.WriteLine($"Last item: {a[a.Length - 1]}");
    }
}
