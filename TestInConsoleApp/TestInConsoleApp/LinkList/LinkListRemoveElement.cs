using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class LinkListRemoveElement
    {
        //删除链表中等于给定值 val 的所有节点
        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode pre = null;
            ListNode cur = head;
            while (cur!=null)
            {
                if (cur.val == val)
                {
                    if (pre != null)
                    {
                        pre.next = cur.next;
                        cur = cur.next;
                    }
                    else
                    {
                        //要删除的是头
                        head = cur.next;
                        cur = head;
                    }
                }
                else
                {
                    pre = cur;
                    cur = cur.next;
                }
              
            }
            
            return head;
        }

        //链表至少包含两个节点。
        //链表中所有节点的值都是唯一的。
        //给定的节点为非末尾节点并且一定是链表中的一个有效节点。
        //不要从你的函数中返回任何结果。
        public static  void DeleteNode(ListNode node)
        {
            //不允许访问前置节点的情况下,要删除指定节点，其实不是删除Node只是把值改了
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
