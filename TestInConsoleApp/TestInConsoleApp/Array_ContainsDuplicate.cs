using System;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_ContainsDuplicate
    {
        //给定一个整数数组，判断是否存在重复元素。
        //如果任何值在数组中出现至少两次，函数返回 true。如果数组中每个元素都不相同，则返回 false。
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int,bool> dict=new Dictionary<int, bool>();
            for (int i = 0; i < nums.Length; i++)
            {
                var n = nums[i];
                if (dict.ContainsKey(n))
                {
                    return true;
                }
                else
                {
                    dict[n] = true;
                }
            }
            return false;
        }

        //给定一个整数数组和一个整数 k，判断数组中是否存在两个不同的索引 i 和 j，使得 nums[i] = nums[j]，并且 i 和 j 的差的绝对值最大为 k。
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int maxIndex = Math.Max(nums.Length, i + k + 1);
                for (int j = i + 1; j < maxIndex; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ContainsNearbyDuplicate1(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var n = nums[i];
                if (dict.ContainsKey(n))
                {
                    if (i - dict[n] <= k)
                    {
                        return true;
                    }
                    else
                    {
                        dict[n] = i;
                    }
                }
                else
                {
                    dict[n] = i;
                }
            }
            return false;
        }
    }
}