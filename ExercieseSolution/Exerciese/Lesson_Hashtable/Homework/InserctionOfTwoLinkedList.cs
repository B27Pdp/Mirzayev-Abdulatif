namespace Exerciese.Lesson_Hashtable.Homework
{
    public class Solution1
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode b = b = headB;

            while (headA != null)
            {
                while (headB != null)
                {
                    if (headA == headB) return headB;
                    headB = headB.next;
                }
                headA = headA.next;
                headB = b;
            }

            return null;
        }
    }
}
