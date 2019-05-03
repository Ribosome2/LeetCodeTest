using System;

namespace TestInConsoleApp
{
    public class Solution
    {
        private ListNode mHead;

        private int listCount = 0;
        /** @param head The linked list's head.
            Note that the head is guaranteed to be not null, so it contains at least one node. */
        public Solution(ListNode head)
        {
            mHead = head;
            var node = head;
            while (node!=null)
            {
                listCount++;
                node = node.next;
            }
        }

        /** Returns a random node's value. */
        public int GetRandom()
        {
            //todo this is not correct ,yet
            int rndIndex = new System.Random().Next(0, listCount);
            var node = mHead;
            while (rndIndex>0)
            {
                rndIndex--;
                node = node.next;
            }

            return node.val;
        }
    }
}