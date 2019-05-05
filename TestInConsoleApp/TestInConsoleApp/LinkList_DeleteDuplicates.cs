﻿using System;
using System.Diagnostics;

namespace TestInConsoleApp
{
    public class LinkList_DeleteDuplicates
    {
        //给定一个排序链表，删除所有含有重复数字的节点，只保留原始链表中 没有重复出现 的数字
        public ListNode DeleteDuplicates(ListNode head)
        {
            var preNode =FindUniqueNode(head);
            var curNode = preNode;
            while (curNode!=null)
            {
                curNode.next = FindUniqueNode(curNode.next);
                curNode = curNode.next;
            }

            return preNode;
        }

        ListNode FindUniqueNode(ListNode node)
        {
            if (node != null)
            {
                while (node!=null)
                {
                    if (node.next == null || node.next.val != node.val)
                    {
                        return node;
                    }
                    else
                    {
                        node = node.next;
                    }
                }
                
            }
            return null;
        }
    }
}