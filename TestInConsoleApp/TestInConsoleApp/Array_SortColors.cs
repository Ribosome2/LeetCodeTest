using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class Array_SortColors
    {
        //给定一个包含红色、白色和蓝色，一共 n 个元素的数组，原地对它们进行排序，使得相同颜色的元素相邻，并按照红色、白色、蓝色顺序排列。
        //此题中，我们使用整数 0、 1 和 2 分别表示红色、白色和蓝色。

        //最直接的从小到大排序也可以解决问题
        public void SortColors(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }

        //为什么这个2n复杂度的运行时间比冒泡排序更慢
        public void SortColors1(int[] nums)
        {
            int zeroCount = 0;
            int oneCount = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                switch (nums[i])
                {
                    case 0:
                    {
                        zeroCount++;
                        break;
                    }
                    case 1:
                    {
                        oneCount++;
                        break;
                    }
                }
            }

            oneCount += zeroCount-1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < zeroCount)
                {
                    nums[i] = 0;
                }else if (i < oneCount)
                {
                    nums[i] = 1;
                }
                else
                {
                    nums[i] = 2;
                }
            }
        }
        //        进阶：
        //
        //        一个直观的解决方案是使用计数排序的两趟扫描算法。
        //        首先，迭代计算出0、1 和 2 元素的个数，然后按照0、1、2的排序，重写当前数组。
        //        你能想出一个仅使用常数空间的一趟扫描算法吗？
        //
        //        来源：力扣（LeetCode）
        //        链接：https://leetcode-cn.com/problems/sort-colors
        //        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public void SortColors2(int[] nums)
        {
            int leftIndex = 0;
            int rightIndex = nums.Length-1;
            int curIndex = 0;
            while (curIndex<rightIndex)
            {
                switch (nums[curIndex])
                {
                    case 0:
                    {
                        break;
                    }
                    case 2:
                    {
                        break;
                    }
                }
            }

        }

        void Swap(int[] arr,int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
