using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_Intersection
    {
        //给定两个数组，编写一个函数来计算它们的交集。
        //说明:
        //输出结果中的每个元素一定是唯一的。
        //我们可以不考虑输出结果的顺序。
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            Dictionary<int,bool> dict=new Dictionary<int,bool>();
            for (int i = 0; i < nums1.Length; i++)
            {
                dict[nums1[i]] = false;
            }

            int count = 0;
            for (int i = 0; i < nums2.Length; i++)
            {
                int num = nums2[i];
                if (dict.ContainsKey(num))
                {
                    if (dict[num] == false)
                    {
                        dict[num] = true;
                        count++;
                    }
                }
            }
            int[] result=new int[count];
            var iter = dict.GetEnumerator();
            while (iter.MoveNext())
            {
                if (iter.Current.Value == true)
                {
                    result[count - 1] = iter.Current.Key;
                    count--;
                }
            }
            iter.Dispose(); //加了Dispose代码能跑的更快？
            return result;
        }
    }
}