namespace TestInConsoleApp
{
    public class MaxUncrossedLines_Test
    {
//        我们在两条独立的水平线上按给定的顺序写下 A 和 B 中的整数。
//        现在，我们可以绘制一些连接两个数字 A[i] 和 B[j] 的直线，只要 A[i] == B[j]，且我们绘制的直线不与任何其他连线（非水平线）相交。
//        以这种方法绘制线条，并返回我们可以绘制的最大连线数。
        public int MaxUncrossedLines(int[] A, int[] B)
        {
            //todo
            int count = 0;
            int indexB = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = indexB; j < B.Length; j++)
                {
                    if (B[j] == A[i])
                    {
                        count++;
                        indexB = j+1;
                        break;
                    }
                }
            }
            return count;
        }
    }
}