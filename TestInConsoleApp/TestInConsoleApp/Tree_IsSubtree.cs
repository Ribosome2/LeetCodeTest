using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_IsSubtree
    {
        //给定两个非空二叉树 s 和 t，检验 s 中是否包含和 t 具有相同结构和节点值的子树。
        //s 的一个子树包括 s 的一个节点和这个节点的所有子孙。s 也可以看做它自身的一棵子树。
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null || t == null)
            {
                return false;
            }
            Queue<TreeNode> quequeA=new Queue<TreeNode>();
            quequeA.Enqueue(s);
            while (quequeA.Count>0)
            {
                var nodeA = quequeA.Dequeue();
                if (IsSameTree(nodeA, t))
                {
                    return true;
                }

                if (nodeA.right != null)
                {
                    quequeA.Enqueue(nodeA.right);
                }
                if (nodeA.left != null)
                {
                    quequeA.Enqueue(nodeA.left);
                }

            }


            return false;
        }


        bool IsSameTree(TreeNode nodeA, TreeNode nodeB)
        {
            if (nodeA == null && nodeB == null)
            {
                return true;
            }

            if (nodeA == null || nodeB == null)
            {
                return false;
            }
         

            if (nodeA.val != nodeB.val)
            {
                return false;
            }
            else
            {
                return IsSameTree(nodeA.right, nodeB.right) && IsSameTree(nodeA.left, nodeB.left);
            }
        }
    }
}