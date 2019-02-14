using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class FindLinkListIntersectNode
    {
        //如果两个链表没有交点，返回 null.
        //在返回结果后，两个链表仍须保持原有的结构。
        //可假定整个链表结构中没有循环。
        //程序尽量满足 O(n) 时间复杂度，且仅用 O(1) 内存。
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            int lenA = 0;
            int lenB = 0;

            var curNodeA = headA;
            while (curNodeA.next!=null )
            {
                lenA++;
                curNodeA = curNodeA.next;
            }

            var curNodeB = headB;
            while (curNodeB.next!=null)
            {
                lenB++;
                curNodeB = curNodeB.next;
            }

            //根据如果有相交，相交后面的节点都是一样的，开始可能有相交的点从后面向前数的步数肯定是一样的
            curNodeA = headA;
            curNodeB = headB;
            //先把长的链表起点修正到跟短的节点距离终点一致
            if (lenA != lenB)
            {
                if (lenA > lenB)
                {
                    int dist = lenA - lenB;
                    while (dist>0)
                    {
                        curNodeA = curNodeA.next;
                        dist--;
                    }
                }
                else
                {
                    int dist = lenB - lenA;
                    while (dist>0)
                    {
                        curNodeB = curNodeB.next;
                        dist--;
                    }
                }
                
            }

            while (curNodeA!=null && curNodeB!=null)
            {
                if (curNodeA == curNodeB)
                {
                    return curNodeA;
                }
                curNodeA = curNodeA.next;
                curNodeB = curNodeB.next;
            }
           
            return null;
        }
    }
}
