using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Hashtable.Homework
{
    public class Solution2
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head.next == null) return head;

            ListNode old = head;
            int count = 0, pos = 0;

            while (head.next != null)
            {
                head = head.next;
                count++;
            }
            pos = count / 2;
            while (count != 0)
            {
                if (count > pos)
                {
                    old = old.next;
                    count--;
                }
                if (count == pos) break;
            }
            return old;
        }
    }
}
