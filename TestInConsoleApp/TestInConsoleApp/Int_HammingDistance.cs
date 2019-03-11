using System;

namespace TestInConsoleApp
{
    public class Int_HammingDistance
    {
        //两个整数之间的汉明距离指的是这两个数字对应二进制位不同的位置的数目。

        //给出两个整数 x 和 y，计算它们之间的汉明距离。
        public int HammingDistance(int x, int y)
        {
            int dist = 0;
            var binX = Convert.ToString(x,2);
            var binY = Convert.ToString(y,2);
            int indexX = binX.Length - 1;
            int indexY = binY.Length - 1;
            while (indexX>-1 && indexY>-1)
            {
                if (binX[indexX] != binY[indexY])
                {
                    dist++;
                }

                indexY--;
                indexX--;
            }
           

            return dist;
        }
    }
}