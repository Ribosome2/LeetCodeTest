using System.Collections;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_LevelOrderBottom
    {
        //给定一个二叉树，返回其节点值自底向上的层次遍历。 （即按从叶子节点所在层到根节点所在的层，逐层从左向右遍历）
        public List<List<int>> LevelOrderBottom(TreeNode root)
        {
            List<List<int>> result=new List<List<int>>();
            if (root != null)
            {
                Queue<TreeNode> queque = new Queue<TreeNode>();
                Stack<List<int> > resultStack=new Stack<List<int>>();
                queque.Enqueue(root);
                while (queque.Count>0)
                {
                    int count = queque.Count;
                    List<int> list = new List<int>();
                    for (int i = 0; i < count; i++)
                    {
                        var node = queque.Dequeue();
                       
                        list.Add(node.val);
                        if (node.left != null)
                        {
                            queque.Enqueue(node.left);
                        }

                        if (node.right != null)
                        {
                            queque.Enqueue(node.right);
                        }
                    }
                    resultStack.Push(list);
                }

                while (resultStack.Count>0)
                {
                    result.Add(resultStack.Pop());
                }
            }

          

            return result;
        }
    }
}