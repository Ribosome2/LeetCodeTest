namespace 剑指Offer
{
    public class Fib_Test
    {
//        答案需要取模 1e9+7（1000000007），如计算初始结果为：1000000008，请返回 1。
        public int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            if (n < 0)
            {
                return 0;
            }

            int prev = 1;
            int prevPrev = 0;
            int sum = prev + prevPrev;
            for (int i = 2; i <= n; i++)
            {
                sum = (prev + prevPrev) % 1000000007;
                prevPrev = prev;
                prev = sum;
            }

            return sum;
        }


        /// <summary>
        /// 经 测试，用数组这种比上面用3个数字对的计算要快些，是因为不用替换 前两个值了吧
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fib2(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            if (n < 0)
            {
                return 0;
            }

            int[] cacheArr = new int[n + 1];
            cacheArr[0] = 0;
            cacheArr[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                cacheArr[i] = (cacheArr[i - 1] + cacheArr[i - 2]) % 1000000007;
            }
            
            return cacheArr[n];
        }
    }
}