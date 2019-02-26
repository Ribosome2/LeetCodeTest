namespace TestInConsoleApp
{
    public class Str_FindTheDifference
    {
//        给定两个字符串 s 和 t，它们只包含小写字母。
//        字符串 t 由字符串 s 随机重排，然后在随机位置添加一个字母。
//        请找出在 t 中被添加的字母。
        public char FindTheDifference(string s, string t)
        {
            int num = 0;
            for (int i = 0; i < t.Length; i++)
            {
                num += t[i];
            }
            for (int i = 0; i < s.Length; i++)
            {
                num -= s[i];
            }
          
            return (char) num;
        }
        //位运算比整数运算更快
        public char FindTheDifference1(string s, string t)
        {
            int num = 0;
            for (int i = 0; i < t.Length; i++)
            {
                num ^= t[i];
            }
            for (int i = 0; i < s.Length; i++)
            {
                num ^= s[i];
            }

            return (char)num;
        }
    }
}