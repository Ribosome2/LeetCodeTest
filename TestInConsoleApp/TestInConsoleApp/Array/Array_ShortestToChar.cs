namespace TestInConsoleApp
{
    public class Array_ShortestToChar
    {
        public int[] ShortestToChar(string S, char C)
        {
            int left;
            int right  ;
            int[] arr=new int[S.Length];
            for (int i=0; i < arr.Length; i++)
            {
                if (S[i] == C)
                {
                    arr[i] = 0;
                }
                else
                {
                    left = right = i;
                    while (left>0 || right<arr.Length-1)
                    {
                        if (left > 0)
                        {
                            left--;
                            if (S[left] == C)
                            {
                                arr[i] = i - left;
                                break;
                            }
                        }

                        if (right < arr.Length - 1)
                        {
                            right++;
                            if (S[right] == C)
                            {
                                arr[i] = right - i;
                                break;
                            }
                        }
                    }
                    
                }
            }

            return arr;
        }
    }
}