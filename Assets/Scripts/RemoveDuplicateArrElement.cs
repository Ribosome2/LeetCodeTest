using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveDuplicateArrElement : MonoBehaviour {
    public static int RemoveElement(int[] nums, int val)
    {
        int validIndex= 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[validIndex] = nums[i];
                validIndex++;
            }
        }


        return validIndex;
    }
    
}
