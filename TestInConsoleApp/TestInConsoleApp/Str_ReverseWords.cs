using System;
using System.Text;

namespace TestInConsoleApp
{
    public class Str_ReverseWords
    {
        //给定一个字符串，你需要反转字符串中每个单词的字符顺序，同时仍保留空格和单词的初始顺序。

//        示例 1:
//
//        输入: "Let's take LeetCode contest"
//        输出: "s'teL ekat edoCteeL tsetnoc" 
//        注意：在字符串中，每个单词由单个空格分隔，并且字符串中不会有任何额外的空格。
        public string ReverseWords(string s)
        {
            StringBuilder sb=new StringBuilder();
            int charCount=0;
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (ch == ' ')
                {
                    int startIndex = i-1;
                    while (charCount>0)
                    {
                        sb.Append(s[startIndex]);
                        startIndex--;
                        charCount--;
                    }
                    charCount = 0;
                    sb.Append(ch);
                }
                else
                {
                    
                    charCount++;
                }
            }

            if (charCount > 0)
            {
                int index = s.Length-1;
                while (charCount > 0)
                {
                    sb.Append(s[index]);
                    charCount--;
                    index--;
                }
            }
           
            return sb.ToString();
        }

        public string ReverseWords1(string s)
        {
            char[] sb = new char[s.Length];
            int charCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (ch == ' ')
                {
                    int startIndex = i - 1;
                    while (charCount > 0)
                    {
                        sb[startIndex] = s[i - charCount];
                        startIndex--;
                        charCount--;
                    }
                    charCount = 0;
                    sb[i] = s[i];
                }
                else
                {

                    charCount++;
                }
            }

            if (charCount > 0)
            {
                int index = s.Length - 1;
                while (charCount > 0)
                {
                    sb[index] = s[s.Length - charCount];
                    charCount--;
                    index--;
                }
            }
            //用char数组构建string 比sringBuilder消耗的内存还要多，而且性能相差无几
            return new string(sb);
        }
    }
}