namespace Exerciese.Lesson_Indexer.Classwork
{
    public class MyList<T>
    {
        private T[] list = new T[1];
        int[] a;

        List<T> list2 = new();

        public T this[int i]
        {
            get { return list[i]; }
            set
            {
                if (i >= list.Length)
                {
                    T[] arr = new T[list.Length * 2];
                    arr[i] = value;
                    list = arr;

                }
                else
                {
                    this[i] = value;
                }
            }
        }

        public void Add(T value)
        {
            this[list.Length] = value;
        }

        public void Clear()
        {
            list = new T[1];
        }
        public bool Contains(T value)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
            return false;
        }
        public void Remove(T val)
        {
            if (Contains(val))
            {
                int index = Array.IndexOf(list, val);
                for (int i = index; i < list.Length - 1; i++)
                {
                    T v = list[i];
                    this[i] = this[i + 1];
                    this[i + 1] = v;
                }
            }
        }
        public int Count()
        {
            return list.Length == 0 ? 0 : list.Length;
        }


    }
}
