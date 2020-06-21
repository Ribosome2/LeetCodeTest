namespace 剑指Offer
{
    public class MaxSlidingWindow_Test
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums == null)
            {
                return new int[0];
            }
            else
            {
                int count = nums.Length - k + 1;
                var result = new int[count];
                var max = FindMax(nums,0, k);
                result[0] = max;

                for (int i = 1; i < count; i++)
                {
                    int addNumber = nums[i + k-1];
                    if (addNumber > max)
                    {
                        max = addNumber;
                    }
                    else
                    {
                        var popNumber = nums[i - 1];
                        if (popNumber == max)
                        {
                            max = FindMax(nums, i, k);
                        }
                        else if (popNumber > max)
                        {
                            max = popNumber;
                        }
                    }
                   
                    result[i] = max;
                }


                return result;
            }
        }

        private static int FindMax(int[] nums, int startIndex ,int k)
        {
            int max = int.MinValue;
            while (k>0)
            {
                var number = nums[startIndex];
                if (number > max)
                {
                    max = number;
                }
                k--;
                startIndex++;
            }
            return max;
        }
    }
}