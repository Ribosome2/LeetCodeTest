using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
//    实现一个二叉搜索树迭代器。你将使用二叉搜索树的根节点初始化迭代器。
//    调用 next() 将返回二叉搜索树中的下一个最小的数
//    提示：
//
//    next()和 hasNext()操作的时间复杂度是 O(1)，并使用 O(h) 内存，其中 h是树的高度。
//    你可以假设 next()调用总是有效的，也就是说，当调用 next()时，BST 中至少存在一个下一个最小的数。
//
//    来源：力扣（LeetCode）
//    链接：https://leetcode-cn.com/problems/binary-search-tree-iterator
//    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    public class BSTIterator
    {
        //内存O(n) 是叔节点的个数
        Queue<int> mQueue=new Queue<int>();
        public BSTIterator(TreeNode root)
        {
            FillData(root);
        }

        void FillData(TreeNode root)
        {
            if (root != null)
            {
                FillData(root.left);
                mQueue.Enqueue(root.val);
                FillData(root.right);
            }
        }

        /** @return the next smallest number */
        public int Next()
        {
            return mQueue.Dequeue();
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return mQueue.Count > 0;
        }
    }

}
