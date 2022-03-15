namespace TestInConsoleApp
{
    public class Str_DetectCapitalUse
    {
        //给定一个单词，你需要判断单词的大写使用是否正确。

        //我们定义，在以下情况时，单词的大写用法是正确的：

        //全部字母都是大写，比如"USA"。
        //单词中所有字母都不是大写，比如"leetcode"。
        //如果单词不只含有一个字母，只有首字母大写， 比如 "Google"。
        //否则，我们定义这个单词没有正确使用大写字母。
        public bool DetectCapitalUse(string word)
        {
            int capFactor = 0;
            int lowerSum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (IsCapital(word[i]))
                {
                    if (i != 0) //只有首字母可以大写
                    {
                        capFactor = 1;
                    }
                }
                else
                {
                    lowerSum++;
                }

                if (capFactor * lowerSum > 0) //大小写都有了并且不是首字母的时候会大于0
                {
                    return false;
                }
            }
            return true;
        }

        //是否大写
        bool IsCapital(char c)
        {
            return c > 64 && c < 91;
        }
    }
}