using System;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_FindDisappearedNumbers
    {
//        给定一个范围在  1 ≤ a[i] ≤ n(n = 数组大小) 的 整型数组，数组中的元素一些出现了两次，另一些只出现一次。
//        找到所有在[1, n] 范围之间没有出现在数组中的数字。
//        您能在不使用额外空间且时间复杂度为O(n)的情况下完成这个任务吗? 你可以假定返回的数组不算在额外空间内。
        public List<int> FindDisappearedNumbers(int[] nums)
        {
            //别人的解答，是通过的，但是怎么理解
            List<int> re=new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = Math.Abs(nums[i]) - 1;
                nums[temp] = -Math.Abs(nums[temp]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    re.Add(i+1);
                }
            }
            return re;
        }
    }
}