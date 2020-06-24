using System;

namespace TestInConsoleApp
{
    public class MinCostClimbingStairs_Test
    {

//        数组的每个索引作为一个阶梯，第 i个阶梯对应着一个非负数的体力花费值 cost[i] (索引从0开始)。
//
//        每当你爬上一个阶梯你都要花费对应的体力花费值，然后你可以选择继续爬一个阶梯或者爬两个阶梯。
//
//        您需要找到达到楼层顶部的最低花费。在开始时，你可以选择从索引为 0 或 1 的元素作为初始阶梯。
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost == null || cost.Length == 0)
            {
                return 0;
            }
            //f(x)=cost[x]+ math.min(f(x-1),f(x-2))
            //f(0）=cost[0] f(1)=cost[1]
            
            int[] cacheResult = new int[cost.Length];
            for (int i = 0; i < cost.Length; i++)
            {
                
                if (i < 2)
                {
                    cacheResult[i] = cost[i];
                }
                else
                {
                    cacheResult[i] = cost[i] + Math.Min(cacheResult[i - 1], cacheResult[i-2] );
                }
            }
            return Math.Min(cacheResult[cost.Length-1],cacheResult[cost.Length-2]);
        }
    }
}