using System;

namespace 程序员面试金典
{
    public class MaxSubArray_Test
    {
//        给定一个整数数组，找出总和最大的连续数列，并返回总和。
        public int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int number = nums[i];
                if (sum > 0)
                {
                    sum += number;
                }
                else
                {
                    sum = number;
                }
               
                if (sum > max)
                {
                    max = sum;
                }
            }

            return max;
        }
    }
}