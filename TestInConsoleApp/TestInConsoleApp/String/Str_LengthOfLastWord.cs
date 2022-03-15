namespace TestInConsoleApp
{
    public class Str_LengthOfLastWord
    {
//        给定一个仅包含大小写字母和空格 ' ' 的字符串，返回其最后一个单词的长度。
//        如果不存在最后一个单词，请返回 0 。
//        说明：一个单词是指由字母组成，但不包含任何空格的字符串。
        public int LengthOfLastWord(string s)
        {
            int count=0;
            for (int i = s.Length-1; i >=0; i--)
            {
                if (s[i] == ' ')
                {
                    if (count > 0)
                    {
                        return count;
                    }
                    count = 0;
                }
                else
                {
                    count++;
                }
            }

            return count;
        }
    }
}