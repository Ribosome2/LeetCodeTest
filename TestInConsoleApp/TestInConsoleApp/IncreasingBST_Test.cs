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
            Queue<int> dataContainer=new Queue<int>();
            Stack<TreeNode> stack=new Stack<TreeNode>();
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
                    dataContainer.Enqueue(node.val);
                    tempNode = node.right;
                }
            }
            TreeNode resultRoot=new TreeNode(dataContainer.Dequeue());
            TreeNode curNode = resultRoot;
            while (dataContainer.Count>0)
            {
                curNode.right=new TreeNode(dataContainer.Dequeue());
                curNode = curNode.right;
            }

            return   resultRoot;
        }
    }
}