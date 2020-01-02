using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class ArrayIntersection2
    {
        /// <summary>
        /// 如果两个数组大小差很多可以用这个
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int > result =new List<int>();
            int[] shortArr;
            int[] longArr;
            if (nums1.Length > nums2.Length)
            {
                shortArr = nums2;
                longArr = nums1;
            }
            else
            {
                shortArr = nums1;
                longArr = nums2;
            }

            Dictionary<int,int> temDict =new Dictionary<int,int>();
            for (int i = 0; i < shortArr.Length; i++)
            {
                int num = shortArr[i];
                if (temDict.ContainsKey(num) == false)
                {
                    temDict[num] = 1;
                }
                else
                {
                    temDict[num]++;
                }
            }


            for (int i = 0; i < longArr.Length; i++)
            {
                int num = longArr[i];
                if (temDict.ContainsKey(num) && temDict[num] > 0)
                {
                    result.Add(num);
                    temDict[num]--;
                    if (result.Count > shortArr.Length)
                    {
                        break;
                    }
                }
            }


            return result.ToArray();
        }

        /// <summary>
        /// 不做判断长短数组竟然比上面的要快，测试范例不行啊
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] Intersect1(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> temDict = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                int num = nums1[i];
                if (temDict.ContainsKey(num) == false)
                {
                    temDict[num] = 1;
                }
                else
                {
                    temDict[num]++;
                }
            }


            for (int i = 0; i < nums2.Length; i++)
            {
                int num = nums2[i];
                if (temDict.ContainsKey(num) && temDict[num] > 0)
                {
                    result.Add(num);
                    temDict[num]--;
                }
            }


            return result.ToArray();
        }
       
    }
}
