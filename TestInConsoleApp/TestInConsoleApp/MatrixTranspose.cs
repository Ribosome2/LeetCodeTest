using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class MatrixTranspose
    {
        //给定一个矩阵 A， 返回 A 的转置矩阵。
        //矩阵的转置是指将矩阵的主对角线翻转，交换矩阵的行索引与列索引。
        public int[][] Transpose(int[][] A)
        {
            int row = A.Length;
            int col = A[0].Length;

            int[][] result=new int[col][];
            for (int i=0;i< col; i++)
            {
                result[i]=new int[row];
                for (int j = 0; j < row; j++)
                {
                    result[i][j] = A[j][i];
                }
            }
            
            return result;
        }
    }
}
