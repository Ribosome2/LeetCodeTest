using System;

namespace TestInConsoleApp
{
    public class Massage_Test
    {
        public int Massage(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            //f(x)=max( a[x]+f(x-2), a[x-1]+f(x-3))
            int[] arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i ==0)
                {
                    arr[i]=nums[i];
                }else if (i == 1)
                {
                    arr[i] = Math.Max(nums[i], nums[i-1]);
                }else if (i == 2)
                {
                    arr[i] = Math.Max(nums[i] + nums[i - 2], nums[i - 1]);
                }
                else
                {
                    var pick1 = nums[i] + arr[i - 2];
                    var pick2 = nums[i - 1] + arr[i - 3];
                    arr[i] = Math.Max(pick1, pick2);
                }
            }

            return arr[nums.Length - 1];

        }
    }
}