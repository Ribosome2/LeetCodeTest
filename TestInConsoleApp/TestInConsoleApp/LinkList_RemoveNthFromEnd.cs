namespace TestInConsoleApp
{
    public class LinkList_RemoveNthFromEnd
    {
//        给定一个链表，删除链表的倒数第 n 个节点，并且返回链表的头结点。
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode fast = head, slow = head;
            while (n > 0)
            {
                fast = fast.next;
                n--;
            }
            if (fast == null)
                return slow.next;
            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return head;
        }
    }
}