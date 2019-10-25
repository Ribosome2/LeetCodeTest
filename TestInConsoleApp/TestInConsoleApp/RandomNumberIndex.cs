using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
//    给定一个可能含有重复元素的整数数组，要求随机输出给定的数字的索引。 您可以假设给定的数字一定存在于数组中。
//
//    注意：
//    数组大小可能非常大。 使用太多额外空间的解决方案将不会通过测试。
//
//    来源：力扣（LeetCode）
//    链接：https://leetcode-cn.com/problems/random-pick-index
//    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class RandomNumberIndex
    {
        Dictionary<int,List<int>> recordDict=new Dictionary<int, List<int>>();
        public RandomNumberIndex(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                if (recordDict.ContainsKey(n) == false)
                {
                    recordDict[n] =new List<int>();
                }
                recordDict[n].Add(i);
            }
        }

        public int Pick(int target)
        {
            var record = recordDict[target];
            return record[new System.Random().Next(record.Count)];
        }
    }
    /// <summary>
    /// 内存n,pickO(n)的写法
    /// </summary>
    class RandomNumberIndex2
    {
        private int[] nums;
        public RandomNumberIndex2(int[] nums)
        {
            this.nums = nums;
        }

       
        public int Pick(int target)
        {
            int result = 0;
            var rnd = new System.Random();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    count++;
                    if (rnd.Next(count) == 0)
                    {
                        result = i;
                    }
                }
            }

            return result;
        }
    }
}
