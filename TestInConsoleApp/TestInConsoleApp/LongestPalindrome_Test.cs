using System;

namespace TestInConsoleApp
{
    public class LongestPalindrome_Test
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            if (s.Length < 2)
            {
                return s.Substring(0,1);
            }

            int left = 0;
            int right = 0;
            //暴力枚举法
            for (int i = 0; i < s.Length - 1; i++)
            {
                int len1 = TryExpandAroundCenter(ref s, i, i);
                int len2 = TryExpandAroundCenter(ref s, i, i + 1);
                int maxLen = Math.Max(len1, len2);
                if (maxLen > right - left)
                {
                    left = i - (maxLen - 1) / 2;
                    right = i + maxLen / 2;
                }
            }

            return s.Substring(left, right-left + 1);

        }

        int TryExpandAroundCenter(ref string s, int left, int right)
        {
            while (left>=0 && right<s.Length && s[left]==s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }

       
    }
}