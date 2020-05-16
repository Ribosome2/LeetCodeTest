using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class FindContinuousSequence_Test
    {
        public int[][] FindContinuousSequence(int target)
        {
            int[][] result;
            int leftNumber = 1;
            int rightNumber = target;
            List<int[]> arrList = new List<int[]>();
            while (leftNumber<rightNumber)
            {
                var sum = 0;
                int curNumber = leftNumber;
                while (sum<target && curNumber<rightNumber)
                {
                    sum += curNumber;
                    if (sum == target )
                    {
                        int sequenceNum = curNumber - leftNumber+1;
                        if (sequenceNum > 1)
                        {
                           var arr= MakeArray(sequenceNum, leftNumber);
                            arrList.Add(arr);
                        }
                        break;
                    }
                    curNumber++;
                    
                }

                leftNumber++;
            }
            return arrList.ToArray();
        }

        private static int[]  MakeArray(int sequenceNum, int leftNumber)
        {
            int[] arr = new int[sequenceNum];
            arr[0] = leftNumber;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + 1;
            }
            return arr;
        }
    }
}