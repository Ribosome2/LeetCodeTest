namespace 剑指Offer
{
    public class GetKthFromEnd_Test
    {
        public ListNode GetKthFromEnd(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }

            ListNode fastNode = head;
            while (k>0)
            {
                if (fastNode == null)
                {
                    return null;
                }

                fastNode = fastNode.next;
                k--;
            }

            while (fastNode!=null)
            {
                fastNode = fastNode.next;
                head = head.next;
            }
            return head;
        }
    }
}