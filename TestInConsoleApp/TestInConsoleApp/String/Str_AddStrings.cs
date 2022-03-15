using System;
using System.Text;

namespace TestInConsoleApp
{
    public class Str_AddStrings
    {
        //给定两个字符串形式的非负整数 num1 和num2 ，计算它们的和。

        //注意：

        //num1 和num2 的长度都小于 5100.
        //num1 和num2 都只包含数字 0-9.
        //num1 和num2 都不包含任何前导零。
        //你不能使用任何內建 BigInteger 库， 也不能直接将输入的字符串转换为整数形式。
        public string AddStrings(string num1, string num2)
        {
            StringBuilder sb=new StringBuilder();
            int bigLength = Math.Max(num1.Length, num2.Length);
            int temp = 0;
            //0-9 Ascii 码 48-57
            //按照小学立竖式的思路
            for (int i = 0; i < bigLength; i++)
            {
                int num = 0;
                if (i < num1.Length)
                {
                    num += num1[num1.Length-1-i] -48;
                }

                if (i < num2.Length)
                {
                    num += num2[num2.Length-1-i] - 48;
                }

                num += temp;
                if (num < 10)
                {
                    temp = 0;
                }
                else
                {
                    num = num % 10;
                    temp = 1;
                }

                sb.Insert(0, (char)(num+48));
            }

            if (temp > 0)
            {
                sb.Insert(0, '1');
            }
            return sb.ToString();
        }
    }
}