using System.Collections;
using  System.Collections.Generic;
namespace TestInConsoleApp
{
    public class Tree_LeafSimilar
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2) {
            var  dataContainer1=new List<int>();
            var dataContainer2=new List<int>();
            FindLeaf(root1,dataContainer1);
            FindLeaf(root2,dataContainer2);
            if (dataContainer1.Count != dataContainer2.Count)
            {
                return false;
            }

            for (int i = 0; i < dataContainer1.Count; i++)
            {
                if (dataContainer1[i] != dataContainer2[i])
                {
                    return false;
                }
            }

            return true;

        }

        void FindLeaf(TreeNode root, List<int> queue)
        {
            if (root != null)
            {
                if (root.left == null && root.right == null)
                {
                    queue.Add(root.val);
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