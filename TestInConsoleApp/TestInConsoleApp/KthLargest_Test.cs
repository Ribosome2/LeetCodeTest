using System;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    /// <summary>
    /// Not understand how this work,yet
    /// </summary>
    public class KthLargest
    {

        //设计一个找到数据流中第K大元素的类（class）。注意是排序后的第K大元素，不是第K个不同的元素。
        //你的 KthLargest 类需要一个同时接收整数 k 和整数数组nums 的构造器，它包含数据流中的初始元素。
        //每次调用 KthLargest.add，返回当前数据流中第K大的元素。
        private int maxSize = 0;
        private PriorityQueue<int> priorityQueue;
        public  class CustomCompare : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return x - y;
            }
        }
        public KthLargest(int k, int[] nums)
        {
            maxSize = k;
            priorityQueue = new PriorityQueue<int>(maxSize, new CustomCompare());
            for (int i = 0; i < nums.Length; i++)
            {
                priorityQueue.Push(nums[i]);
                CheckMax();
            }
        }

        private void CheckMax()
        {
            if (priorityQueue.Count > maxSize)
            {
                priorityQueue.Pop();
            }
        }

        public int Add(int num)
        {
            priorityQueue.Push(num);
            CheckMax();
            return priorityQueue.Top();
        }
        
       

    }

    
}

