using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class DistanceBetweenBusStops_Test
    {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            if (start == destination)
            {
                return 0;
            }

            //两边同时走，在没有到达目标之前一直往当前消耗最小的路走
            int goUpDist = 0;
            int goDownDist = 0;
            int goUpIndex = start;
            int goDownIndex = start;

            while (true)
            {
                if (goUpDist > goDownDist)
                {
                    //we go down
                    goDownIndex = GoDown(distance, goDownIndex, ref goDownDist);
                    if (goDownIndex == destination)
                    {
                        while (goDownDist > goUpDist && goUpIndex != destination)
                        {
                            goUpIndex = GoUp(distance, goUpIndex, ref goUpDist);
                        }

                        if (goUpIndex == destination && goUpDist < goDownDist)
                        {
                            return goUpDist;
                        }

                        return goDownDist;
                    }
                }
                else
                {
                    goUpIndex = GoUp(distance, goUpIndex, ref goUpDist);

                    if (goUpIndex == destination)
                    {
                        while (goDownDist < goUpDist && goDownIndex != destination)
                        {
                            goDownIndex = GoDown(distance, goDownIndex, ref goDownDist);
                        }

                        if (goDownIndex == destination && goDownDist < goUpDist)
                        {
                            return goDownDist;
                        }

                        return goUpDist;
                    }
                }
            }
        }

        private static int GoUp(int[] distance, int goUpIndex, ref int goUpDist)
        {
            goUpIndex++;
            if (goUpIndex == distance.Length)
            {
                goUpIndex = 0;
            }

            if (goUpIndex == 0)
            {
                goUpDist += distance[distance.Length - 1];
            }
            else
            {
                goUpDist += distance[goUpIndex - 1];
            }

            return goUpIndex;
        }

        private static int GoDown(int[] distance, int goDownIndex, ref int goDownDist)
        {
            goDownIndex--;
            if (goDownIndex < 0)
            {
                goDownIndex = distance.Length - 1;
            }

            if (goDownIndex == distance.Length - 1)
            {
                goDownDist += distance[goDownIndex];
            }
            else
            {
                goDownDist += distance[goDownIndex];
            }

            return goDownIndex;
        }


        public int DistanceBetweenBusStops_Better(int[] distance, int start, int destination)
        {
            int totalDist = 0;
            for (int i = 0; i < distance.Length; i++)
            {
                totalDist += distance[i];
            }

            int oneDirDist = 0;

            //因为是一个环，所以按照正常顺序求和肯定是闭环的一个方向的总距离
            //然后另外一个方向的总距离就等于环的总距离减去这一个方向的总距离
            if (start > destination)
            {
                int temp = destination;
                destination = start;
                start = temp;
            }

            for (int i = start; i < destination; i++)
            {
                oneDirDist += distance[i];
            }

            int anotherDirDist = totalDist - oneDirDist;
            return Math.Min(oneDirDist, anotherDirDist);
        }
    }
}
