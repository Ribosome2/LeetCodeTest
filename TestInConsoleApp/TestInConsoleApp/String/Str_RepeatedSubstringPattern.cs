namespace TestInConsoleApp
{
    public class Str_RepeatedSubstringPattern
    {
        /// <summary>
        /// 给定一个非空的字符串，判断它是否可以由它的一个子串重复多次构成。给定的字符串只含有小写英文字母，并且长度不超过10000。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool RepeatedSubstringPattern(string s)
        {
            var firstC = s[0];
            int secondIndex = 0;
            for (int i = 1; i <= s.Length/2; i++)
            {
                if (s[i] == firstC)
                {
                    secondIndex = i;
                    int patterCount = secondIndex;
                    bool allMatch =true;
                    while (secondIndex<=s.Length-patterCount)
                    {
                        //这样写比用SubString构建字符串要快很多
                        for (int index = 0; index < patterCount; index++)
                        {
                            if (s[index] != s[secondIndex + index])
                            {
                                allMatch = false;
                                break;
                            }
                        }

//                        if (!pattern.Equals(s.Substring(secondIndex, patterCount)))
                        if (allMatch == false) 
                        {
                            break;
                        }
                        else
                        {
                            secondIndex += patterCount;
                        }
                    }

                    if (allMatch && secondIndex==s.Length)
                    {
                        return true;
                    }
                }
            }


            return false;
        }

        
    }
}