using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Leeson_Enumerable.Classwork
{
    public class MyList : IEnumerable
    {
        List<int> list = new List<int>();
        public MyList(int[] arr) 
        { 
            list.AddRange(arr);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }
    }
}
