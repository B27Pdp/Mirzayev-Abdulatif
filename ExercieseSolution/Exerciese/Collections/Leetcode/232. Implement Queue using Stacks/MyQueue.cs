using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Collections.Leetcode._232._Implement_Queue_using_Stacks
{
    public class MyQueue
    {

        private Stack<int> stack1 = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();
        public MyQueue()
        {
        }

        public void Push(int x)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(x);
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }
        }

        public int Pop()
        {
            return stack1.Pop();
        }

        public int Peek()
        {
            return stack1.Peek();
        }

        public bool Empty()
        {
            return stack1.Count == 0;
        }
    }
}
