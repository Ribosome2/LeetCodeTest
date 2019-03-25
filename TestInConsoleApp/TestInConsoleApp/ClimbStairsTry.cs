using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
   public  class ClimbStairsTry
    {
        //假设你正在爬楼梯。需要 n 阶你才能到达楼顶。
        //每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？
        //注意：给定 n 是一个正整数。
        public int ClimbStairs(int n)
        {
            //通过观察 n 从1 开始的结果为 1,2,3,5,8.. 也就是第n项等于前两项的和
            if (n == 1) return 1;
            if (n == 2) return 2;
            int sum = 0;
            //从上往下算，结果是对的 但是会存在太多重复计算
            sum = ClimbStairs(n - 1) + ClimbStairs(n - 2);
            return sum;

        }

        public int ClimbStairs1(int n)
        {
            //通过观察 n 从1 开始的结果为 1,2,3,5,8.. 也就是第n项等于前两项的和
            //相对前面的函数，这里我们从下往上算，后面的结果直接用前面的结果，省去了很多重复计算
            if (n == 1) return 1;
            if (n == 2) return 2;
            int sum = 0;
            int prev = 2;
            int prePrev = 1;
            int curNum = 3;
            while (curNum<=n)
            {
                sum += prePrev;
                sum += prev;
                prePrev = prev;
                prev = sum;
                sum = 0;
                curNum++;
            }
            return prev;

        }
    }
}
