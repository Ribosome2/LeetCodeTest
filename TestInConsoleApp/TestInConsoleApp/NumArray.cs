using System.Collections.Generic;

namespace TestInConsoleApp
{
    //给定一个整数数组 nums，求出数组从索引 i 到 j(i ≤ j) 范围内元素的总和，包含 i, j 两点。
    //说明:
    //你可以假设数组不可变。
    //会多次调用 sumRange 方法。
    public class NumArray
    {
        public NumArray(int[] nums)
        {
            mArr = nums;
        }

        private int[] mArr;
        //用缓存结果的方式测试竟然比没缓存结果的还慢，测试用例调用SumRange 次数不够多？
        Dictionary<string,int> cacheDict=new Dictionary<string, int>();
        
        public int SumRange(int i, int j)
        {
            var key = string.Format("{0}_{1}", i.ToString(), j.ToString());
            if (!cacheDict.ContainsKey(key))
            {
                int sum = 0;
                for (int index = i; index <= j; index++)
                {
                    sum += mArr[index];
                }

                cacheDict[key] = sum;
            }
           
            return cacheDict[key];
        }
    }
}