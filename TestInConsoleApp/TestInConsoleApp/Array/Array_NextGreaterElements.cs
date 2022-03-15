namespace TestInConsoleApp
{
    public class Array_NextGreaterElements
    {
        public int[] NextGreaterElements(int[] nums)
        {
            int[] re=new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                re[i] = FindGreaterIndex(nums, i);
            }
            return re;
        }

        int FindGreaterIndex(int[] nums,int curIndex)
        {
            int index = curIndex;
            while (true)
            {
                index++;
                if (index == nums.Length)
                {
                    index = 0;
                }

                if (index == curIndex)
                {
                    return -1;
                }
                else
                {
                    if (nums[index] > nums[curIndex])
                    {
                        return nums[index];
                    }
                }
            }
        }
    }
}