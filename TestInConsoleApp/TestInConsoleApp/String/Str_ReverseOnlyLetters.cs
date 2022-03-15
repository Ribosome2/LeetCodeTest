using System.Collections.Generic;
using System.Text;

namespace TestInConsoleApp
{
    public class Str_ReverseOnlyLetters
    {
        //给定一个字符串 S，返回 “反转后的” 字符串，其中不是字母的字符都保留在原地，而所有字母的位置发生反转。
        public string ReverseOnlyLetters(string S)
        {
            char[] arr=new  char[S.Length];
            List<int> indexList=new List<int>();
            for (int i = 0; i < S.Length; i++)
            {
                var c = S[i];
                if ((c >= 'a' && c <= 'z' ) || (c>='A' && c<='Z'))
                {
                    indexList.Add(i);
                }
                else
                {
                    arr[i] = c;
                }
            }

            int left = 0;
            int right = indexList.Count - 1;

            while (left<=right)
            {
                arr[indexList[left]] = S[indexList[right]];
                arr[indexList[right]] = S[indexList[left]];
                left++;
                right--;
            }
            return  new string(arr);
        }

        //双指针写法，不需要索引列表
        public string ReverseOnlyLetters1(string S)
        {
            char[] arr = new char[S.Length];
            int left = 0;
            int right = S.Length - 1;
            while (left<=right)
            {
                var c = S[left];
                if (IsLetter(c))
                {
                    //从右边选一个字母替换
                    while (left <= right)
                    {
                        if (left == right)
                        {
                            arr[left] = c;
                            left++;
                        }
                        else
                        {
                            var rc = S[right];
                            if (IsLetter(rc))
                            {
                                arr[left] = rc;
                                arr[right] = c;
                                right--;
                                break;
                            }
                            else
                            {
                                arr[right] = rc;
                            }

                            right--;
                        }
                        
                    }
                }
                else
                {
                    arr[left] = c;
                }

                left++;
            }
         
            return new string(arr);
        }

        bool IsLetter(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}