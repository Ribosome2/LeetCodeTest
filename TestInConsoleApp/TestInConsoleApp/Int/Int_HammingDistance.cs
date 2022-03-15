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
            //从右向左遍历，当两个都有数的时候对比一下， 只有一个还有值的时候，另一个就是0，有值的位为1就加1
            while (indexX>-1 ||  indexY>-1)
            {
                if (indexX > -1 && indexY > -1)
                {
                    if (binX[indexX] != binY[indexY])
                    {
                        dist++;
                    }
                }
                else
                {
                    if (indexY > -1 && binY[indexY]=='1')
                    {
                        dist++;
                    }else if (indexX > -1 && binX[indexX] == '1')
                    {
                        dist++;
                    }
                }
                

                indexY--;
                indexX--;
            }
           

            return dist;
        }

        public int HammingDistance1(int x, int y)
        {
            //位运算和上面转成字符串再对比好像也差不了多少，内存也差不了多少，测试框架有问题？
            int res = 0;
            int z = x ^ y;
            while (z>0)
            {
                if ((z & 1)>0)
                {
                    ++res;
                }
                   
                z >>= 1;
            }
            return res;
        }
    }
}