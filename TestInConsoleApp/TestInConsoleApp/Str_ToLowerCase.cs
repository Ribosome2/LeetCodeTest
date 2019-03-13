using System.Text;

namespace TestInConsoleApp
{
    public class Str_ToLowerCase
    {
        //实现函数 ToLowerCase()，该函数接收一个字符串参数 str，并将该字符串中的大写字母转换成小写字母，之后返回新的字符串。
        public string ToLowerCase(string str)
        {
            StringBuilder sb = null;
            for (int i = 0; i < str.Length; i++)
            {
                if (IsCapital(str[i]))
                {
                    if (sb == null)
                    {
                        sb=new StringBuilder();
                    }
                    for (int index = sb.Length; index < i; index++)
                    {
                        sb.Append(str[index]);
                    }
                    sb.Append((char)(str[i]+32));
                }
            }


            if (sb==null || sb.Length == 0)
            {
                return str;
            }
            else
            {
                for (int index = sb.Length; index < str.Length; index++)
                {
                    sb.Append(str[index]);
                }
            }
            return sb.ToString();

        }
        bool IsCapital(char c)
        {
            return c > 64 && c < 91;
        }
        char GetLower(char c)
        {
            if (IsCapital(c))
            {
                return (char)(c+32);
            }
            else
            {
                return c;
            }
        }

        
    }
}