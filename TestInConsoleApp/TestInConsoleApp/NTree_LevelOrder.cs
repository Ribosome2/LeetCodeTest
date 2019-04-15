using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class NTree_LevelOrder
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

//        给定一个 N 叉树，返回其节点值的层序遍历。 (即从左到右，逐层遍历)。
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> re = new List<IList<int>>();
            if (root != null)
            {
                Queue<Node> queue=new Queue<Node>();
                queue.Enqueue(root);
                while (queue.Count>0)
                {
                    int count = queue.Count;
                    List<int> list=new List<int>();
                    while (count>0)
                    {
                        var node = queue.Dequeue();
                        list.Add(node.val);
                        for (int i = 0; i < node.children.Count; i++)
                        {
                            queue.Enqueue(node.children[i]);
                        }
                        count--;
                    }
                    re.Add(list);
                }
            }
            return re;
        }
    }
}
