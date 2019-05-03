using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_SumNumbers
    {
        //给定一个二叉树，它的每个结点都存放一个 0-9 的数字，每条从根到叶子节点的路径都代表一个数字。
//        例如，从根到叶子节点路径 1->2->3 代表数字 123。
//        计算从根到叶子节点生成的所有数字之和。
//        说明: 叶子节点是指没有子节点的节点。
        public int SumNumbers(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            List<int> numList=new List<int>();
            CheckAddList(root.val,root,numList);
            int sum = 0;
            for (int i = 0; i < numList.Count; i++)
            {
                sum += numList[i];
            }

            return sum;
        }

        void CheckAddList(int curNum, TreeNode node,List<int> numList)
        {
            if (node == null || (node.left == null && node.right == null))
            {
                numList.Add(curNum);
                return;
            }

            //每遇到一个右节点就是一个新分支
            if (node.right != null)
            {
                CheckAddList(curNum * 10 + node.right.val, node.right, numList);
            }

            if (node.left != null)
            {
                CheckAddList(curNum * 10 + node.left.val, node.left, numList);
            }
        }
      
    }
}