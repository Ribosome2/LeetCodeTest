using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class Tree_RightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> resultList =new List<int>();
            if (root != null)
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                while (queue.Count>0)
                {
                    int count = queue.Count;
                    int number = 0;
                    while (count>0)
                    {
                        var node = queue.Dequeue();
                        number = node.val;
                        if (node.left != null)
                        {
                            queue.Enqueue(node.left);
                        }

                        if (node.right != null)
                        {
                            queue.Enqueue(node.right);
                        }

                        count--;
                    }
                    resultList.Add(number);
                }
            }
           
          
            return resultList;
        }
    }
}
