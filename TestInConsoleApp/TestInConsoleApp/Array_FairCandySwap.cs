using System.Collections;

namespace TestInConsoleApp
{
    public class Array_FairCandySwap
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            //设A数组和未sumA,B的和未sumB A交换的值糖果为tA,B交换的糖果为tB
            //可以得到公式 sumA - tA + tB =sumB - tB + tA
            //推导得(sumA-sumB)/2=tA-tB
            int sumA = 0;
            int sumB = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sumA += A[i];
            }
            Hashtable hs=new Hashtable();
            for (int i = 0; i < B.Length; i++)
            {
                sumB += B[i];
                hs[B[i]] = 0;
            }

            int dif = sumA - sumB / 2;
            for (int i = 0; i < A.Length; i++)
            {
                int targetB = A[i] - dif;
                if (hs.ContainsKey(targetB))
                {
                    return new int[]{A[i],targetB};
                }
            }

            return null;
        }
    }
}