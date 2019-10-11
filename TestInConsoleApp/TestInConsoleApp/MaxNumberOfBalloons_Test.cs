using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class MaxNumberOfBalloons_Test
    {
//        给你一个字符串 text，你需要使用 text 中的字母来拼凑尽可能多的单词 "balloon"（气球）。
//
//        字符串 text 中的每个字母最多只能被使用一次。请你返回最多可以拼凑出多少个单词 "balloon"。
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/maximum-number-of-balloons
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int MaxNumberOfBalloons(string text)
        {
            int count = 0;
            Dictionary<char ,int> chDict =new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                var ch = text[i];
                if (chDict.ContainsKey(ch))
                {
                    chDict[ch] = chDict[ch] + 1;
                }
                else
                {
                    chDict[ch] = 1;
                }

            }

            count = GetPairCount(chDict, 'b', 1);
            count = Math.Min(count,GetPairCount(chDict, 'a', 1));
            count = Math.Min(count, GetPairCount(chDict, 'l', 2));
            count = Math.Min(count, GetPairCount(chDict, 'o', 2));
            count = Math.Min(count, GetPairCount(chDict, 'n', 1));


            return count;
        }

        public int GetPairCount(Dictionary<char, int> chDict,char ch, int onePairNumber)
        {
            if (chDict.ContainsKey(ch))
            {
                
                return (int)Math.Floor((double)chDict[ch] / onePairNumber);
            }
            else
            {
                return 0;
            }
        }
    }
}
