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
        private int[] nums;
        private int k;
        private int count;

        public KthLargest(int k, int[] nums)
        {
            this.nums = new int[k + 1];
            this.k = k;
            this.count = 0;
            heapify(nums);

        }

        public int Add(int num)
        {
            if (count == k && num < nums[1])
            {
                return nums[1];
            }

            if (count >= k)
            {
                nums[1] = num;
                siftDown(1);
            }
            else
            {
                nums[++count] = num;
                siftUp(count);
            }

            return nums[1];

        }

        private void siftUp(int index)
        {
            while (index > 1 && nums[index] < nums[index / 2])
            {
                swap(index, index / 2);
                index = index / 2;
            }
        }

        private void siftDown(int index)
        {
            while (2 * index <= count)
            {
                int j = 2 * index;
                if (j < count && nums[j] > nums[j + 1]) j++;
                if (nums[index] <= nums[j]) break;
                swap(index, j);
                index = j;
            }
        }

        //build min heap
        private void heapify(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Add(nums[i]);
            }
        }

        private void swap(int i, int j)
        {
            int origin = nums[j];
            nums[j] = nums[i];
            nums[i] = origin;
        }
    }
}

