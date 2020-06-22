using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class UniquePaths_Test
    {
        public int UniquePaths(int m, int n)
        {
            Dictionary<string ,int > cacheResult = new Dictionary<string, int>();
            return UniquePathsWithCache(m, n, cacheResult);
        }


        public int UniquePathsWithCache(int m, int n, Dictionary<string, int> cacheResult)
        {
            //f(m,n)=f(m-1,n)+f(m,n-1)
            //其中当m=1,或n==1 的时候，结果都是1
            if (m <= 1 || n <= 1)
            {
                return 1;
            }

            if (n == 2 && m == 2)
            {
                return 2;
            }

            string key = string.Format("{0}_{1}", m, n);
            int result;
            if(cacheResult.TryGetValue(key, out result))
            {
                return result;
            }
            result= UniquePathsWithCache(m - 1, n, cacheResult) + UniquePathsWithCache(m, n - 1, cacheResult);
            cacheResult[key] = result;
            return result;
        }


        public int UniquePaths1(int m, int n)
        {
            int[,] results = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        results[i, j] = 1;
                    }
                    else
                    {
                        //从小到大计算可以避免重复计算，大的值可以用前面算出来的结果
                        results[i, j] = results[i - 1, j] + results[i, j - 1];
                    }
                }
            }

            return results[m - 1, n - 1];
        }



    }
}