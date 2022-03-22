using System;
using System.Collections.Generic;
using System.Text;

namespace TestInConsoleApp.LinkList
{
    public class LinkedList_Reverse
    {
        class LinkNode
        {
            public int Value;
            public LinkNode Next;
        }
        static void PrintLinkList(LinkNode root)
        {
            StringBuilder sb = new StringBuilder();
            while (root != null)
            {
                sb.Append(" " + root.Value);
                root = root.Next;
            }

            Console.WriteLine(sb.ToString());
        }

        static LinkNode ReverseLinkList(LinkNode root)
        {
            if (root == null || root.Next == null)
            {
                return root;
            }
            else
            {
                Stack<LinkNode> stack = new Stack<LinkNode>();
                while (root != null)
                {
                    stack.Push(root);
                    root = root.Next;
                }

                var topNode = stack.Pop();
                LinkNode newLinkNode = new LinkNode()
                {
                    Value = topNode.Value,
                };
                var prevNode = newLinkNode;
                while (stack.Count > 0)
                {
                    topNode = stack.Pop();
                    LinkNode temp = new LinkNode()
                    {
                        Value = topNode.Value,
                    };
                    prevNode.Next = temp;
                    prevNode = temp;
                }

                return newLinkNode;
            }

            return root;
        }

        static  LinkNode ReverseAtPlace(LinkNode root)
        {
            if (root == null || root.Next == null)
            {
                return root;
            }

            var prev = root;
            var next = root.Next;
            prev.Next = null;
            while (next!=null)
            {
                var temp = next.Next;
                next.Next = prev;
                prev = next;
                next = temp;
            }

            return prev;
        }

        public void TestReverseLinkList()
        {
            LinkNode root = new LinkNode()
            {
                Value = 1,
                Next = new LinkNode()
                {
                    Value = 2,
                    Next = new LinkNode()
                    {
                        Value = 3,
                        Next = new LinkNode()
                        {
                            Value = 4,
                            Next = new LinkNode()
                            {
                                Value = 5,
                                Next = null,
                            }
                        }
                    }
                }
            };
            PrintLinkList(root);
//            var reverseLinkList = ReverseLinkList(root);
            var reverseLinkList = ReverseAtPlace(root);
            PrintLinkList(reverseLinkList);
        }
    }
}