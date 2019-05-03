namespace TestInConsoleApp
{
    public class Array_SortArrayByParityII
    {
//        给定一个非负整数数组 A， A 中一半整数是奇数，一半整数是偶数。
//        对数组进行排序，以便当 A[i] 为奇数时，i 也是奇数；当 A[i] 为偶数时， i 也是偶数。
//        你可以返回任何满足上述条件的数组作为答案。
        public int[] SortArrayByParityII(int[] A)
        {
            int modValue = 0;
            for (int i = 0; i < A.Length-1; i++)
            {
                if (A[i] % 2 != modValue)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] % 2 == modValue)
                        {
                            int temp = A[j];
                            A[j] = A[i];
                            A[i] = temp;
                        }
                    }
                }

                modValue = modValue == 1 ? 0 : 1;
            }
            return A;
        }

        public int[] SortArrayByParity2(int[] A)
        {
            int modValue = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] % 2 != modValue)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] % 2 == modValue)
                        {
                            int temp = A[j];
                            A[j] = A[i];
                            A[i] = temp;
                        }
                    }
                }

                modValue = modValue == 1 ? 0 : 1;
            }
            return A;
        }
    }
}