using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Str_FindWords
    {
        //给定一个单词列表，只返回可以使用在键盘同一行的字母打印出来的单词。键盘如下图所示。
//        注意：
//
//        你可以重复使用键盘上同一字符。
//        你可以假设输入的字符串将只包含字母。
        Dictionary<char,int> KeyDict=new Dictionary<char, int>()
        {
            { 'q',1},
            { 'w',1},
            { 'e',1},
            { 'r',1},
            { 't',1},
            { 'y',1},
            { 'u',1},
            { 'i',1},
            { 'o',1},
            { 'p',1},
            { 'Q',1},
            { 'W',1},
            { 'E',1},
            { 'R',1},
            { 'T',1},
            { 'Y',1},
            { 'U',1},
            { 'I',1},
            { 'O',1},
            { 'P',1},

            { 'a',2},
            { 's',2},
            { 'd',2},
            { 'f',2},
            { 'g',2},
            { 'h',2},
            { 'j',2},
            { 'k',2},
            { 'l',2},
            { 'A',2},
            { 'S',2},
            { 'D',2},
            { 'F',2},
            { 'G',2},
            { 'H',2},
            { 'J',2},
            { 'K',2},
            { 'L',2},

            { 'z',3},
            { 'x',3},
            { 'c',3},
            { 'v',3},
            { 'b',3},
            { 'n',3},
            { 'm',3},
            { 'Z',3},
            { 'X',3},
            { 'C',3},
            { 'V',3},
            { 'B',3},
            { 'N',3},
            { 'M',3},

        };
        public string[] FindWords(string[] words)
        {
            List<string> reList=new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (IsSameLine(ref words[i]))
                {
                    reList.Add(words[i]);
                }
            }
            return reList.ToArray();
        }

        bool IsSameLine(ref string str)
        {
            int key = KeyDict[str[0]];
            for (int i = 1; i < str.Length; i++)
            {
                if (KeyDict[str[i]] != key)
                {
                    return false;
                }
            }
            return true;
        }
    }
}