namespace TestInConsoleApp
{
    public class Array_FindLengthOfLCIS
    {
        //给定一个未经排序的整数数组，找到最长且连续的的递增序列。
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums==null || nums.Length == 0)
            {
                return 0;
            }
            int count = 1;
            int maxCount = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }

                    count = 1;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
            }
            return maxCount;
        }
    }
}