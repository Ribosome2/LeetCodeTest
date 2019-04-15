using System;

namespace TestInConsoleApp
{
 

    public class QuadTree_Intersect
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

            Node resultNode=new Node();
            if (quadTree1.isLeaf && quadTree2.isLeaf)
            {
                resultNode.val = quadTree1.val || quadTree2.val;
                resultNode.isLeaf = true;
            }
            else
            {
                
            }
            
            
         
            return resultNode;
        }

       
    }
}