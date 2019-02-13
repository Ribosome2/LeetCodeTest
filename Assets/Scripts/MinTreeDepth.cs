using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class MinTreeDepth
    {

        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null && root.right == null)
            {
                return 1;
            }else if (root.left == null && root.right != null)
            {
                return MinDepth(root.right) + 1;
            }else if (root.left != null && root.right == null)
            {
                return MinDepth(root.left) + 1;
            }else //  (root.left != null && root.right != null)
            {
                int left = MinDepth(root.left) + 1;
                int right = MinDepth(root.right) + 1;
                return  left < right?left : right;
            }
        }

       
    }
}
