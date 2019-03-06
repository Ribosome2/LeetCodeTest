using System;

namespace TestInConsoleApp
{
    public class Int_JudgeSquareSum
    {
        //给定一个非负整数 c ，你要判断是否存在两个整数 a 和 b，使得 a2 + b2 = c。
        public bool JudgeSquareSum(int c)
        {
            int left = 0;
            int right = (int)Math.Sqrt(c);
            while (left<=right)
            {
                int num = left * left + right * right;
                if (num == c)
                {
                    return true;
                }else if (num < c)
                {
                    left++;
                }
            }


            return false;

        }
    }
}