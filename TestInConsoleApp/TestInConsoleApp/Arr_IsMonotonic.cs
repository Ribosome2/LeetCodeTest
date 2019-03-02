namespace TestInConsoleApp
{
    public class Arr_IsMonotonic
    {
//        如果数组是单调递增或单调递减的，那么它是单调的。
//        如果对于所有 i <= j，A[i] <= A[j]，那么数组 A 是单调递增的。 如果对于所有 i <= j，A[i]> = A[j]，那么数组 A 是单调递减的。
//        当给定的数组 A 是单调数组时返回 true，否则返回 false。
        public bool IsMonotonic(int[] A)
        {
            int factor = 0;
            for (int i = 1; i < A.Length; i++)
            {
                var dif = A[i] - A[i - 1];
                if (dif > 0)
                {
                    if (factor < 0)
                    {
                        return false;
                    }
                    factor = 1;
                }else if (dif < 0)
                {
                    if (factor > 0)
                    {
                        return false;
                    }
                    factor = -1;
                }

            }

            return true;
        }
    }
}