using System.Collections;
using System.Collections.Generic;
namespace TestInConsoleApp
{
    public class Tree_SearchBST
    {
// 二叉查找树(Binary Search Tree)，(又:二叉搜索树，二叉排序树)它或者是一棵空树，或者是具有下列性质的二叉树:
// 若它的左子树不空，则左子树上所有结点的值均小于它的根结点的值;
// 若它的右子树不空， 则右子树上所有结点的值均大于它的根结点的值; 它的左、右子树也分别为二叉排序树。
        public TreeNode SearchBST1(TreeNode root, int val) {
            if (root == null)
            {
                return null;
            }
            Queue<TreeNode> queque = new Queue<TreeNode>();
            queque.Enqueue(root);
            while (queque.Count>0)
            {
                int count = queque.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queque.Dequeue();
                    if (node.val == val)
                    {
                        return node;
                    }

                    if (node.left != null)
                    {
                        queque.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queque.Enqueue(node.right);
                    }
                }
            }
            return null;
        }
        
        public TreeNode SearchBST(TreeNode root, int val) {
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }
            
            //根据左子节点一定比根节点小，右节点已经比根节点大
            if (root.val > val)
            {
                return SearchBST(root.left, val);
            }
            else
            {
                return SearchBST(root.right, val);
            }
            
        }
    }
}