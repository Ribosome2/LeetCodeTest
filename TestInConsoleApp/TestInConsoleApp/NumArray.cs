using System.Collections.Generic;

namespace TestInConsoleApp
{
    //给定一个整数数组 nums，求出数组从索引 i 到 j(i ≤ j) 范围内元素的总和，包含 i, j 两点。
    //说明:
    //你可以假设数组不可变。
    //会多次调用 sumRange 方法。
    //public class NumArray
    //{
    //    public NumArray(int[] nums)
    //    {
    //        mArr = nums;
    //    }

    //    private int[] mArr;
    //    //用缓存结果的方式测试竟然比没缓存结果的还慢，测试用例调用SumRange 次数不够多？
    //    Dictionary<string,int> cacheDict=new Dictionary<string, int>();
        
    //    public int SumRange(int i, int j)
    //    {
    //        var key = string.Format("{0}_{1}", i.ToString(), j.ToString());
    //        if (!cacheDict.ContainsKey(key))
    //        {
    //            int sum = 0;
    //            for (int index = i; index <= j; index++)
    //            {
    //                sum += mArr[index];
    //            }

    //            cacheDict[key] = sum;
    //        }
           
    //        return cacheDict[key];
    //    }
    //}

    public class NumArray
    {
        public NumArray(int[] nums)
        {
            sumArray = new int[nums.Length];
            if (nums.Length == 0)
            {
                return;
            }
            sumArray[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sumArray[i] = sumArray[i - 1] + nums[i];
            }
        }

        private int[] sumArray; //提前存好每一个索引前面的综合，取区间就可以等于 sum(j)-sum(i)
      

        public int SumRange(int i, int j)
        {
            if (i == 0) //0是特殊情况
            {
                return sumArray[j];
            }
            else
            {
                return sumArray[j] - sumArray[i-1];
            }
        }
    }
}