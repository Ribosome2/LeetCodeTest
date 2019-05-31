using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_Connect
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node()
            {
            }

            public Node(int _val, Node _left=null, Node _right=null, Node _next=null)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
        //        给定一个完美二叉树，其所有叶子节点都在同一层，每个父节点都有两个子节点。二叉树定义如下：
        //        struct Node
        //        {
        //            int val;
        //            Node* left;
        //            Node* right;
        //            Node* next;
        //        }
        //        填充它的每个 next 指针，让这个指针指向其下一个右侧节点。如果找不到下一个右侧节点，则将 next 指针设置为 NULL。
        //        初始状态下，所有 next 指针都被设置为 NULL。
//        你只能使用常量级额外空间。
//        使用递归解题也符合要求，本题中递归程序占用的栈空间不算做额外的空间复杂度。
        public Node Connect1(Node root)
        {
            //队列方法层次遍历可以解题，但是应该不算常量级额外空间
            Queue<Node> queque=new Queue<Node>();

            if (root != null)
            {
                queque.Enqueue(root);
               
                while (queque.Count>0)
                {
                    int count = queque.Count;
                    while (count>0)
                    {
                        Node node = queque.Dequeue();
                        if (node.left != null)
                        {
                            queque.Enqueue(node.left);
                        }

                        if (node.right != null)
                        {
                            queque.Enqueue(node.right);
                        }

                        if (count > 1)
                        {
                            node.next = queque.Peek();
                        }
                        count--;
                    }
                }

            }
            return root; 
        }

        /// <summary>
        /// 递归的写法
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node Connect(Node root)
        {
            if (root == null)
                return root;
            if (root.left != null)
            {
                root.left.next = root.right;
            }
               
            if (root.next != null && root.right != null)
            {
                root.right.next = root.next.left;
            }
            Connect(root.left);
            Connect(root.right);
            return root;
        }
    }
}