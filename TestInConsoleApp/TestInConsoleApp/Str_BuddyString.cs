namespace TestInConsoleApp
{
    public class Str_BuddyString
    {
        //给定两个由小写字母构成的字符串 A 和 B ，只要我们可以通过交换 A 中的两个字母得到与 B 相等的结果，就返回 true ；否则返回 false 。
        public bool BuddyStrings(string A, string B)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                {
                    //todo
                }
            }

            return false;
        }
    }
}