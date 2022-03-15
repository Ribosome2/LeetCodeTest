using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Tree_AverageOfLevels
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> reList=new List<double>();
            Queue<TreeNode> queue=new Queue<TreeNode>();
            if (root != null)
            {
                queue.Enqueue(root);
            }
            int count = queue.Count;
            double sum = 0;
            while (queue.Count>0)
            {
                count = queue.Count;
                sum = 0;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                reList.Add(sum / count);
            }

            return reList;
        }
    }
}