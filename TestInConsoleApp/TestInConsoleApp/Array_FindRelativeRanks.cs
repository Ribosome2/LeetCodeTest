using System;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_FindRelativeRanks
    {
        //给出 N 名运动员的成绩，找出他们的相对名次并授予前三名对应的奖牌。
        //前三名运动员将会被分别授予 “金牌”，“银牌” 和“ 铜牌”（"Gold Medal", "Silver Medal", "Bronze Medal"）。
        //(注：分数越高的选手，排名越靠前。)
        //示例 1:

        public string[] FindRelativeRanks(int[] nums)
        {
            string[] result=new string[nums.Length];
            var tempArra = new int[nums.Length];
            Array.Copy(nums,tempArra,nums.Length);
            Array.Sort(nums); //从大到小排序
            Dictionary<int ,string> dictRank=new Dictionary<int, string>();
            int rank = 1;
            for (int i = result.Length-1; i >= 0; i--)
            {
                if (rank == 1)
                {
                    dictRank[nums[i]] = "Gold Medal";
                }
                else if (rank == 2)
                {
                    dictRank[nums[i]] = "Silver Medal";
                }
                else if (rank == 3)
                {
                    dictRank[nums[i]] = "Bronze Medal";
                }
                else
                {
                    dictRank[nums[i]] = rank.ToString();
                }
                rank++;
            }
           

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = dictRank[tempArra[i]];
            }
            return result;
        }

    }
}