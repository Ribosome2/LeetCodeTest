using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class Array_RelativeSortArray
    {
//        给你两个数组，arr1 和arr2，
//
//        arr2 中的元素各不相同
//        arr2 中的每个元素都出现在arr1 中
//            对 arr1中的元素进行排序，使 arr1 中项的相对顺序和 arr2中的相对顺序相同。未在 arr2中出现过的元素需要按照升序放在 arr1的末尾
//
//            来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/relative-sort-array
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            Dictionary<int ,int> numberDict =new Dictionary<int, int>();
            for (int i = 0; i < arr2.Length; i++)
            {
                numberDict[arr2[i]] = i;
            }

            List<int> includeList= new List<int>();
            List<int> excludeList = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                int number = arr1[i];
                if (numberDict.ContainsKey(number))
                {
                    includeList.Add(number);
                }
                else
                {
                    excludeList.Add(number);
                }
            }

            includeList.Sort(delegate(int number1, int number2)
            {
                return numberDict[number1] - numberDict[number2];
            });
            excludeList.Sort();
            for (int i = 0; i < includeList.Count; i++)
            {
                arr1[i] = includeList[i];
            }

            for (int i = 0; i < excludeList.Count; i++)
            {
                arr1[i + includeList.Count] = excludeList[i];
            }
            return arr1;
        }
    }
}
