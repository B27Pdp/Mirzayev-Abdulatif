using System.ComponentModel;

namespace Exerciese.Lesson_Tuple_Nullable.Homework.task1
{
    public class TripleDictionary<T, U, V>
        where T : struct
        where U : class, IPerson<int>
        where V : Person
    {
        public T TProp { get; set; }
        public U? UProp { get; set; }
        public V? VProp { get; set; }

        List<TripleDictionary<T, U, V>> list = new();

        public void Add(T t, U u, V v)
        {
            list.Add(new TripleDictionary<T, U, V>() { TProp = t, UProp = u, VProp = v });
        }

        public List<TripleDictionary<T, U, V>> OrderBy()
        {
            list.OrderBy(x => x.TProp);

            return list;
        }
        public List<TripleDictionary<T, U, V>> OrderByDesc()
        {
            OrderBy().Reverse();

            return list;
        }

        public void GetByIndex(int id)
        {
            
        }

        //public void GetAll()
        //{

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        foreach (PropertyDescriptor item in TypeDescriptor.GetProperties(list[i]))
        //        {
        //            string name = item.Name;
        //            foreach (PropertyDescriptor item1 in TypeDescriptor.GetProperties(list[i]))
        //            {
        //                var value = item1.GetValue(item);
        //                Console.Write($"{name}: {value}, ");
        //            }
        //            Console.WriteLine();
        //        }
        //        Console.WriteLine();
        //    }
        //}

    }
}
