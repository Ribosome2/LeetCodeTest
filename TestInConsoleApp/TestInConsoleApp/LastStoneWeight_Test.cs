using System;
using System.Collections;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class LastStoneWeight_Test
    {
//        有一堆石头，每块石头的重量都是正整数。
//        每一回合，从中选出两块最重的石头，然后将它们一起粉碎。假设石头的重量分别为 x 和 y，且 x <= y。那么粉碎的可能结果如下：
//        如果 x == y，那么两块石头都会被完全粉碎；
//        如果 x != y，那么重量为 x 的石头将会完全粉碎，而重量为 y 的石头新重量为 y-x。
//        最后，最多只会剩下一块石头。返回此石头的重量。如果没有石头剩下，就返回 0。
        public int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 0)
            {
                return 0;
            }
            if (stones.Length ==1)
            {
                return stones[0];
            }

            PriorityQueue<int> priorityQueue=new PriorityQueue<int>(stones.Length);
            for (int i = 0; i < stones.Length; i++)
            {
                priorityQueue.Push(stones[i]);
            }
            while (priorityQueue.Count>1)
            {
                int first = priorityQueue.Pop();
                int second = priorityQueue.Pop();
                if (first != second)
                {
                    priorityQueue.Push(first-second);
                }
            }

            if (priorityQueue.Count == 1)
            {
                return priorityQueue.Top();
            }

            return 0;
        }
    }
}