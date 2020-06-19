using System;

namespace 剑指Offer
{
    public class MinArray_Test
    {
//        把一个数组最开始的若干个元素搬到数组的末尾，我们称之为数组的旋转。输入一个递增排序的数组的一个旋转，输出旋转数组的最小元素。例如，数组[3, 4, 5, 1, 2] 为[1, 2, 3, 4, 5] 的一个旋转，该数组的最小值为1
//
//            来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/xuan-zhuan-shu-zu-de-zui-xiao-shu-zi-lcof
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int MinArray(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            //这里注意要分析，中间值和左边值对比的时候并不能减治，需要跟右边值对比
            int left = 0;
            int right = numbers.Length - 1;
            while (left<right)
            {
                int mid = (right + left) / 2;
                if (numbers[mid] == numbers[right])
                {
                    right--;
                }
                else
                {
                    if (numbers[mid] > numbers[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid ;  //这里是关键，不要减1
                    }
                }
            }
            return numbers[left];
        }

        public int MinArraySimpleMind(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Length == 1)
            {
                return numbers[0];
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return numbers[i];
                }
            }

            return numbers[0];

        }
    }
}