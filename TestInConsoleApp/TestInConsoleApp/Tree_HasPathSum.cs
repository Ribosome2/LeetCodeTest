using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_HasPathSum
    {
        //给定一个二叉树和一个目标和，判断该树中是否存在根节点到叶子节点的路径，这条路径上所有节点值相加等于目标和。
        //说明: 叶子节点是指没有子节点的节点。
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }
           
            if (sum == root.val && root.left==null && root.right==null)
            {
                return true;
            }

            if (CheckChildNode(root.left, sum - root.val))
            {
                return true;
            }

            if (CheckChildNode(root.right, sum - root.val))
            {
                return true;
            }

            return false;
        }

        bool CheckChildNode(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            if (sum == root.val && root.left == null && root.right == null)
            {
                return true;
            }

            if (HasPathSum(root.left, sum - root.val))
            {
                return true;
            }

            if (HasPathSum(root.right, sum - root.val))
            {
                return true;
            }

            return false;
        }
    }
}