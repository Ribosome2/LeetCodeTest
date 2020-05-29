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

        public int[] ReversePrint2(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }
            int[] arr = new int[stack.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = stack.Pop();
            }
            return arr;
        }
    }
}