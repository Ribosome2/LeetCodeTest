using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_FindSecondMinimumValue
    {
//        给定一个非空特殊的二叉树，每个节点都是正数，并且每个节点的子节点数量只能为 2 或 0。如果一个节点有两个子节点的话，
//        那么这个节点的值不大于它的子节点的值。 
//        给出这样的一个二叉树，你需要输出所有节点中的第二小的值。如果第二小的值不存在的话，输出 -1 。
        public int FindSecondMinimumValue(TreeNode root)
        {
            int secondMin = -1;
            int min = int.MaxValue;
            if (root != null)
            {
                Queue<TreeNode> queue=new Queue<TreeNode>();
                queue.Enqueue(root);
                while (queue.Count>0)
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        var node = queue.Dequeue();
                        if (node.val < min)
                        {
                            secondMin = min;
                            min = node.val;
                        }
                        else
                        {
                            if (node.val > min && node.val<secondMin)
                            {
                                secondMin = node.val;
                            }
                        }

                        if (node.left != null)
                        {
                            queue.Enqueue(node.left);
                        }
                        if (node.right != null)
                        {
                            queue.Enqueue(node.right);
                        }
                    }
                }
            }

            if (secondMin == int.MaxValue)
            {
                return -1;
            }
            
            return secondMin;
        }
    }
}