using System;

namespace TestInConsoleApp
{
    public class Array_ArrayPairSum
    {
        //给定长度为 2n 的数组, 你的任务是将这些数分成 n 对,
        //例如 (a1, b1), (a2, b2), ..., (an, bn) ，使得从1 到 n 的 min(ai, bi) 总和最大。
        public int ArrayPairSum(int[] nums)
        {
            int sum = 0;
            Array.Sort(nums);
            for (int i = nums.Length - 2; i >= 0; i -= 2)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}