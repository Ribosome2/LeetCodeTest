using System;

namespace TestInConsoleApp
{
    public class TwoCitySchedCost_Test
    {
//        公司计划面试 2N 人。第 i 人飞往 A 市的费用为 costs[i][0]，飞往 B 市的费用为 costs[i][1]。
//        返回将每个人都飞到某座城市的最低费用，要求每个城市都有 N 人抵达。
        public int TwoCitySchedCost(int[][] costs)
        {
            int sum = 0;
            //冒泡排序，差值最大的排前面，this works ,but why ?
            for (int i = 0; i < costs.Length-1; i++)
            {
                for (int j = i + 1; j < costs.Length; j++)
                {
                    var difA = costs[i][0] - costs[i][1];
                    var difB= costs[j][0] - costs[j][1];
                    if (difA < difB)
                    {
                        var temp = costs[i];
                        costs[i] = costs[j];
                        costs[j] = temp;
                    }
                }
            }

            var halfNum = costs.Length >> 1;
            for (int i = 0; i < halfNum; i++)
            {
                sum += costs[i][1];
                sum += costs[i + halfNum][0];
            }

            return sum;
        }
    }
}