using System;

namespace TestInConsoleApp
{
    public class MinSubArrayLen_Test
    {
        //给定一个含有 n 个正整数的数组和一个正整数 s ，找出该数组中满足其和 ≥ s 的长度最小的连续子数组。如果不存在符合条件的连续子数组，返回 0。
        public int MinSubArrayLen(int s, int[] nums)
        {
            //滑动窗口算法：
            int left = 0;
            int sum = 0;
            int len = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];
                while (sum >= s)
                {
                    if (len == 0)
                    {
                        len = right - left + 1;
                    }
                    else
                    {
                        len=Math.Min(len, right - left + 1);
                    }
                    sum -= nums[left];
                    left++;
                }
            }
            return len;
        }
    }
}