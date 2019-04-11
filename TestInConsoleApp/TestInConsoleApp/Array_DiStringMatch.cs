namespace TestInConsoleApp
{
    public class Array_DiStringMatch
    {
        //给定只含 "I"（增大）或 "D"（减小）的字符串 S ，令 N = S.length。
        //返回[0, 1, ..., N] 的任意排列 A 使得对于所有 i = 0, ..., N-1，都有：
        //如果 S[i] == "I"，那么 A[i] < A[i + 1]
        //如果 S[i] == "D"，那么 A[i] > A[i + 1]
        public int[] DiStringMatch(string S)
        {
            int[] arr=new int[S.Length+1];
            int min = 0;
            int max = S.Length;
            //思路：如果是I就先放最小的，否則放最大的
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'I')
                {
                    arr[i] = min;
                    min++;
                }
                else
                {
                    arr[i] = max;
                    max--;
                    
                }
            }
            //最終只會剩下一個數了， 所以这里取min 或者max都是一样的
            arr[arr.Length-1] = min;
            return arr;
        }
    }
}