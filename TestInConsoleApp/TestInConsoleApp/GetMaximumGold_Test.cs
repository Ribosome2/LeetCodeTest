using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class GetMaximumGold_Test
    {
//        你要开发一座金矿，地质勘测学家已经探明了这座金矿中的资源分布，并用大小为 m * n 的网格 grid 进行了标注。每个单元格中的整数就表示这一单元格中的黄金数量；如果该单元格是空的，那么就是 0。
//
//        为了使收益最大化，矿工需要按以下规则来开采黄金：
//
//        每当矿工进入一个单元，就会收集该单元格中的所有黄金。
//        矿工每次可以从当前位置向上下左右四个方向走。
//        每个单元格只能被开采（进入）一次。
//        不得开采（进入）黄金数目为 0 的单元格。
//        矿工可以从网格中 任意一个 有黄金的单元格出发或者是停止。
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/path-with-maximum-gold
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int GetMaximumGold(int[][] grid)
        {
            int ret = 0;
            int rowCount = grid.GetLength(0);
            for (int row = 0; row < rowCount; row++)
            {
                int colCount = grid[row].Length;
                for (int col = 0; col < colCount; col++)
                {
                    if (grid[row][col] != 0)
                    {
                        ret = Math.Max(ret, DoDFS(grid, row, col, rowCount - 1, colCount - 1));
                    }
                }
            }
            return ret;
        }

        int DoDFS(int[][] grid,int row, int col,int maxRow,int maxCol)
        {
            if (row < 0 || row > maxRow || col < 0 || col > maxCol || grid[row][col]==0)
            {
                return 0;
            }

            int curValue = grid[row][col];

            grid[row][col] = 0;
            int left = DoDFS(grid, row, col - 1, maxRow, maxCol);
            int right = DoDFS(grid, row, col + 1, maxRow, maxCol);
            int up = DoDFS(grid, row-1, col , maxRow, maxCol);
            int down = DoDFS(grid, row+1, col, maxRow, maxCol);


            grid[row][col] = curValue;

            return Math.Max(Math.Max(left + curValue, right + curValue),Math.Max(up+curValue,down+curValue));
        }
    }
}
