using System;

namespace LeetCodePractice.Medium
{
    public class AddTwoNumbers
    {
        public ListNode Solution(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode currentNode = head;
            ListNode t1 = l1, t2 = l2;
            int exceedValue = 0;

            while (t1 != null || t2 != null)
            {
                int v1 = t1?.val ?? 0;
                int v2 = t2?.val ?? 0;
                t1 = t1?.next;
                t2 = t2?.next;

                int sum = v1 + v2 + exceedValue;
                exceedValue = sum / 10;
                currentNode.next = new ListNode(sum % 10);
                currentNode = currentNode.next;
            }

            if (exceedValue > 0)
            {
                currentNode.next = new ListNode(exceedValue);
            }
            
            return head.next;
        }
    }
}