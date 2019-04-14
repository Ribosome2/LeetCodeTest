using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_Preorder
    {
        
// Definition for a Node.
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node()
            {
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        //给定一个 N 叉树，返回其节点值的前序遍历。
        public IList<int> Preorder(Node root)
        {
            List<int> list=new List<int>();
            Dfs(list,root);
            return list;
        }

        void Dfs(List<int> list, Node root)
        {
            if (root != null)
            {
                list.Add(root.val);
                for (int i = 0; i < root.children.Count; i++)
                {
                    Dfs(list,root.children[i]);
                }
            }
        }

        
    }
}