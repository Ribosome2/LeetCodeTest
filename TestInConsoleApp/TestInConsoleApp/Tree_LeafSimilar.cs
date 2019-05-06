using  System.Collections.Generic;
namespace TestInConsoleApp
{
    public class Tree_LeafSimilar
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2) {
            Queue<int> leafQueque1=new Queue<int>();
            Queue<int> leafQueque2=new Queue<int>();
            FindLeaf(root1,leafQueque1);
            FindLeaf(root2,leafQueque2);
            if (leafQueque1.Count != leafQueque2.Count)
            {
                return false;
            }
            else
            {
                while (leafQueque1.Count>0)
                {
                    if (leafQueque1.Dequeue() != leafQueque2.Dequeue())
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        void FindLeaf(TreeNode root, Queue<int> queue)
        {
            if (root != null)
            {
                if (root.left == null && root.right == null)
                {
                    queue.Enqueue(root.val);
                }
                else
                {
                    FindLeaf(root.left,queue);
                    FindLeaf(root.right,queue);
                }
            }
        }
    }
    
    
    
}