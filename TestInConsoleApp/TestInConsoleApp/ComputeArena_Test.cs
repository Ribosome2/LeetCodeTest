using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class ComputeArena_Test
    {
//        在二维平面上计算出两个由直线构成的矩形重叠后形成的总面积。
//
//        每个矩形由其左下顶点和右上顶点坐标表示，如图所示
        public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            int areaA = (C - A) * (D - B);
            int areaB = (G - E) * (H - F);
            int sumArea = areaA + areaB;
            //除了这几种不相交的情况
            if (E >= C || G <= A || F >= D || H <= B)
            {
                return sumArea;
            }
            else
            {
                var topY = Math.Min(D, H);
                var botY = Math.Max(F, B);
                var leftX = Math.Max(A, E);
                var rightX = Math.Min(C, G);
                int overLapArea = (topY - botY) * (rightX - leftX);
                return sumArea - overLapArea;
            }
        }
    }
}
