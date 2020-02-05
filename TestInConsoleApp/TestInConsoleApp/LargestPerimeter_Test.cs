using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class LargestPerimeter_Test
    {
//        给定由一些正数（代表长度）组成的数组 A，返回由其中三个长度组成的、面积不为零的三角形的最大周长。
//
//        如果不能形成任何面积不为零的三角形，返回 0。
        public int LargestPerimeter(int[] A)
        {
            //任意两边之和大于第三边，任意两边之差小于第三边
//            方法：排序
//                思路
//
//            不失一般性的，我们假设三角形的边长满足  a≤b≤c。那么这三条边组成三角形的面积非零的充分必要条件是  a + b > c。
//
//            再假设我们已经知道 c 的长度了，我们没有理由不从数组中选择尽可能大的 a 与 b。因为当且仅当 a +b  > c 的时候，它们才能组成一个三角形。
//
//            算法
//
//                基于这种想法，一个简单的算法就呼之欲出：排序数组。对于数组内任意的 c，我们选择满足条件的最大的 a≤b≤c，也就是大到小排序，位于 c 后面的两个元素。 从大到小枚举 c，如果能组成三角形的话，我们就返回答案
//
//                作者：LeetCode
//                链接：https://leetcode-cn.com/problems/largest-perimeter-triangle/solution/san-jiao-xing-de-zui-da-zhou-chang-by-leetcode/
//            来源：力扣（LeetCode）
//            著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
            Array.Sort(A); //默认从小到大排序
            for (int i = A.Length - 3; i >= 0; i--)
            {
                if (A[i] + A[i + 1] > A[i + 2])
                {
                    return A[i] + A[i + 1] + A[i + 2];
                }
            }
            return 0;
        }
    }
}
