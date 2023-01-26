using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Hashtable.Homework
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            else if (head.next == null) return head;
            ListNode res = new();
            res = head;

            while (head.next != null)
            {
                if (head.val == head.next.val)
                {
                    if (head.next.next != null) head.next = head.next.next;
                    else head.next = null;
                }
                else
                    head = head.next;
            }
            return res;
        }
    }
}
