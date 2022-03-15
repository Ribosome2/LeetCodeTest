using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
//    给定一个经过编码的字符串，返回它解码后的字符串。
//
//    编码规则为: k[encoded_string]，表示其中方括号内部的 encoded_string 正好重复 k 次。注意 k 保证为正整数。
//
//你可以认为输入字符串总是有效的；输入字符串中没有额外的空格，且输入的方括号总是符合格式要求的。
//
//此外，你可以认为原始数据不包含数字，所有的数字只表示重复的次数 k ，例如不会出现像 3a 或2[4] 的输入。
//
//来源：力扣（LeetCode）
//链接：https://leetcode-cn.com/problems/decode-string
//著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class Str_DecodeString
    {
        public string DecodeString(string str)
        {
            StringBuilder sb = new StringBuilder();
            int number = 0;
            int index = 0;
            while (index < str.Length)
            {
                var ch = str[index];
                if (ch >= '0' && ch <= '9')
                {
                    number = number * 10 + (ch - '0');
                    index++;
                }
                else if (ch == '[')
                {
                    int closeIndex = FindCloseIndex(ref str, index + 1);
                    var tmp = DecodeString(str.Substring(index + 1, closeIndex  - index-1));
                    while (number > 0)
                    {
                        sb.Append(tmp);
                        number--;
                    }

                    index = closeIndex + 1;
                }
                else
                {
                    sb.Append(ch);
                    index++;
                }
            }

            return sb.ToString();
        }
      
        /// <summary>
        /// 这里主要注意有几个左括号就要几个右括号抵消
        /// </summary>
        /// <param name="str"></param>
        /// <param name="curIndex"></param>
        /// <returns></returns>
        int FindCloseIndex(ref string str, int curIndex)
        {
            int openBracketCount = 1;
            while (curIndex < str.Length)
            {
                var ch = str[curIndex];
                if (ch == '[')
                {
                    openBracketCount++;
                }else if (ch == ']')  
                {
                    openBracketCount--;
                    if (openBracketCount == 0)
                    {
                        return curIndex;
                    }
                }

                curIndex++;
            }
            return 0;
        }
        
       
    }
}
