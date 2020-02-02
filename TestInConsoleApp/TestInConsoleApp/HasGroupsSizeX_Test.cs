using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class HasGroupsSizeX_Test
    {
        //        给定一副牌，每张牌上都写着一个整数。
        //
        //        此时，你需要选定一个数字 X，使我们可以将整副牌按下述规则分成 1 组或更多组：
        //
        //        每组都有 X张牌。
        //        组内所有的牌上都写着相同的整数。
        //        仅当你可选的 X >= 2 时返回 true。
        //
        //        来源：力扣（LeetCode）
        //        链接：https://leetcode-cn.com/problems/x-of-a-kind-in-a-deck-of-cards
        //        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

        //        提示：
        //
        //        1 <= deck.length <= 10000
        //        0 <= deck[i] < 10000
        public bool HasGroupsSizeX(int[] deck)
        {
            int N = deck.Length;
            int[] count = new int[10000];
            foreach (var c in deck)
            {
                count[c]++;
            }


            List<int> values = new List<int>();
            for (int i = 0; i < 10000; ++i)
            {
                if (count[i] > 0)
                {
                    values.Add(count[i]);
                }
            }


            for (int X = 2; X <= N; ++X)
            {
                //能分成X份
                if (N % X == 0)
                {
                    bool flag = true;
                    foreach (var v in values)
                    {
                        if (v % X != 0)
                        {
                            //牌里面有不能分成X份的数字 这个X不能要
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        return true;
                    }
                }
            }


            return false;

        }



//        方法 2：最大公约数
//            想法和算法
//
//        同理假设 C_i 是数字 i 的卡片个数，同样对于所有的 i 满足 C_i % X == 0，其中每堆有 X 张卡片。
//
//        因此，X 一定可以整除 C_i 的最大公约数。如果最大公约数 g 超过 1，那么就有 X = g 满足条件，否则不满足条件。
//
//        作者：LeetCode
//            链接：https://leetcode-cn.com/problems/x-of-a-kind-in-a-deck-of-cards/solution/qia-pai-fen-zu-by-leetcode/
//        来源：力扣（LeetCode）
//        著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
        /// <summary>
        /// 最大公约数解法
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public bool HasGroupsSizeX1(int[] deck)
        {
            int N = deck.Length;
            int[] count = new int[10000];
            foreach (var c in deck)
            {
                count[c]++;
            }

            int g = -1;
            for (int i = 0; i < 10000; i++)
            {
                if (count[i] > 0)
                {
                    if (g == -1)
                    {
                        g = count[i];
                    }
                    else
                    {
                        g = gcd(g, count[i]);
                    }
                }
            }

            return g >= 2;
        }
        private int gcd(int x, int y)
        {
            return x == 0 ? y : gcd(y % x, x);
        }
    }
}
