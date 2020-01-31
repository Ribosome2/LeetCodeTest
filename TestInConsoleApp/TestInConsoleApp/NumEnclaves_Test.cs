using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
//
//    给出一个二维数组 A，每个单元格为 0（代表海）或 1（代表陆地）。
//
//    移动是指在陆地上从一个地方走到另一个地方（朝四个方向之一）或离开网格的边界。
//
//    返回网格中无法在任意次数的移动中离开网格边界的陆地单元格的数量。
//
//    来源：力扣（LeetCode）
//    链接：https://leetcode-cn.com/problems/number-of-enclaves
//    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class NumEnclaves_Test
    {
        public int NumEnclaves(int[][] A)
        {
            int count = 0;
            int rowCount = A.GetLength(0);
            int colCount = A[0].Length;
            Dictionary<int,bool>  passDict= new Dictionary<int, bool>();
            Queue<int> passQueque = new Queue<int>();
            //从四个边界找到所有陆地，从这些陆地里面找相邻的陆地并把相邻的陆地标记为通过点
            int topRowIndex = 0;
            int botRowIndex = rowCount - 1;
            int leftColIndex = 0;
            int rightColIndex = colCount - 1;

            //上下边界
            for (int col = 0; col < colCount; col++)
            {
                CheckMarkAsPass(A,topRowIndex,col,colCount,passDict,passQueque);
                CheckMarkAsPass(A,botRowIndex, col, colCount, passDict,passQueque);
            }

            //左右边界
            for (int row = 1; row < rowCount; row++)
            {
                CheckMarkAsPass(A,row,leftColIndex,colCount,passDict,passQueque);
                CheckMarkAsPass(A,row, rightColIndex, colCount, passDict,passQueque);
            }

            var quequeCount = passQueque.Count;
            while (quequeCount>0)
            {
                for (int i = 0; i < quequeCount; i++)
                {
                    var index = passQueque.Dequeue();
                    var row = index / colCount;
                    var col = index % colCount;
                    CheckNeighbor(A,row - 1, col, rowCount, colCount, passDict, passQueque);
                    CheckNeighbor(A,row + 1, col, rowCount, colCount, passDict, passQueque);
                    CheckNeighbor(A,row , col-1, rowCount, colCount, passDict, passQueque);
                    CheckNeighbor(A,row , col+1, rowCount, colCount, passDict, passQueque);

                }

                quequeCount = passQueque.Count;
            }

            for (int i = 1; i <rowCount-1 ; i++)
            {
                for (int j = 1; j < colCount -1; j++)
                {
                    if (A[i][j] == 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        void  CheckNeighbor(int[][] A,int row, int col, int rowCount, int colCount, Dictionary<int, bool> passDict, Queue<int> passQueque)
        {
            if (row < 0 || row >= rowCount || col < 0 || col >= colCount)
            {
                return;
            }

            if (A[row][col] == 1)
            {
                int index = row * colCount + col;
                A[row][col] = 0;
                if (passDict.ContainsKey(index) == false)
                {
                    passDict[index] = true;
                    passQueque.Enqueue(index);
                }
            }
        }

        void CheckMarkAsPass(int[][] A,int row, int col, int colCount,Dictionary<int ,bool> passDict,Queue<int> passQueque)
        {
            if (A[row][col] == 1)
            {
                int index = row * colCount + col;
                A[row][col] = 0;
                passDict[index] = true;
                passQueque.Enqueue(index);
            }
        }

        bool IsNotEdge(int i, int j,int rowCount,int colCount)
        {
            return (i != 0 && j != 0 && i != rowCount - 1 && j != colCount - 1);
        }
    }
}
