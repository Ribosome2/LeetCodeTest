namespace TestInConsoleApp
{
    public class Array_MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            int validIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (i > validIndex)
                    {
                        nums[validIndex] = nums[i];
                        nums[i] = 0;
                    }
                    validIndex++;

                }
            }

        }

        public void MoveZeroes2(int[] nums)
        {
            int validIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (i > validIndex)
                    {
                        nums[validIndex] = nums[i];
                    }
                    validIndex++;

                }
            }

            for (int j = validIndex; j < nums.Length; j++)
            {
                nums[j] = 0;
            }

        }
    }
}