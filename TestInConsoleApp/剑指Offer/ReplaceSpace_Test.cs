using System;
using System.Text;

namespace 剑指Offer
{
    public class ReplaceSpace_Test
    {
//         请实现一个函数，把字符串 s 中的每个空格替换成"%20"。
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

        public string ReplaceSpace2(string s)
        {
            //由于空格变%20是一个字符变三个，最大的需要字符长度乘3个字符
            var chArr = new Char[s.Length * 3];
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (ch == ' ')
                {
                    chArr[index++] = '%';
                    chArr[index++] = '2';
                    chArr[index++] = '0';
                }
                else
                {
                    chArr[index++] = ch;
                }
            }
            return new string(chArr,0,index);
        }
    }
}