namespace TestInConsoleApp
{
    public class Array_MinMoves
    {
//        给定一个长度为 n 的非空整数数组，找到让数组所有元素相等的最小移动次数。每次移动可以使 n - 1 个元素增加 1。
        public int MinMoves(int[] nums)
        {
//            一种思路。n - 1个元素均增加1，相当于另外一个元素降低1.因此直接计算所有元素与最小值的差即可。
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += nums[i] - min;
            }
            return count;

        }

        //这个一次循环的解法更快，但是怎么理解？
        public int MinMoves1(int[] nums)
        {
            int min = int.MaxValue;
            int sum = 0;
            for (int i=0;i<nums.Length;i++)
            {
                int num = nums[i];
                if (num < min)
                {
                    min = num;
                }
                sum += num;
            }
            return sum - min * nums.Length;

        }
    }
}