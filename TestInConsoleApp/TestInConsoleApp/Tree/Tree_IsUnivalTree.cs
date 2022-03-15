using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_IsUnivalTree
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (root.left != null && root.left.val != root.val)
            {
                return false;
            }
            if (root.right != null && root.right.val != root.val)
            {
                return false;
            }
            if (IsUnivalTree(root.left)==false)
            {
                return false;
            }
            if (IsUnivalTree(root.right) == false)
            {
                return false;
            }
            return true;
        }

        //如果二叉树每个节点都具有相同的值，那么该二叉树就是单值二叉树。
//        只有给定的树是单值二叉树时，才返回 true；否则返回 false。
        public bool IsUnivalTree1(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int num = root.val;
            
           Queue<TreeNode> queue=new Queue<TreeNode>();
           queue.Enqueue(root);
            while (queue.Count>0)
            {
                int count = queue.Count;
                while (count>0)
                {
                    var node = queue.Dequeue();
                    if (node.val != num)
                    {
                        return false;
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    count--;
                }
            }

            return true;
        }
    }
}