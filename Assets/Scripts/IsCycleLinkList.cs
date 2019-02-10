using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCycleLinkList {
    //为了表示给定链表中的环，我们使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。
    //如果 pos 是 -1，则在该链表中没有环。
    //用 O(1)（即，常量）内存解决此问题
    public static bool HasCycle(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return false;
        }
        //两个速度不同的点在环形的跑道上一直跑，快的点一定会追上慢的点（每超过一圈距离相遇一次）
        ListNode slow = head;
        ListNode fast = head.next;
        while (slow.next!=null)
        {

            if (slow == fast) //相遇，一定有环
            {
                return true;
            }

            if (fast.next == null || fast.next.next == null)
            {
                return false;
            }

            //慢的一次走一步，慢的一次走两步
            slow = slow.next;
            fast = fast.next.next;
        }

        return false;
    }
  
}
