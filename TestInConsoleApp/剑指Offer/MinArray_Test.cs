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

            if (numbers.Length == 1)
            {
                return numbers[0];
            }

            if (numbers.Length == 2)
            {
                return Math.Min(numbers[0], numbers[1]);
            }
            //在数组头和尾选两个指针，如果左指针大于右指针，我们就可以判断旋转的分解线
            int leftIndex = 1;
            int rightIndex = numbers.Length - 1;
            int mid = leftIndex;
           
            while (leftIndex<rightIndex)
            {
                if (numbers[mid - 1] > numbers[mid])
                {
                    return numbers[mid];
                }

                if (numbers[mid] > numbers[mid + 1])
                {

                }



                else
                {
                    if (numbers[mid] >= numbers[0])
                    {
                        leftIndex = mid + 1;
                    }
                    else
                    {
                        rightIndex = mid - 1;
                    }
                }
                mid = (rightIndex + leftIndex) / 2;
            }
            return numbers[0];
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