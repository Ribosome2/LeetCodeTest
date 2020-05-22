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

        public int FindRepeatNumber2(int[] nums)
        {
//            算法流程
//                遍历数组 nums ，设索引初始值为 i = 0:
//            若 nums[i] == i ： 说明此数字已在对应索引位置，无需交换，因此执行 i += 1 与 continue ；
//            若 nums[nums[i]] == nums[i] ： 说明索引 nums[i] 处的元素值也为 nums[i]，即找到一组相同值，返回此值 nums[i]；
//            否则： 当前数字是第一次遇到，因此交换索引为 i 和 nums[i] 的元素值，将此数字交换至对应索引位置。
//            若遍历完毕尚未返回，则返回 - 1−1 ，代表数组中无相同值。
//
//            作者：jyd
//                链接：https://leetcode-cn.com/problems/shu-zu-zhong-zhong-fu-de-shu-zi-lcof/solution/mian-shi-ti-03-shu-zu-zhong-zhong-fu-de-shu-zi-yua/
//            来源：力扣（LeetCode）
//            著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
           
            for (int i = 0; i < nums.Length; i++)
            {
                var number = nums[i];
             

                if (number == i)
                {
                    i++;
                }
                else
                {
                    var temp = nums[number];
                    nums[number] = number;
                    nums[i] = temp;
                }
                if (nums[number] == number)
                {
                    return number;
                }


            }

            return -1;
        }
    }
}