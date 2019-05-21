using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_Subsets
    {
//        给定一组不含重复元素的整数数组 nums，返回该数组所有可能的子集（幂集）。
//        说明：解集不能包含重复的子集。
        public IList<IList<int>> Subsets(int[] nums)
        {
            List<IList<int>> re=new List<IList<int>>();
          
            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                int preCount = re.Count;
                //没遇到一个新的数字，就把前面的子集复制一遍，再加上当前这个数，就又是一个新的子集
                for (int index = 0; index < preCount; index++)
                {
                    var listNew =new  List<int>();
                    listNew.AddRange(re[index]);
                    listNew.Add(num);
                    re.Add(listNew);
                }
                //没个新数字都必然是一个子集
                re.Add(new List<int>(){num});
            }
            re.Add(new List<int>());//空集是任何集合的子集
            return re;
        }
    }
}