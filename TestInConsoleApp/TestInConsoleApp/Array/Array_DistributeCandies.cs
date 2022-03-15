using System;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_DistributeCandies
    {
        //给定一个偶数长度的数组，其中不同的数字代表着不同种类的糖果，每一个数字代表一个糖果。
        //你需要把这些糖果平均分给一个弟弟和一个妹妹。返回妹妹可以获得的最大糖果的种类数。
        public int DistributeCandies(int[] candies)
        {
            Dictionary<int,bool> dict=new Dictionary<int, bool>();
            for (int i = 0; i < candies.Length; i++)
            {
                if (dict.ContainsKey(candies[i]) == false)
                {
                    dict[candies[i]] = true;
                    if (dict.Count >= candies.Length / 2)
                    {
                        break;
                    }

                }
            }

            return dict.Count;

        }
    }
}