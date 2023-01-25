using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Collections.Leetcode._225._Implement_Stack_using_Queues
{
    public class MyStack
    {
        public MyStack()
        {
            que = new Queue<int>();

        }

        Queue<int> que;
        public void Push(int x)
        {
            que.Enqueue(x);
        }

        public int Pop()
        {
            for (int i = 0; i < que.Count - 1; i++)
            {
                int j = que.Dequeue();
                que.Enqueue(j);
            }
            return que.Dequeue();
        }

        public int Top()
        {
            int i = Pop();
            que.Enqueue(i);
            return i;
        }

        public bool Empty()
        {
            return que.Count == 0;
        }
    }
}
