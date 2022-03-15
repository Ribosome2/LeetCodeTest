using System.Collections;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_IsSymmetric
    {
        //给定一个二叉树，检查它是否是镜像对称的
        public bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);
        }


        bool IsMirror(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }

            if (node1 == null || node2 == null)
            {
                return false;
            }

            if (node1.val != node2.val)
            {
                return false;
            }

            if (IsMirror(node1.left, node2.right) == false || IsMirror(node1.right, node2.left) == false)
            {
                return false;
            }

            return true;
        }


        //用 迭代的方法
        public bool IsSymmetric2(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node1 = queue.Dequeue();
                var node2 = queue.Dequeue();
                if (node1 == null && node2 == null)
                {
                    continue;
                }

                if (node1 == null || node2 == null)
                {
                    return false;
                }

                if (node1.val != node2.val)
                {
                    return false;
                }

                queue.Enqueue(node1.left);
                queue.Enqueue(node2.right);
                queue.Enqueue(node2.left);
                queue.Enqueue(node1.right);
            }

            return true;
        }

    }
}