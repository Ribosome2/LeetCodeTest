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
                        errorChange--;
                        if (s[left + 1] == s[right])
                        {
                            left++;
                            continue;

                        }else if (s[left] == s[right - 1])
                        {
                            right--;
                            continue;
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
    }
}