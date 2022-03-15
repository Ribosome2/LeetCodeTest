namespace TestInConsoleApp
{
    //给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。
//    说明：本题中，我们将空字符串定义为有效的回文串。
    public class Str_IsPalindrome
    {
        public bool IsPalindrome(string s)
        {
            s=s.ToLower();
            int left = 0;
            int right = s.Length - 1;
            while (right>left)
            {
                char leftC=' ';
                char rightC=' ';
                while (left<=right)
                {
                    if (IsValidChar(s[left]))
                    {
                        leftC = s[left];
                        break;
                    }

                    left++;
                }

                while (left <= right)
                {
                    if (IsValidChar(s[right]))
                    {
                        rightC = s[right];
                        break;
                    }

                    right--;
                }

                if (leftC != rightC)
                {
                    return false;
                }

                left++;
                right--;
            }
            return true;
        }

        bool IsValidChar(char c)
        {
            if(c>='a' &&  c<='z')
            {
                return true;
            }
            if (c >= 'A' && c <= 'Z')
            {
                return true;
            }

            if (c >= '0' && c <= '9')
            {
                return true;
            }
            return false;
        }
    }
}