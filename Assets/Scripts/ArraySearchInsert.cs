using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraySearchInsert  {

    public static  int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length;
        int index = 0;
        while (left!=right)
        {
            int middle =left+ (right-left) / 2;
            var val = nums[middle];
            if (val == target)
            {
                return middle;
            }else if (val > target)
            {
                right = middle;
                index = middle;
            }
            else
            {
                index = middle+1;
                left = middle+1 ;
            }
        }
        return index;
    }
}
