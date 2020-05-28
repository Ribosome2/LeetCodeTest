using System;
using System.Collections.Generic;

namespace 剑指Offer
{
    public class LengthOfLongestSubstring_Test
    {
//        请从字符串中找出一个最长的不包含重复字符的子字符串，计算该最长子字符串的长度。
        public int LengthOfLongestSubstring(string s)
        {
            int maxLen = 0;
            if (string.IsNullOrEmpty(s) == false && s.Length > 0)
            {
                maxLen = 1;
                int leftIndex = 0;
                int rightIndex = 1;
                Dictionary<char,int> record = new Dictionary<char, int>();
                record[s[leftIndex]] = leftIndex;
                while (rightIndex<s.Length)
                {
                    var ch = s[rightIndex];
                    if (record.TryGetValue(ch, out var repeatIndex))
                    {
                        if (repeatIndex >= 0)
                        {
                            while (leftIndex<=repeatIndex)
                            {
                                var leftCh = s[leftIndex];
                                record[leftCh] = -1;
                                leftIndex++;
                            }
                        }
                        else
                        {
                            maxLen = Math.Max(rightIndex - leftIndex+1, maxLen);
                        }
                    }
                    else
                    {
                        maxLen = Math.Max(rightIndex - leftIndex+1, maxLen);
                    }

                    record[ch] = rightIndex;
                    rightIndex++;
                }
            }
            return maxLen;
        }
    }
}