namespace Exerciese.Lesson_Indexer.Homework
{
    public class MyGenericList<T>
    {
        T[] array = new T[4];
        int count = 0;
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
            if (array.Length <= count) grow();
            array[count++] = item;
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
            count = 0;
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
                (array[index], array[array.Length - 1]) = (array[array.Length - 1], array[index]);

                T[] arr = new T[array.Length];
                Array.Copy(array, arr, array.Length - 1);
                array = arr;
                count--;
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
    }
}
