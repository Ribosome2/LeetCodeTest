using System;
using System.Collections;
using System.Collections.Generic;

public class RotateArray {
    static public void Rotate1(int[] nums, int k)
    {
        if (nums.Length <= 1)
        {
            return;
        }
        for (int i = 0; i < k; i++)
        {
            int temp = nums[0];
            int index = 0;
            while (index<nums.Length)
            {
                if (index < nums.Length - 1)
                {
                    int v=nums[index+1];
                    nums[index + 1] = temp;
                    temp = v;
                }
                else
                {
                    nums[0] = temp;
                }
               
                index++;
            }
        }
    }

    static public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;
        for (int i = 0; i < k; i++)
        {
            int lastOne = nums[len-1];
            for (int index = len-1; index > 0; index--)
            {
                nums[index] = nums[index - 1];
            }

            nums[0] = lastOne;
        }
    }

    static public void Rotate3(int[] nums, int k)
    {
        int len = nums.Length;
        int realShift = k % len; //考虑K 会导致旋转回到原位的情况
        for (int i = 0; i < realShift; i++)
        {
            int lastOne = nums[len - 1];
            for (int index = len - 1; index > 0; index--)
            {
                nums[index] = nums[index - 1];
            }

            nums[0] = lastOne;
        }
    }

}
