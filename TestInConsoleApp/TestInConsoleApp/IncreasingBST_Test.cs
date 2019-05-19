using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class IncreasingBST_Test
    {
        //给定一个树，按中序遍历重新排列树，使树中最左边的结点现在是树的根，并且每个结点没有左子结点，只有一个右子结点。
        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            Stack<TreeNode> stack=new Stack<TreeNode>();
            TreeNode resultRoot = new TreeNode(0);
            TreeNode curNode = null;
            var tempNode = root;
            while (stack.Count>0 || tempNode!=null)
            {
                if (tempNode != null )
                {
                    stack.Push(tempNode);
                    tempNode = tempNode.left;
                }
                else
                {
                    var node = stack.Pop();
                    if (curNode == null)
                    {
                        resultRoot.val = node.val;
                        curNode = resultRoot;
                    }
                    else
                    {
                        curNode.right=new TreeNode(node.val);
                        curNode = curNode.right;
                    }
                    tempNode = node.right;
                }
            }

            return   resultRoot;
        }
    }
}