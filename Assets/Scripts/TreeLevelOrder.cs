using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class TreeLevelOrder
    {
        public List<List<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> resultList=new List<List<int>>();
            if (root != null)
            {
                Queue<TreeNode> curQueque=new Queue<TreeNode>();
                Queue<TreeNode> nextQueque = new Queue<TreeNode>();
                curQueque.Enqueue(root);
                while (curQueque.Count>0)
                {
                    List<int> list=new List<int>();
                    while (curQueque.Count>0)
                    {
                        var node = curQueque.Dequeue();
                        list.Add(node.val);

                        if (node.left != null)
                        {
                            nextQueque.Enqueue(node.left);
                        }

                        if (node.right != null)
                        {
                            nextQueque.Enqueue(node.right);
                        }
                    }
                    
                    resultList.Add(list);

                    curQueque = nextQueque;
                    nextQueque=new Queue<TreeNode>();
                    
                }

            }

            return resultList;
        }
    }
}
