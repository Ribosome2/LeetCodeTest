using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class NextGreaterElement_Test
    {
//        给定两个没有重复元素的数组 nums1 和 nums2 ，其中nums1 是 nums2 的子集。找到 nums1 中每个元素在 nums2 中的下一个比其大的值。
//        nums1 中数字 x 的下一个更大元素是指 x 在 nums2 中对应位置的右边的第一个比 x 大的元素。如果不存在，对应位置输出-1。
        public int[] NextGreaterElement(int[] nums1, int[] nums2) {
            int[] re=new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                re[i] = FindNextGreater(nums1[i], nums2);
            }
            return re;
            //复杂度 N1*N2
        }

        int FindNextGreater(int num, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] > num)
                        {
                            return arr[j];
                        }
                    }
                }
            }
            return -1;
        }
        
        
        public int[] NextGreaterElement1(int[] nums1, int[] nums2) {
            int[] re=new int[nums1.Length];
            
            
            Dictionary<int, int> tempDict=new Dictionary<int,int>();
            for (int index = 0; index < nums2.Length; index++)
            {
                int num = nums2[index];
                tempDict[num] = -1;
                for (int j = index + 1; j < nums2.Length; j++)
                {
                    if (nums2[j] > num)
                    {
                        tempDict[num] = nums2[j];
                        break;
                    }
                }
            }
            
            
            for (int i = 0; i < nums1.Length; i++)
            {
                re[i] = tempDict[nums1[i]];
            }
            return re;
        }
    }
}