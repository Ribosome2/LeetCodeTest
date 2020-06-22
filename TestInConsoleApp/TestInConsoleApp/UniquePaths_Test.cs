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


    }
}