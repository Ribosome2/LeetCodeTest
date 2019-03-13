using System.Text;

namespace TestInConsoleApp
{
    public class Str_ToLowerCase
    {
        //实现函数 ToLowerCase()，该函数接收一个字符串参数 str，并将该字符串中的大写字母转换成小写字母，之后返回新的字符串。
        public string ToLowerCase(string str)
        {
            StringBuilder sb=new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(GetLower(str[i]));
            }

            return sb.ToString();

        }

        char GetLower(char c)
        {
            if (IsCapital(c))
            {
                return (char)(c-32);
            }
            else
            {
                return c;
            }
        }

        bool IsCapital(char c)
        {
            return c > 64 && c < 91;
        }
    }
}