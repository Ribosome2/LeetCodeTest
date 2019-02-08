using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseLinkList  {

    public static ListNode ReverseBetween(ListNode head, int m, int n)
    {
        if (m == n)
        {
            return head;
        }
        ListNode curNode = head;
        int index = 0;
        int firstIndex = m - 1; //M前面的一个的索引
        ListNode startNode = null;
        ListNode tempNode = null;
        ListNode nextNode = curNode.next;
        
        while (curNode!=null)
        {
            index++;
            if (index > n)
            {
                curNode = null;
                break;
            }else if (index == firstIndex)
            {
                startNode = curNode;
            }
            else if (index >= m && index < n)
            {
                if (nextNode != null)
                {
                    tempNode = nextNode.next;
                    nextNode.next = curNode;
                }
               
                if (index == (n-1))
                {
                    if (startNode != null) //有前置节点，说明不是从头开始，需要接上
                    {
                        startNode.next = curNode;
                    }
                }
                nextNode = nextNode.next;
                curNode = tempNode;
                continue;
            }
            curNode = curNode.next;
        }
        return head;
    }
}
