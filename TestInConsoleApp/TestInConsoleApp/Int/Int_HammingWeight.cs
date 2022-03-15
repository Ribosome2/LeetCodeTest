using System;

namespace TestInConsoleApp
{
    public class Int_HammingWeight
    {
        //编写一个函数，输入是一个无符号整数，返回其二进制表达式中数字位数为 ‘1’ 的个数（也被称为汉明重量）。
        public int HammingWeight(uint n)
        {
            var str= Convert.ToString(n, 2);

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    count++;
                }
            }
            return count;
        }
    }
}