namespace TestInConsoleApp
{
    public class LinkList_RemoveDuplicate
    {
        //给定一个排序链表，删除所有重复的元素，使得每个元素只出现一次。
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            var node = head;
            while (node.next!=null)
            {
                if (node.next.val == node.val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }
            return head;
        }
    }
}