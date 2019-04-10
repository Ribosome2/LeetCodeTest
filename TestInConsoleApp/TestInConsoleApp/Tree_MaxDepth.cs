using System.Collections;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_MaxDepth
    {
        // Definition for a Node.
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }
            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }

            public int MaxDepth(Node root)
            {
                if (root == null)
                {
                    return 0;
                }

                if (root.children.Count == 0)
                {
                    return 1;
                }

                int maxDepth = 1;
                for (int i = 0; i < root.children.Count; i++)
                {
                    int depth= MaxDepth(root.children[i]);
                    if (depth > maxDepth)
                    {
                        maxDepth = depth;
                    }
                }

                return maxDepth+1;
            }

            public int MaxDepth1(Node root)
            {
                if (root == null)
                {
                    return 0;
                }

                if (root.children.Count == 0)
                {
                    return 1;
                }

                Queue<Node> queue=new Queue<Node>();
                queue.Enqueue(root);

                int maxDepth = 0;
                while (queue.Count>0)
                {
                    maxDepth++;
                    int count = queue.Count;
                    while (count>0)
                    {
                        count--;
                        var node = queue.Dequeue();
                        for (int i = 0; i < node.children.Count; i++)
                        {
                            queue.Enqueue(node.children[i]);
                        }
                    }
                }

                return maxDepth ;
            }
        }
    }
}