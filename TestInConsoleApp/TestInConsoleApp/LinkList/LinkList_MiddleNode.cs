using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class LinkList_MiddleNode
    {
        //给定一个带有头结点 head 的非空单链表，返回链表的中间结点。
        //如果有两个中间结点，则返回第二个中间结点。
        public ListNode MiddleNode(ListNode head)
        {
            int nodeCount = 0;
            ListNode curNode = head;
            while (curNode!=null)
            {
                nodeCount++;
                curNode = curNode.next;
            }

            int middleIndex = 0;
            middleIndex = nodeCount / 2;

            curNode = head;
            while (middleIndex>0)
            {
                middleIndex--;
                curNode = curNode.next;
            }

            return curNode;
        }

        public ListNode MiddleNode1(ListNode head)
        {
            //两个指针，快的比慢的走快一半，当快的走到头的时候，慢的就在中间
            var slow = head;
            var fast = head;
            while (fast!=null && fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
    }
}
