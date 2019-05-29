using System.Collections.Generic;
using System.Text;

namespace TestInConsoleApp
{
    public class Str_RemoveDuplicates
    {
        //给出由小写字母组成的字符串 S，重复项删除操作会选择两个相邻且相同的字母，并删除它们。
//        在 S 上反复执行重复项删除操作，直到无法继续删除。
//        在完成所有重复项删除操作后返回最终的字符串。答案保证唯一
        public string RemoveDuplicates(string S)
        {
            StringBuilder sb=new StringBuilder();
            Stack<char> chStack=new Stack<char>();
            for (int i = 0; i < S.Length; i++)
            {
                var ch = S[i];
                if (chStack.Count > 0 && chStack.Peek() == ch)
                {
                    while (chStack.Count>0 && ch==chStack.Peek())
                    {
                        ch = chStack.Pop();
                    }
                }
                else
                {
                    chStack.Push(ch);
                }
            }

            while(chStack.Count>0)
            {
                sb.Insert(0, chStack.Pop());
            }
            return sb.ToString();

        }
    }
}