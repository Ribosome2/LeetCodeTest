using System;

namespace TestInConsoleApp
{
    public class Str_LengthOfLongestSubstring
    {
        //给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度
        public int LengthOfLongestSubstring(string s)
        {
            int left = 0;
            int max = 0;
            var size = s.Length;
            for (int j = 0; j < size; j++)
            {
                for (int k = left; k < j; k++)
                {
                    if (s[k] == s[j])
                    {
                        left = k + 1;
                        break;
                    }
                }

                if (j - left + 1 > max)
                {
                    max = j - left + 1;
                }
            }
            return max;
        }

        //这里我们可以建立一个 256 位大小的整型数组，这样做的原因是 ASCII 表一共能表示 256 个字符，
        //所以可以记录所有字符，然后我们需要定义两个变量 res 和 left，其中 res 用来记录最长无重复子串的长度，
        //left 指向该无重复子串左边的起始位置。开始遍历字符串，更新 left，
        //计算最大 res，更新当前字符的最后出现位置。最后得出的 res 即为所求。
//        作者：Little丶Jerry
//            链接：https://www.jianshu.com/p/8739bed84efa

        public int LengthOfLongestSubstring1(string s)
        {
            int[] m = new int[256];
            int res = 0, left = 0;
            for (int i = 0; i < s.Length; i++)
            {
                left = Math.Max(left, m[s[i]]);
                res = Math.Max(res, i - left + 1);

                m[s[i]] = i + 1;
            }
            return res;
        }
    }
}