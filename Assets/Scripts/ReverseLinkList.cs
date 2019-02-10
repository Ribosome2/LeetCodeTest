using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseLinkList  {

    public static ListNode ReverseBetween(ListNode head, int m, int n)
    {
        if (head == null || head.next == null || m==n)
        {
            return head;
        }
        
        ListNode curNode = head;
        ListNode reverseHead = null;
        ListNode pre = null;
        ListNode next = null;
        ListNode startNode = null;
        int index = 0;
        
        while (curNode!=null)
        {
            index++;
            if (index == m - 1)
            {
                reverseHead = curNode;
            }
            if (index == m)
            {
                startNode = curNode;
                pre = curNode;
                next = curNode.next;
                break;
            }
            curNode = curNode.next;
        }

        while (next != null && index<n)
        {
            ListNode temp = null;
            temp = next.next;
            next.next = pre;
            pre = next;
            next = temp;
            index++;
        }

       
        startNode.next = next;

        if (reverseHead != null)
        {
            reverseHead.next = pre;
            return head;
        }
        else
        {
            return pre;
        }
    }

    public static ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var pre = head;
        var next = head.next;
        pre.next = null;
      
        while ( next!=null)
        {
            ListNode temp = null;
            temp = next.next;
            next.next = pre;
            pre = next;
            next = temp;
        }

        return pre;
    }
}
