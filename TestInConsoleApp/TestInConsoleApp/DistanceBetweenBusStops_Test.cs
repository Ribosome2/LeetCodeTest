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
                        while (goDownDist>goUpDist && goUpIndex!=destination)
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
                goUpDist += distance[distance.Length-1];
            }
            else
            {
                goUpDist += distance[goUpIndex-1];
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
    }
}
