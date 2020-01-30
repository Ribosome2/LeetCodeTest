using System;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    class MinTimeToVisitAllPoints_Test
    {
//        平面上有 n个点，点的位置用整数坐标表示 points[i] = [xi, yi]。请你计算访问所有这些点需要的最小时间（以秒为单位）。
//
//        你可以按照下面的规则在平面上移动：
//
//        每一秒沿水平或者竖直方向移动一个单位长度，或者跨过对角线（可以看作在一秒内向水平和竖直方向各移动一个单位长度）。
//        必须按照数组中出现的顺序来访问这些点。
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/minimum-time-visiting-all-points
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int time = 0;
            //思路，先对角，再平移
            for (int i = 1; i < points.GetLength(0); i++)
            {
                var point1 = points[i-1];
                var point2 = points[i];
                time += GetTime(point1[0], point1[1], point2[0], point2[1]);
            }
            return time;
        }

        /// <summary>
        /// 两个点之间，只能先走对角线，对角线就要求x和y的移动距离是要一样的
        /// xy移动了一样的距离之后剩下的就是走直线了
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        int GetTime(int x1, int y1, int x2, int y2)
        {
            int xDif = Math.Abs(x1-x2);
            int  yDif = Math.Abs(y1-y2);
            if (xDif >= yDif)
            {
                return yDif + (xDif - yDif);
            }
            else
            {
                return xDif + (yDif - xDif);
            }
        }
    }
}
