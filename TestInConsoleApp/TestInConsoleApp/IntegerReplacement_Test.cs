using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class IntegerReplacement_Test
    {
//        给定一个正整数 n，你可以做如下操作：
//
//        1. 如果 n是偶数，则用 n / 2替换 n。
//        2. 如果 n是奇数，则可以用 n + 1或n - 1替换 n。
//        n 变为 1 所需的最小替换次数是多少？
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/integer-replacement
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int IntegerReplacement(int n)
        {
           
            int count = 0;
            if (n == int.MaxValue)
            {
                n = n >> 1;
                count = 1;
            }
            while (n!=1)
            {
                if((n & 1) == 0)
                {
                    //偶数，直接向右移即可
                    n = n >> 1;
                    count++;
                }
                else
                {
                    //奇数，识别上一位是否为1，即 以 10 结尾(xxxx01)还是以11结尾(xxxx11)
                    if ((n & 2) == 0)
                    {
                        //xxx01结尾最优则应当 用n-1取代n
                        n -= 1;
                        count++;
                    }
                    else
                    {
                        //xxx11结尾除了3这个特殊情况外，其余用n+1取代，
                        if (n == 3)
                        {
                            count += 2;
                            break;
                        }
                        else
                        {
                            n += 1;
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
