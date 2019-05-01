using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class ListNode_AddTwoNumbers
    {
  //Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode node1 = l1;
            ListNode node2 = l2;
            Queue<int> reQueque=new Queue<int>();
            int temp = 0;
            while (node1!=null || node2!=null)
            {
                int num = 0;
                if (node1!=null)
                {
                    num += node1.val;
                    node1 = node1.next;
                }

                if (node2!=null)
                {
                    num += node2.val;
                    node2 = node2.next;
                }

                num += temp;
                if (num < 10)
                {
                   
                    temp = 0;
                }
                else
                {
                    num -= 10;
                    temp = 1;
                }
                
                reQueque.Enqueue(num);
            }

            if (temp == 1)
            {
                reQueque.Enqueue(1);
            }

            if (reQueque.Count == 0)
            {
                return null;
            }
            else
            {
                ListNode re=new ListNode(reQueque.Dequeue());
                var curNode = re;
                while (reQueque.Count>0)
                {
                    curNode.next=new ListNode(reQueque.Dequeue());
                    curNode = curNode.next;
                }

                return re;
            }
        }
    }
}