using System;

namespace TestInConsoleApp
{
    public class String_ValidPalindrome
    {
        //给定一个非空字符串 s，最多删除一个字符。判断是否能成为回文字符串。

        public bool ValidPalindrome(string s)
        {
            int left = 0;
            int right = s.Length-1;
            int errorChange = 1;
            while  (left < right)
            {
                if (s[left] != s[right])
                {
                   
                    if (errorChange == 0)
                    {
                        return false;
                    }
                    else
                    {
                        if (left + 1 == right)
                        {
                            return true;
                        }
                        //怎么决定删除左边还是删除右边的？ 暂时只能左右两边都检查一下
                        errorChange--;
                        if (s[left + 1] == s[right])
                        {
                            left++;
                            if (CheckValid(ref s, left, right))
                            {
                                return true;
                            }
                            left--;
                        }


                        if (s[left] == s[right - 1])
                        {
                            right--;
                            return CheckValid(ref s, left, right);

                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                left++;
                right--;
                
            }

            return true;
        }

        private static bool CheckValid(ref string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}