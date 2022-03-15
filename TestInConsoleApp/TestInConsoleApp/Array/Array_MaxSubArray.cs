namespace TestInConsoleApp
{
    //给定一个整数数组，找到一个具有最大和的连续子数组（子数组最少包含一个元素）
    //返回其最大值
    public class Array_MaxSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            int sum = 0;
            //暴力计算,把所有可能的组合算一遍复杂度O(n^3)
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    sum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        sum += nums[k];
                    }

                    if (sum > max)
                    {
                        max = sum;
                    }
                }
            }
            return max;
        }

        public int MaxSubArray1(int[] nums)
        {
            int max = int.MinValue;
            int sum = 0;
            //上面的改良版,把所有可能的组合算一遍复杂度O(n^2)
            for (int i = 0; i < nums.Length; i++)
            {
                sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    //这里就相当于每次根据前一次的序列来计算新的序列
                    sum += nums[j];

                    if (sum > max)
                    {
                        max = sum;
                    }
                }
            }
            return max;
        }

        
        public int MaxSubArray2(int[] nums)
        {
            //扫描法O(n)
            int currrent = nums[0];
            int sum = nums[0];
            //如果全是负数，那么返回最大的负数，如果最后的和为正，那么用扫描法
            for (int i = 1; i < nums.Length; i++)
            {
                if (currrent < 0)
                {
                    currrent = nums[i]; //当前数小于0，肯定会舍去（否则将会影响接下来的和），换位下一个数
                }
                else
                {
                    currrent += nums[i];
                    //如果当前数不小于0，那么他会对接下来的和有积极影响
                }

                if (currrent > sum) 
                {
                    //这里既实现了负数返回最大也实现了扫描法
                    //这里其实已经隐式的列举了所有可能，保留了可能的最大值
                    sum = currrent;
                }
            }
            return sum;
        }

        //动态规划法O(n)
        public int MaxSubArray3(int[] nums)
        {
            int sum = nums[0];
            int n = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (n > 0)
                {
                    n += nums[i];
                }
                else
                {
                    n = nums[i];
                }

                if (n > sum)
                {
                    sum = n;
                }
            }

            return sum;
        }
    }
}