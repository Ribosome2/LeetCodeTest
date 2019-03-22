﻿namespace TestInConsoleApp
{
    public class Int_ArrangeCoins
    {
        //你总共有 n 枚硬币，你需要将它们摆成一个阶梯形状，第 k 行就必须正好有 k 枚硬币。
        //给定一个数字 n，找出可形成完整阶梯行的总行数。
        //n 是一个非负整数，并且在32位有符号整型的范围内。
        public int ArrangeCoins(int n)
        {
            int level = 1;
            while (n>=level)
            {
                n -= level;
                level++;
            }
            return level;
        }
    }
}