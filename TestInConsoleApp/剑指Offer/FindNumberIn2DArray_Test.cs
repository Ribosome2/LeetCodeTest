using System;

namespace 剑指Offer
{
    public class FindNumberIn2DArray_Test
    {
        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return false;
            }
            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;
            int row = 0;
            int col = colCount - 1;
            while (row<rowCount && col>=0)
            {
                var number = matrix[row][col];
                if (number==target)
                {
                    return true;
                }
                else
                {
                    if (number < target)
                    {
                        row++;
                       
                    }
                    else
                    {
                        col--;
                    }
                }
            }
            return false;
        }
    }
}