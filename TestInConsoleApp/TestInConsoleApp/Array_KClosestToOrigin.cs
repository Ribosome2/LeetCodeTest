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
            LinkedList<PointData> linkedList = new LinkedList<PointData>();
            for (int i = 0; i < points.Length; i++)
            {
                var dist = GetSquartDist(points[i]);
                AddToList( K, linkedList, dist, i);
            }

            var curNode = linkedList.First;
            int index = 0;
            while (curNode != null)
            {

                result[index] = points[curNode.Value.Index];
                curNode = curNode.Next;
                index++;
            }

            return result;
        }

        struct PointData
        {
            public float Dist;
            public int Index;
        }

        private void AddToList( int K, LinkedList<PointData> linkedList, float dist, int i)
        {
            var node = linkedList.First;
            while (node != null)
            {
                if (node.Value.Dist < dist)
                {
                    linkedList.AddBefore(node, new PointData(){Dist = dist,Index = i});
                    if (linkedList.Count > K)
                    {
                        linkedList.RemoveFirst();
                    }
                    return;
                }

                node = node.Next;
            }


            linkedList.AddLast(new PointData() { Dist = dist, Index = i });
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