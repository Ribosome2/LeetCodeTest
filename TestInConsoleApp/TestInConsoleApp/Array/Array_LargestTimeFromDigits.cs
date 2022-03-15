namespace TestInConsoleApp
{
    public class Array_LargestTimeFromDigits
    {
        public string LargestTimeFromDigits(int[] A)
        {
            if (FindMax(A, 2, 0) < 0)
            {
                return "";
            }

            if (FindMax(A, 23-A[0]*10,1) < 0)
            {
                return "";
            }

            if (FindMax(A, 5,2) < 0)
            {
                return "";
            }

            return string.Format("{0}{1}:{2}{3}", A[0], A[1], A[2], A[3]);
        }

        int FindMax(int[] arr, int max,int curIndex)
        {
            int ret = -1;
            int index = -1;
            for (int i = curIndex; i < arr.Length; i++)
            {
                int num = arr[i];
                if (num <= max && num > ret)
                {
                    ret = num;
                    index = i;
                }
            }

            if (ret > -1)
            {
                SwapIndex(arr, curIndex, index);
            }
            return ret;
        }

        private static void SwapIndex(int[] arr, int curIndex, int index)
        {
            int temp = arr[curIndex];
            arr[curIndex] = arr[index];
            arr[index] = temp;
        }


        bool CheckRemainValid(int[] arr,int curIndex,int swapIndex)
        {
            SwapIndex(arr,curIndex,swapIndex);
            if (curIndex == 0)//第一位确定后，第二位，第三位要判断是否有合法的
            {
                if (arr[0] == 0)
                {

                }
            }
            SwapIndex(arr, curIndex, swapIndex);
            return true;
        }
    }
}