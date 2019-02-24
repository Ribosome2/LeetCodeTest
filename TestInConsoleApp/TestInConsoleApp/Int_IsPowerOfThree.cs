namespace TestInConsoleApp
{
    public class Int_IsPowerOfThree
    {
        //给定一个整数，写一个函数来判断它是否是 3 的幂次方。
        public bool IsPowerOfThree(int n)
        {
            //第一种，暴力法
            int num = 1; //0次幂也算
            while (num<=n)
            {
                if (num == n)
                {
                    return true;
                }
                num *= 3;
            }
            return false;
        }

        // 别人的实现：
        //        通过查看相关解析，发现了这个解法，用到了数论的知识，3的幂次的质因子只有3
        // ，而所给出的n如果也是3的幂次，故而题目中所给整数范围内最大的3的幂次的因子只能是3的幂次，
        // 1162261467是3的19次幂，是整数范围内最大的3的幂次
        public bool IsPowerOfThree2(int n)
        {
            return n > 0 && 1162261467 % n == 0;
        }
    }
}