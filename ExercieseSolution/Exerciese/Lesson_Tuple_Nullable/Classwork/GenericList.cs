using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Tuple_Nullable.Classwork
{
    public class GenericList<T, K, U> where T: unmanaged where K : new() where U : class
    {
        List<T> list = new();
        public void Add(T t)
        {
            list.Add(t);
        }
        public T GetItem(int index)
        {
            return index < list.Count ? list[index] : throw new IndexOutOfRangeException("yuq index kiritildi!");
        }
        public int Count { get { return list.Count; } }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }
        public void Remove(T t)
        {
            list.Remove(t);
        }

    }
}
