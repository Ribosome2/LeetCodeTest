using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }

      public string  ToStr()
     {
        string str = val.ToString();
        var curNode = this;
        int count = 0;
        while(curNode.next!=null )
        {
            count++;
            str +="->"+ curNode.next.val.ToString();
            curNode = curNode.next;
        }
        return str;
      }
  }
 
public class LinkListMerge  {

    static public ListNode  MergeTwoLists(ListNode l1, ListNode l2)
    {
        if(l1==null)
        {
            return l2;
        }
        if(l2==null)
        {
            return l1;
        }
        ListNode firstNode = null;
        ListNode secondNode = null;
        //选第一个元素小的链表作为要返回的列表，第二列表的元素插入到第一链表或者接到末尾
        if(l1.val>l2.val)
        {
            firstNode = l2;
            secondNode = l1;
        }
        else
        {
            firstNode = l1;
            secondNode = l2;
        }
        ListNode curFirstNode = firstNode;
        ListNode curSecondeNode = secondNode;
        while(curSecondeNode!=null)
        {
            if (curFirstNode.next == null)
            {
                curFirstNode.next = curSecondeNode;
                curSecondeNode = null;
                break;
            }
            else
            {
                if(curFirstNode.val<=curSecondeNode.val && curFirstNode.next.val>curSecondeNode.val)
                {
                    //插进第一个链表
                    ListNode tempNext = curSecondeNode.next;
                    curSecondeNode.next = curFirstNode.next;
                    curFirstNode.next = curSecondeNode;
                    curFirstNode = curSecondeNode;
                    curSecondeNode = tempNext;
                }
                else
                {
                    curFirstNode = curFirstNode.next;
                }
            }
        }
        return firstNode;
    }
}
