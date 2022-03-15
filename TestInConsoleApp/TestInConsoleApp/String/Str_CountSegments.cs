namespace TestInConsoleApp
{
    public class Str_CountSegments
    {

        //统计字符串中的单词个数，这里的单词指的是连续的不是空格的字符。
        //请注意，你可以假定字符串里不包括任何不可打印的字符。
        public int CountSegments(string s)
        {
            int count = 0;
            int notEmptyCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (notEmptyCount > 0)
                    {
                        count++;
                    }

                    notEmptyCount = 0;
                }
                else
                {
                    notEmptyCount++;
                }
            }
            if (notEmptyCount > 0)
            {
                count++;
            }
            return count;
        }
        public int CountSegments1(string s)
        {
            int count = 0;
            bool notEmpty = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (notEmpty)
                    {
                        count++;
                    }

                    notEmpty = false;
                }
                else
                {
                    notEmpty=true;
                }
            }
            if (notEmpty )
            {
                count++;
            }
            return count;
        }
    }
}