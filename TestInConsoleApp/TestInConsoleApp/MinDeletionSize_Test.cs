namespace TestInConsoleApp
{
    public class MinDeletionSize_Test
    {
        public int MinDeletionSize(string[] A)
        {
            int deleteCount = 0;

            if (A.Length > 1)
            {
                int count = A[0].Length;

                for (int i = 0; i < count; i++)
                {
                    for (int j = 1; j < A.Length; j++)
                    {
                        if (A[j][i] < A[j - 1][i])
                        {
                            deleteCount++;
                            break;
                        }
                    }
                }
            }

            return deleteCount;
        }
    }
}