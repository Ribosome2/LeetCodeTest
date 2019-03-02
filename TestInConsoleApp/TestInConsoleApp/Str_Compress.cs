using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Str_Compress
    {
        //给定一组字符，使用原地算法将其压缩。
//        压缩后的长度必须始终小于或等于原数组长度。
//        数组的每个元素应该是长度为1 的字符（不是 int 整数类型）。
//        在完成原地修改输入数组后，返回数组的新长度。
//
//        进阶：
//        你能否仅使用O(1) 空间解决问题？
        public int Compress(char[] chars)
        {
            if (chars.Length == 1)
            {
                return 1;
            }
            int count = 0;
            char prev=chars[0];
            int prevCount=1;
            int validIndex = 0;
            count = 1;

            for (int i = 1; i < chars.Length; i++)
            {
                var c = chars[i];
                if (c != prev)
                {
                    chars[validIndex] = prev;
                    validIndex++;
                    count++;
                    if (prevCount > 1)
                    {
                        if (prevCount < 10)
                        {
                            chars[validIndex] = (char)(prevCount + 48);
                            count++;
                            validIndex++;
                        }
                        else
                        {
                            var numQue = NumToStack(prevCount);
                            while (numQue.Count > 0)
                            {
                                var num = numQue.Pop();
                                chars[validIndex] = (char)(num + 48);
                                count++;
                                validIndex++;
                            }
                        }
                    }

                    prevCount = 1;
                    prev = c;
                }
                else
                {
                    prevCount++;
                }
            }

            chars[validIndex] = prev;
            validIndex++;
            count++;
            if (prevCount > 1)
            {
                if (prevCount < 10)
                {
                    chars[validIndex] = (char)(prevCount + 48);
                    count++;
                    validIndex++;
                }
                else
                {
                    var numQue = NumToStack(prevCount);
                    while (numQue.Count > 0)
                    {
                        var num = numQue.Pop();
                        chars[validIndex] = (char)(num + 48);
                        count++;
                        validIndex++;
                    }
                }
            }
            

            return count;

        }

        Stack<int> NumToStack(int number)
        {
            Stack<int> stack=new Stack<int>();
            while (number > 0)
            {
                var num = number % 10;
                number /= 10;
                stack.Push(num);
               
            }
            return stack ;
        }

    }
}