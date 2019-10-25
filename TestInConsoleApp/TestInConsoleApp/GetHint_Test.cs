using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class GetHint_Test
    {

//        你正在和你的朋友玩 猜数字（Bulls and Cows）游戏：你写下一个数字让你的朋友猜。每次他猜测后，你给他一个提示，告诉他有多少位数字和确切位置都猜对了（称为“Bulls”, 公牛），有多少位数字猜对了但是位置不对（称为“Cows”, 奶牛）。你的朋友将会根据提示继续猜，直到猜出秘密数字。
//
//        请写出一个根据秘密数字和朋友的猜测数返回提示的函数，用 A 表示公牛，用 B表示奶牛。
//
//        请注意秘密数字和朋友的猜测数都可能含有重复数字。
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/bulls-and-cows
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public string GetHint(string secret, string guess)
        {
            int numA = 0;
            int numB = 0;
            Dictionary<char,int> chDict =new Dictionary<char, int>();
            List<char> missGuessList =new List<char>();
            for (int i = 0; i < guess.Length; i++)
            {
                var ch = guess[i];
                if (ch == secret[i])
                {
                    numA++;
                }
                else
                {
                    missGuessList.Add(ch);
                    var chA = secret[i];
                    if (chDict.ContainsKey(chA) == false)
                    {
                        chDict[chA] = 1;
                    }
                    else
                    {
                        chDict[chA] = chDict[chA] + 1;
                    }
                }
            }

            for (int i = 0; i < missGuessList.Count; i++)
            {
                var ch = missGuessList[i];
                if (chDict.ContainsKey(ch) && chDict[ch] > 0)
                {
                    chDict[ch] = chDict[ch] - 1;
                    numB++;
                }
            }
            return string.Format("{0}A{1}B",numA,numB);
        }

        public string GetHint2(string secret, string guess)
        {
            int numA = 0;
            int numB = 0;
            int[] arr= new int[10];
            var  missGuessList = new int[10];
            for (int i = 0; i < guess.Length; i++)
            {
                var ch = guess[i];
                if (ch == secret[i])
                {
                    numA++;
                }
                else
                {
                    missGuessList[ch-'0']++;
                    var chA = secret[i];
                    var index = chA - '0';
                    arr[index]++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                numB += Math.Min(arr[i], missGuessList[i]);
            }
           
            return string.Format("{0}A{1}B", numA, numB);
        }
    }


}
