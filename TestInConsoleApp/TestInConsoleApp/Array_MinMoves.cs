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
        //设最后数组的数都变成 M,数组长度为 L,操作次数为N ，数组的初始状态的和为sum
        //因为操作一次 整个数组的和增加（L-1) 所以，得到等式:sum+N*(L-1)=M*L
        //上面的等式的解可以有无限多个，但是我们要的是操作次数最少，也就是M最小 
        //所以，假设数组的最小值为min,最少操作次数的关系就是: min+N=M
        //根据上面两个等式，解方程组可得N=sum-min*L
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