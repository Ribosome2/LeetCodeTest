namespace 剑指Offer
{
    public class SpiralOrder_Test
    {
//        输入一个矩阵，按照从外向里以顺时针的顺序依次打印出每一个数字。
        //这里主要注意边界情况的判定
        public int[] SpiralOrder(int[][] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0)
            {
                return new int[0];
            }
            int rowCount = matrix.GetLength(0);
            int colum = matrix[0].Length;
            var result = new int[rowCount * colum];
            int minRow = 0;
            int maxRow = rowCount - 1;
            int minCol = 0;
            int maxCol = colum - 1;
            int index = 0;
            while (minRow<= maxRow || minCol<= maxCol)
            {
                //to right 
                for (int i = minCol; i <= maxCol && index < result.Length; i++)
                {
                    result[index++] = matrix[minRow][i];
                }

                minRow++;

                //down 
                for (int i = minRow; i <= maxRow && index < result.Length; i++)
                {
                    result[index++] = matrix[i][maxCol];
                }
                maxCol--;

                //left
                for (int i = maxCol; i >= minCol && index < result.Length; i--)
                {
                    result[index++] = matrix[maxRow][i];
                }
                maxRow--;

                //up
                for (int i = maxRow; i >= minRow && index < result.Length; i--)
                {
                    result[index++] = matrix[i][minCol];
                }
                minCol++;
            }


            return result;
        }
    }
}