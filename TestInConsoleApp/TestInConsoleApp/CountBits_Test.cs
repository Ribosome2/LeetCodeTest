using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class CountBits_Test
    {
        public int[] CountBits(int num)
        {
            int[] ans = new int[num + 1];
            for (int i = 1; i <= num; ++i)
                ans[i] = ans[i & (i - 1)] + 1;
            return ans;
        }
    }
}
