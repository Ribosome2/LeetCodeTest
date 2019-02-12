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
          
            return GetMinNodeDepth(root, 0);
        }

        int GetMinNodeDepth(TreeNode node, int curDepth)
        {
            if (node == null)
            {
                return  curDepth;
            }

            curDepth++;

            if (node.left == null &&  node.right == null)
            {
                return curDepth;
            }

            int leftDepth = GetMinNodeDepth(node.left, curDepth); ;
            int rightDepth = GetMinNodeDepth(node.right, curDepth); ;

            if (leftDepth > rightDepth)
            {
                return leftDepth;
            }
            else
            {
                return rightDepth;
            }
        }
    }
}
