using System.Collections;
using System.Collections.Generic;
public class StrLongestCommonPrefix  {
    //编写一个函数来查找字符串数组中的最长公共前缀。
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs==null ||strs.Length == 0)
        {
            return "";
        }

        if (strs.Length == 1)
        {
            return strs[0];
        }

        for (int i = 0; i < strs[0].Length; i++)
        {
            var curCharactor = strs[0][i];
            for (int index = 1; index < strs.Length; index++)
            {
                var arr = strs[index];
                if (arr.Length < (i + 1) || arr[i] != curCharactor)
                {
                    if (i > 0)
                    {
                        return strs[0].Substring(0, i);
                    }
                    else
                    {
                        return "";
                    }
                   
                }
            }
        }
        
        return strs[0];
    }
}
