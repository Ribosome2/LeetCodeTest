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
        }
    }
}