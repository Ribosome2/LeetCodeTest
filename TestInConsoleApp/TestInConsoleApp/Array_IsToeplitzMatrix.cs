namespace TestInConsoleApp
{
    public class Array_IsToeplitzMatrix
    {
        //如果一个矩阵的每一方向由左上到右下的对角线上具有相同元素，那么这个矩阵是托普利茨矩阵。

        //给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True
        public bool IsToeplitzMatrix(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            for (int i = 0; i < colCount; i++)
            {
                int row = rowCount - 1;
                int col = i;
                int val = matrix[row, col];
                while (col >= 0 && col < colCount && row >= 0 && row < rowCount)
                {
                    if (matrix[row, col] != val)
                    {
                        return false;
                    }
                    col--;
                    row--;
                }
            }
            return true;
        }

    }
}