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


        public IList<int> Preorder1(Node root)
        {
            List<int> list = new List<int>();
            
            if (root != null)
            {
                //建立一个栈，入栈的时候从右边开始入栈，就可以保证是从左边开始遍历
                Stack<Node> stack = new Stack<Node>();
                stack.Push(root);
                while (stack.Count>0)
                {
                    int count = stack.Count;
                    while (count>0)
                    {
                        count--;
                        var node = stack.Pop();
                        list.Add(node.val);
                        for (int i = node.children.Count - 1; i >= 0; i--)
                        {
                            stack.Push(node.children[i]);
                        }
                    }
                }

            }
            return list;
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