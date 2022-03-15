using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_InorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> reList=new List<int>();
            RecursiveTraversal(root,reList);
            return reList;
        }

        void RecursiveTraversal(TreeNode node,List<int> list)
        {
            if (node != null)
            {
                RecursiveTraversal(node.left,list);
                list.Add(node.val);
                RecursiveTraversal(node.right,list);
            }
        }

        public IList<int> InorderTraversal_NoRecursive(TreeNode root)
        {
            List<int> reList = new List<int>();
           
            Stack<TreeNode> stack=new Stack<TreeNode>();
            TreeNode node = root;
            while (node!=null || stack.Count!=0)
            {
                if (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
                else
                {
                    var tempNode = stack.Pop();
                    reList.Add(tempNode.val);
                    node = tempNode.right;
                }
            }

            return reList;
        }
    }
}