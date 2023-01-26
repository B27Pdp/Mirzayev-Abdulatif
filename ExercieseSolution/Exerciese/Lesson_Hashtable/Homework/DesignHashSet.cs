using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Hashtable.Homework
{
    public class MyHashSet
    {
        ArrayList list;

        public MyHashSet() => list = new ArrayList();

        public void Add(int key) { if (!Contains(key)) list.Add(key); }

        public void Remove(int key) { if (Contains(key)) list.Remove(key); }

        public bool Contains(int key) { return list.Contains(key); }
    }
}
