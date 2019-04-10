using System;

namespace TestInConsoleApp
{
    // Definition for a QuadTree node.
    public class Node
    {
        public bool val;
        public bool isLeaf;
        public Node topLeft;
        public Node topRight;
        public Node bottomLeft;
        public Node bottomRight;

        public Node()
        {
        }

        public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = _topLeft;
            topRight = _topRight;
            bottomLeft = _bottomLeft;
            bottomRight = _bottomRight;
        }
    }

    public class QuadTree_Intersect
    {

        public Node Intersect(Node quadTree1, Node quadTree2)
        {

            if (quadTree1 == null && quadTree2==null)
            {
                return null;
            }else if (quadTree1 == null)
            {
                return quadTree2;
            }else if (quadTree2 == null)
            {
                return quadTree1;
            }

            if (quadTree1.bottomLeft != null)
            {
                quadTree1.bottomLeft.val = GetNodeValue(quadTree1.bottomLeft) || GetNodeValue(quadTree2.bottomLeft);
                Console.WriteLine("BL "+quadTree1.bottomLeft.val);
                quadTree1.bottomLeft.isLeaf = true;
            }

            if (quadTree1.bottomRight != null)
            {
                quadTree1.bottomRight.val = GetNodeValue(quadTree1.bottomRight) || GetNodeValue(quadTree2.bottomRight);
                quadTree1.bottomRight.isLeaf = true;
            }

            if (quadTree1.topLeft != null)
            {
                quadTree1.topLeft.val = GetNodeValue(quadTree1.topLeft) || GetNodeValue(quadTree2.topLeft);
                quadTree1.topLeft.isLeaf = true;
            }

            if (quadTree1.topRight != null)
            {
                quadTree1.topRight.val = GetNodeValue(quadTree1.topRight) || GetNodeValue(quadTree2.topRight);
                quadTree1.topRight.isLeaf = true;
            }

         
            return quadTree1;
        }

        bool GetNodeValue(Node quadTree1)
        {
            if (quadTree1 == null)
            {
                return false;
            }

            if (quadTree1.isLeaf)
            {
                return quadTree1.val;
            }
            else
            {
                bool value= GetNodeValue(quadTree1.bottomLeft) || GetNodeValue(quadTree1.bottomRight) ||
                            GetNodeValue(quadTree1.topLeft) || GetNodeValue(quadTree1.topRight);
                quadTree1.val = value;
                quadTree1.isLeaf = true;
                return value;
            }
        }
    }
}