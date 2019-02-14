using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class IsSameBinaryTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if ((p == null) !=( q == null))
            {
                return false;
            }

            if (p.val != q.val)
            {
                return false;
            }

            if (!IsSameTree(p.left, q.left))
            {
                return false;
            }

            if (!IsSameTree(p.right, q.right))
            {
                return false;
            }
            return true;
        }
    }
}
