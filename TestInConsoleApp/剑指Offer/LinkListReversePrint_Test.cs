using System.Collections.Generic;

namespace 剑指Offer
{
    public class LinkListReversePrint_Test
    {
//        输入一个链表的头节点，从尾到头反过来返回每个节点的值
        public int[] ReversePrint(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            while (head!=null)
            {
                stack.Push(head.val);
                head = head.next;
            }
            return stack.ToArray();
        }
    }
}