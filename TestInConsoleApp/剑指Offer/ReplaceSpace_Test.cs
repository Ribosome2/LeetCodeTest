using System.Text;

namespace 剑指Offer
{
    public class ReplaceSpace_Test
    {
//        请实现一个函数，把字符串 s 中的每个空格替换成"%20"。
        public string ReplaceSpace(string s)
        {
            if (s == null)
            {
                return null;
            }
            StringBuilder sb =new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (ch == ' ')
                {
                    sb.Append("%20");
                }
                else
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }
    }
}