using System;

namespace TestInConsoleApp
{
    public class BinaryGapTest
    {
        public int BinaryGap(int N)
        {
            int max = 0;
            int index=0;
            int lastOneIndex = -1;
            while (N>0)
            {
                index++;
                //任意数跟1进行位并操作就可以判断最后一位是否是1
                if ((N & 1) == 1)
                {
                    if (lastOneIndex > 0)
                    {
                        max = Math.Max(index - lastOneIndex, max);
                    }
                    lastOneIndex = index;
                }
                
                N = N >> 1;
            }
            return max;
        }
    }
}