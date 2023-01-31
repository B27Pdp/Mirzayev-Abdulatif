using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Leeson_Enumerable.Homework
{
    public class MyList<T> : IList<T>
    {
        private T[] arr;
        private int count = -1;

        /// <summary>
        /// List hajmini berishingiz mumkin
        /// </summary>
        /// <param name="size">MyList<T> Count </param>
        public MyList(int size = 4)
        {
            arr = new T[size];
        }
        public T this[int index]
        {
            get
            {
                if(index <= count) return arr[index];
                else new IndexOutOfRangeException("Sizda unday index yuq");
                return default(T);
            }
            set
            {
                if(index <= count)
                {
                    arr[index] = value;
                }
                else { throw new IndexOutOfRangeException("Sizda unday index yuq"); }
            }
        }

        /// <summary>
        /// Count Listning elementlar sonini olishingiz mumkin
        /// </summary>
        public int Count => count == -1 ? 0 : count;

        public bool IsReadOnly => false;
        /// <summary>
        /// Add yordamida listga element qushasiz
        /// </summary>
        /// <param name="item">element berishingiz kerak</param>
        public void Add(T item)
        {
            if(count < arr.Length)
            {
                count++;
                arr[count] = item;
            }
            else
            {
                grow();
                count++;
                arr[count] = item;
            }
        }
        private void grow()
        {
            T[] array = new T[arr.Length * 2];
            Array.Copy(arr, array, arr.Length);
            arr = array;
        }
        public void Clear()
        {
            arr = new T[4];
        }
        /// <summary>
        /// Parameterda bergan element listda bor yuqligini tekshiradi 
        /// </summary>
        /// <param name="item">T item berishingiz kerak</param>
        /// <returns>bool</returns>
        public bool Contains(T item)
        {
            return arr.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return arr[i];
            }
        }

        /// <summary>
        /// Parametrda berilgan element agar listda bor bo'lsa listdagi index aks holatida -1
        /// </summary>
        /// <param name="item">T item</param>
        /// <returns>int</returns>
        public int IndexOf(T item)
        {
            return Array.IndexOf(arr, item);
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
