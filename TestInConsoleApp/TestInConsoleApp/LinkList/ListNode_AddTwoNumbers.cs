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
            ListNode reList = new ListNode(-1);
            var curNode = reList;
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

                if (curNode.val < 0) //the fist one
                {
                    curNode.val = num;
                }
                else
                {
                    curNode.next=new ListNode(num);
                    curNode = curNode.next;
                }
            }

            if (temp == 1)
            {
                curNode.next = new ListNode(1);
            }

            return reList;
        }
    }
}