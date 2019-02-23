using System;

namespace TestInConsoleApp
{
    public class Tree_IsBalanced
    {
//        给定一个二叉树，判断它是否是高度平衡的二叉树。
//        本题中，一棵高度平衡二叉树定义为：
//        一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过1。
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            int leftDepth = GetDetpth(root.left);
            int rightDepth = GetDetpth(root.right);
            if (Math.Abs(leftDepth - rightDepth) > 1)
            {
                return false;
            }

            if (IsBalanced(root.left) == false || IsBalanced(root.right)==false)
            {
                return false;
            }
            return true;
        }

        int GetDetpth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int left = GetDetpth(node.left)+1;
            int right = GetDetpth(node.right)+1;
            return left > right ? left  : right;

        }
    }
}