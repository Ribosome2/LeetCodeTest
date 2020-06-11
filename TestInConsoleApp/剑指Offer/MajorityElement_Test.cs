using System.Collections.Generic;

namespace 剑指Offer
{
    public class MajorityElement_Test
    {
        public int MajorityElement(int[] nums)
        {
            int halfNum = nums.Length / 2;
            Dictionary<int ,int> record = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int count ;
                if (record.TryGetValue(nums[i], out count))
                {
                    count = count + 1;
                }
                else
                {
                    count = 1;
                }

                if (count > halfNum)
                {
                    return nums[i];
                }
                record[nums[i]] = count;
                
            }

            return -1;
        }
        /// <summary>
        /// 摩尔投票法
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement1(int[] nums)
        {
            int halfNum = nums.Length / 2;
            int result = nums[0];
            int ticketCount = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                int n = nums[i];
                if (n == result)
                {
                    ticketCount++;
                }
                else
                {
                    ticketCount--;
                    if (ticketCount == 0)
                    {
                        result = n;
                        ticketCount = 1;
                    }
                }

                if (ticketCount > halfNum)
                {
                    return result;
                }

            }

            return result;
        }
    }
}