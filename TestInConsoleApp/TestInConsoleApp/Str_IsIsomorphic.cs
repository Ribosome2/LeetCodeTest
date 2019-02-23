using System.Collections.Generic;
using System.Text;

namespace TestInConsoleApp
{
    public class Str_IsIsomorphic
    {
        //        给定两个字符串 s 和 t，判断它们是否是同构的。
        //        如果 s 中的字符可以被替换得到 t ，那么这两个字符串是同构的。
        //        所有出现的字符都必须用另一个字符替换，同时保留字符的顺序。两个字符不能映射到同一个字符上，但字符可以映射自己本身。
//        示例 1:
//        输入: s = "egg", t = "add"
//        输出: true
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            StringBuilder sb=new StringBuilder();
            Dictionary<char,char> chaDict=new Dictionary<char, char>();
            Dictionary<char, char> reverseChatDict = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                var cha1 = s[i];
               
               
                if (chaDict.ContainsKey(cha1) == false)
                {
                   
                    var cha2 = t[i];
                    //防止同一个字符对应不同的替换
                    if (reverseChatDict.ContainsKey(cha2))
                    {
                        return false;
                    }

                    chaDict[cha1] = cha2;
                    reverseChatDict[cha2] = cha1;
                }

                sb.Append(chaDict[cha1]);

            }
            return string.Equals(sb.ToString(),t);
        }
    }
}