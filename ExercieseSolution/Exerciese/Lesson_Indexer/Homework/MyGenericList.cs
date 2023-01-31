using System.Collections;

namespace Exerciese.Lesson_Indexer.Homework
{
    public class MyGenericList<T> : IEnumerable<T>
    {
        T[] array = new T[4];
        int count = -1;
        object a = -1;
        public T this[int i]
        {
            get
            {
                if (i <= count) return array[i];
                else { new IndexOutOfRangeException("Unday index mavjud emas"); return (T)a; }
            }
            set
            {
                count++;
                if (i <= count) array[i] = value;
                else new IndexOutOfRangeException("Unday index mavjud emas");
            }
        }
        public int Count { get => count; }
        public int Capacity
        {
            get => array.Length;
            set
            {
                if (count < value)
                    new ArgumentOutOfRangeException("listdagi malumotlar bu siz belgilagan capacityga sig'maydi");
                else
                {
                    T[] values = new T[value];
                    Array.Copy(array, values, array.Length);
                    array = values;
                }
            }
        }
        public void Add(T item)
        {
            count++;
            if (array.Length <= count) grow();
            array[count] = item;
        }
        private void grow()
        {
            T[] values = new T[array.Length * 2];
            Array.Copy(array, values, array.Length);
            array = values;
        }
        public void Clear()
        {
            array = new T[1];
            count = -1;
        }
        public bool Contains(T item)
        {
            return array.Contains(item);
        }
        public bool Remove(T item)
        {
            if (array.Contains(item))
            {
                int index = Array.IndexOf(array, item);
                for (int i = index; i < count-1; i++)
                {
                    
                    T t = array[i+1];
                    array[i+1] = array[index];
                    array[i] = t;
                }
                //(array[index], array[count-1]) = (array[count-1], array[index]);
                count--;
                T[] arr = new T[count];
                Array.Copy(array, arr, count);
                array = arr;
                return true;
            }
            return false;
        }
        public void Reverse()
        {
            T[] arr = new T[array.Length];
            Array.Copy(array, arr, array.Length);
            Array.Reverse(arr, 0, count);
            array = arr;
        }
        public void Sort()
        {
            T[] arr = new T[array.Length];
            Array.Copy(array, arr, count);
            Array.Sort(arr, 0, count);
            array = arr;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < count; i++)
            {
                action(array[i]);
            }
        }
        public int IndexOf(T item)
        {
            if (array.Contains(item))
            {
                return Array.IndexOf(array, item);
            }
            return -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }
    }
}
