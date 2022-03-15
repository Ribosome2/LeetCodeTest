namespace TestInConsoleApp
{
    public class Array_FindMissinNumber
    {
//        给定一个包含 0, 1, 2, ..., n 中 n 个数的序列，找出 0 .. n 中没有出现在序列中的那个数。
        public int MissingNumber(int[] nums)
        {
            int totalSum = 0;
            int curSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                totalSum += (i + 1);
                curSum += nums[i];
            }

            return totalSum - curSum;
        }

        
        public int MissingNumber2(int[] nums)
        {
            //用位运算更快 直接使用异或运算^进行**抵消**
            int totalSum = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                totalSum ^= i;
                totalSum ^= nums[i];
            }

            return totalSum ;
        }
    }
}