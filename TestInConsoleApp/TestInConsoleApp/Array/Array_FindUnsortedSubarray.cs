using System;

namespace TestInConsoleApp
{
    public class Array_FindUnsortedSubarray
    {
        //给定一个整数数组，你需要寻找一个连续的子数组，如果对这个子数组进行升序排序，那么整个数组都会变为升序排序。
        //你找到的子数组应是最短的，请输出它的长度。
        public int FindUnsortedSubarray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int len = 0;
            int left = -1;
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < max)
                {
                    if (left < 0)
                    {
                        left = i;
                        len = 2;
                    }
                    else
                    {
                        len=Math.Max(len, i+2 - left);
                    }
                }

                max = Math.Max(max, nums[i]);
            }
            return len;
        }
    }
}