using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class FindContinuousSequence_Test
    {
        public int[][] FindContinuousSequence(int target)
        {
            int leftNumber = 1;
            int rightNumber = target;
            List<int> arrList = new List<int>();
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
                            arrList.Add(leftNumber);
                            arrList.Add(sequenceNum);
                        }
                        break;

                        //优化，得到了一个合适的区间之后可以使用滑动窗口优化一下后面的答案的搜索，避免重复求和
                    }
                    curNumber++;
                }

                leftNumber++;
            }

            int count = arrList.Count / 2;
            int[][] result= new int[count][];
            int index = 0;
            for (int  i = 0; i < count; i++)
            {
                int starNumber = arrList[index];
                
                int sequenceNum = arrList[index+1];
                index+=2;
                result[i] = MakeArray(sequenceNum, starNumber);
            }
            return result;
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