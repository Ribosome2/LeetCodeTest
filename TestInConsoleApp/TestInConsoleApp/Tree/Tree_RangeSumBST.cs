namespace TestInConsoleApp
{
    public class Tree_RangeSumBST
    {
        // 给定二叉搜索树的根结点 root，返回 L 和 R（含）之间的所有结点的值的和。
        // 二叉搜索树保证具有唯一的值。
        //  二叉查找树(Binary Search Tree)，(又:二叉搜索树，二叉排序树)它或者是一棵空树，或者是具有下列性质的二叉树: 若它的左子树不空，
        //则左子树上所有结点的值均小于它的根结点的值; 若它的右子树不空，则右子树上所有结点的值均大于它的根结点的值; 它的左、右子树也分别为二叉排序树。
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null)
            {
                return 0;
            }
            int res = 0;

           

            if( L <= root.val  && root.val<= R)
            {
                res += root.val;
            }

            if (L <= root.val)
            {
                //如果当前节点比左边界小，则该节点的左子树不用遍历了（都是小于该节点的值，已超出范围）
                res += RangeSumBST(root.left, L, R);
            }

            if (root.val <= R)
            {
                //如果当前节点比右边界大，则该节点的右子树不用遍历了（都是大于该节点的值）
                res += RangeSumBST(root.right, L, R);
            }

            return res;
        }
    }
}