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

        class PriorityQueue<T>
        {
            IComparer<T> comparer;
            T[] heap;

            public int Count { get; private set; }

            public PriorityQueue() : this(null) { }
            public PriorityQueue(int capacity) : this(capacity, null) { }
            public PriorityQueue(IComparer<T> comparer) : this(16, comparer) { }

            public PriorityQueue(int capacity, IComparer<T> comparer)
            {
                this.comparer = (comparer == null) ? Comparer < T  >.Default : comparer;
                this.heap = new T[capacity];
            }

            public void Push(T v)
            {
                if (Count >= heap.Length) Array.Resize(ref heap, Count * 2);
                heap[Count] = v;
                SiftUp(Count++);
            }

            public T Pop()
            {
                var v = Top();
                heap[0] = heap[--Count];
                if (Count > 0) SiftDown(0);
                return v;
            }

            public T Top()
            {
                if (Count > 0) return heap[0];
                throw new InvalidOperationException("优先队列为空");
            }

            void SiftUp(int n)
            {
                var v = heap[n];
                for (var n2 = n / 2; n > 0 && comparer.Compare(v, heap[n2]) > 0; n = n2, n2 /= 2) heap[n] = heap[n2];
                heap[n] = v;
            }

            void SiftDown(int n)
            {
                var v = heap[n];
                for (var n2 = n * 2; n2 < Count; n = n2, n2 *= 2)
                {
                    if (n2 + 1 < Count && comparer.Compare(heap[n2 + 1], heap[n2]) > 0) n2++;
                    if (comparer.Compare(v, heap[n2]) >= 0) break;
                    heap[n] = heap[n2];
                }
                heap[n] = v;
            }
        }
    }
}