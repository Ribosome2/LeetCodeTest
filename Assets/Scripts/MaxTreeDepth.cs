using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class MaxTreeDepth
{
    //二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        return GetNodeDepth(root,1);
    }

    int GetNodeDepth(TreeNode node, int curDepth)
    {
        if ( node.left == null && node.right == null)
        {
            return curDepth;
        }
        int leftDepth = 0;
        int rightDepth = 0;

        if (node.left != null)
        {
            leftDepth = GetNodeDepth(node.left, curDepth+1);
        }

        if (node.right != null)
        {
            rightDepth = GetNodeDepth(node.right, curDepth + 1);
        }

        if (leftDepth > rightDepth)
        {
            return leftDepth;
        }
        else
        {
            return rightDepth;
        }
    }
}