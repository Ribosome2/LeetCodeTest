using System.Collections;
using System.Collections.Generic;
public class StrFindNeedleInHaystack  {
    //给定一个 haystack 字符串和一个 needle 字符串，
    //在 haystack 字符串中找出 needle 字符串出现的第一个位置 (从0开始)。如果不存在，则返回  -1
    public static  int StrStr(string haystack, string needle)
    {
        if (needle==null || needle == "")
        {
            return 0;
        }

        if (haystack.Length < needle.Length)
        {
            return -1;
        }
        var firstCharacter = needle[0];
        for (int i = 0; i < haystack.Length; i++)
        {
            
            if (haystack[i] == firstCharacter)
            {
                if (haystack.Length - i < needle.Length)
                {
                    return -1;
                }
                int startIndex = i;
                for (int index = 0; index < needle.Length; index++,i++)
                {
                    if (needle[index] != haystack[i])
                    {
                        i = startIndex;
                        startIndex = -1;
                        break;
                    }
                }

                if (startIndex != -1)
                {
                    return startIndex;
                }
            }
        }

        return -1;
    }



}
