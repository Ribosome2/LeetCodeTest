using System.Collections.Generic;

namespace 剑指Offer
{
    public class FindRepeatNumber_Test
    {
//        在一个长度为 n 的数组 nums 里的所有数字都在 0～n-1 的范围内。数组中某些数字是重复的，但不知道有几个数字重复了，也不知道每个数字重复了几次。请找出数组中任意一个重复的数字
//
//            来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/shu-zu-zhong-zhong-fu-de-shu-zi-lcof
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int FindRepeatNumber(int[] nums)
        {
            bool[] arr= new bool[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                var number = nums[i];
                if (arr[number])
                {
                    return number;
                }

                arr[number] = true;

            }

            return -1;
        }

        public int FindRepeatNumber1(int[] nums)
        {
            Dictionary<int, bool> record =new  Dictionary<int, bool>();
            for (int i = 0; i < nums.Length; i++)
            {
                var number = nums[i];
                if (record.ContainsKey(number))
                {
                    return number;
                }

                record[number] = true;

            }

            return -1;
        }
    }
}