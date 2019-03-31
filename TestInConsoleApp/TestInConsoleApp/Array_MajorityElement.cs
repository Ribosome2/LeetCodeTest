using System;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_MajorityElement
    {
        //定一个大小为 n 的数组，找到其中的众数。众数是指在数组中出现次数大于 ⌊ n/2 ⌋ 的元素。
        //你可以假设数组是非空的，并且给定的数组总是存在众数。
        public int MajorityElement(int[] nums)
        {
            int result = 0;
            int maxCount = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var n = nums[i];
                if (dict.ContainsKey(n))
                {
                    dict[n] = dict[n] + 1;
                }
                else
                {
                    dict[n] = 1;
                }

                if (dict[n] > maxCount)
                {
                    result = n;
                    maxCount = dict[n];
                }

            }

            return result;
        }

        public int MajorityElement1(int[] nums)
        {
            //计数法
            int count = 1;
            int num = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == num)
                {
                    count++;
                }
                else
                {
                    count--;
                    if (count == 0)
                    {
                        num = nums[i];
                        count = 1;
                    }
                }
            }

            return num;
        }

        public int MajorityElement2(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }
    }
}