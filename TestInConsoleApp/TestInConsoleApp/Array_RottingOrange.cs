using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_RottingOrange
    {
        //在给定的网格中，每个单元格可以有以下三个值之一：

        //值 0 代表空单元格；
        //值 1 代表新鲜橘子；
        //值 2 代表腐烂的橘子。
        //每分钟，任何与腐烂的橘子（在 4 个正方向上）相邻的新鲜橘子都会腐烂。

        //返回直到单元格中没有新鲜橘子为止所必须经过的最小分钟数。如果不可能，返回 -1。

        //1 <= grid.length <= 10
        //1 <= grid[0].length <= 10
        public int OrangesRotting(int[][] grid)
        {
            Queue<int> quequeIndex = new Queue<int>(); //腐烂橘子的索引,记录腐烂的橘子索引，尝试一路传染下去
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 2) //2
                    {
                        int index = (i + 1) * 100 + j;
                        quequeIndex.Enqueue(index);
                    }
                }
            }

            if (quequeIndex.Count > 0)
            {
                int depth = -1;
                while (quequeIndex.Count > 0)
                {
                    depth++;
                    int loopCount = quequeIndex.Count;
                    for (int i = 0; i < loopCount; i++)
                    {
                        int index = quequeIndex.Dequeue();
                        int row = index / 100 - 1;
                        int col = index % 100;

                        //检查四个方向
                        Check(row - 1, col, grid, quequeIndex);
                        Check(row + 1, col, grid, quequeIndex);
                        Check(row, col + 1, grid, quequeIndex);
                        Check(row, col - 1, grid, quequeIndex);
                    }
                }

                //检查是否还有新鲜橘子
                if (HasAnyFresh(grid))
                {
                    return -1;
                }

                return depth;

            }
            else
            {

                //根本没有烂橘子 检查是否还有新鲜橘子， 有的话就是无限
                if (HasAnyFresh(grid))
                {
                    return -1;
                }

                return 0;
            }
        }

        public bool HasAnyFresh(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void Check(int row, int col, int[][] grid , Queue<int> queue)
        {
            if (row >= 0 && row<grid.Length && col>=0 &&  col < grid[0].Length && grid[row][col] == 1)
            {
                grid[row][col] = 2;
                int index= (row + 1) * 100 + col;
                queue.Enqueue(index);
            }
        }
    }
}