namespace TestInConsoleApp
{
    public class Array_MaxProfit
    {

        //给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。
        //如果你最多只允许完成一笔交易（即买入和卖出一支股票），设计一个算法来计算你所能获取的最大利润。
        //注意你不能在买入股票前卖出股票。
        public int MaxProfit(int[] prices)
        {
            int maxprofit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > maxprofit)
                        maxprofit = profit;
                }
            }
            return maxprofit;
        }

        public int MaxProfit1(int[] prices)
        {
            int min = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }else if (prices[i] - min > maxProfit)
                {
                    maxProfit = prices[i] - min;
                }
            }

            return maxProfit;
        }

        //给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。
        //设计一个算法来计算你所能获取的最大利润。你可以尽可能地完成更多的交易（多次买卖一支股票）。
        //注意：你不能同时参与多笔交易（你必须在再次购买前出售掉之前的股票）
        public int MaxProfit2(int[] prices)
        {
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }

            //一个变量存储当前最小值，一个存储当前最大值
            //只要检测到比当前最大值小的，就先判断卖出是否能有利润，然后设置为当前最小值，最大值归零
            //遇到大于等于当前最大值得就覆盖为当前最大值
            int profit = 0;
            int cur = prices[0];
            int max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < max)
                {
                    if (max > cur)
                    {
                        profit += max - cur;
                    }
                    cur = prices[i];
                    max = 0;
                }
                else
                {
                    if (prices[i] < cur)
                    {
                        cur = prices[i];
                    }
                    max = prices[i];
                }
            }
            if (max > cur)
            {
                profit += max - cur;
            }
            return profit;
        }
    }
}