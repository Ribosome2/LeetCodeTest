using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_KClosestToOrigin
    {
        //我们有一个由平面上的点组成的列表 points。需要从中找出 K 个距离原点(0, 0) 最近的点。
    //    （这里，平面上两点之间的距离是欧几里德距离。）
    //你可以按任何顺序返回答案。除了点坐标的顺序之外，答案确保是唯一的。
        public int[][] KClosest(int[][] points, int K)
        {
            int[][] result = new int[K][];
            LinkedList<int[]> linkedList = new LinkedList<int[]>();
            for (int i = 0; i < points.Length; i++)
            {
                var dist = GetSquartDist(points[i]);

                AddToList(points, K, linkedList, dist, i);
            }

            var curNode = linkedList.First;
            int index = 0;
            while (curNode != null)
            {

                result[index] = curNode.Value;
                curNode = curNode.Next;
                index++;
            }

            return result;
        }



        private void AddToList(int[][] points, int K, LinkedList<int[]> linkedList, float dist, int i)
        {
            var node = linkedList.First;
            while (node != null)
            {
                if (GetSquartDist(node.Value) < dist)
                {
                    linkedList.AddBefore(node, points[i]);
                    if (linkedList.Count > K)
                    {
                        linkedList.RemoveFirst();
                    }
                    return;
                }

                node = node.Next;
            }


            linkedList.AddLast(points[i]);
            if (linkedList.Count > K)
            {
                linkedList.RemoveFirst();
            }
        }

        float GetSquartDist(int[] point)
        {
            return point[0] * point[0] + point[1] * point[1];
        }
    }
}