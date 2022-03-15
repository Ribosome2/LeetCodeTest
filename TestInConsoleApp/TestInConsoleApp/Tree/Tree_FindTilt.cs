using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class Tree_FindTilt
    {
//        给定一个二叉树，计算整个树的坡度。
//
//        一个树的节点的坡度定义即为，该节点左子树的结点之和和右子树结点之和的差的绝对值。空结点的的坡度是0。
//
//        整个树的坡度就是其所有节点的坡度之和。
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/binary-tree-tilt
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

        public int FindTilt(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int totalTilt = 0;
            Queue<TreeNode> queue=new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count>0)
            {
                var node = queue.Dequeue();
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }

                int dif = GetNumber(node.left) - GetNumber(node.right);
                totalTilt += Math.Abs(dif);
            }

            return totalTilt;
        }


        int GetNumber(TreeNode root)
        {
            int number = 0;
            if (root != null)
            {
                number += root.val;
                number += GetNumber(root.left);
                number += GetNumber(root.right);
            }
            return number;
        }

        private int totalTilt = 0;
        public int FindTiltBetter(TreeNode root)
        {
            totalTilt = 0;
            Traverse(root);
            return totalTilt;
        }

        public int Traverse(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftSum = Traverse(root.left);
            int rightSum = Traverse(root.right);
            totalTilt += Math.Abs(leftSum - rightSum);
            //关键点在这里，做遍历的时候把当前遍历到的跟的坡度算了，并且加到最值里面，
            //比上面的实现省了重复计算子节点的和的过场
            return leftSum + rightSum + root.val;
        }

    }
}
