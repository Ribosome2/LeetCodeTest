using  System.Collections;
using  System.Collections.Generic;
namespace TestInConsoleApp
{
    public class Tree_Postorder
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


//        给定一个 N 叉树，返回其节点值的后序遍历。
        public IList<int> Postorder(Node root) {
            List<int> list=new List<int>();

            if (root != null)
            {
                Queue<Node> queue=new Queue<Node>();
                queue.Enqueue(root);
                Stack<int> stack=new Stack<int>();

                while (queue.Count>0)
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        var node = queue.Dequeue();
                        stack.Push(node.val);
                        for (int index = 0; index < node.children.Count; index++)
                        {
                            queue.Enqueue(node.children[node.children.Count-1-index]);
                        }
                    }
                }

                while (stack.Count>0)
                {
                    list.Add(stack.Pop());
                }
            }
            
            return list;
        }
    }
}