using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class FreqAlphabets_Test
    {

//        给你一个字符串 s，它由数字（'0' - '9'）和 '#' 组成。我们希望按下述规则将 s映射为一些小写英文字符：
//
//        字符（'a' - 'i'）分别用（'1' - '9'）表示。
//        字符（'j' - 'z'）分别用（'10#' - '26#'）表示。 
//        返回映射之后形成的新字符串。
//
//        题目数据保证映射始终唯一
//
//            来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/decrypt-string-from-alphabet-to-integer-mapping
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public string FreqAlphabets(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length-1; i >=0; i--)
            {
                Console.WriteLine("Index "+i);
                var ch = s[i];
                if (ch == '#')
                {
                    var number = int.Parse(s.Substring(i - 2, 2));
                    sb.Insert(0, (char)('j' + number-10));
                    i-=2;
                }
                else
                {
                    sb.Insert(0, (char)('a' + ch - '1'));
                }
            }
            
            return sb.ToString();
        }
    }
}
