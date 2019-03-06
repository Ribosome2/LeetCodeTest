using System.Text;

namespace TestInConsoleApp
{
    public class Str_StrWithout3a3b
    {
        //给定两个整数 A 和 B，返回任意字符串 S，要求满足：

        //S 的长度为 A + B，且正好包含 A 个 'a' 字母与 B 个 'b' 字母；
        //子串 'aaa' 没有出现在 S 中；
        //子串 'bbb' 没有出现在 S 中。
       
        public string StrWithout3a3b(int A, int B)
        {
            StringBuilder sb=new StringBuilder();
            int bCount = 0;
            int aCount = 0;
            while (A>0 || B>0)
            {
                if (aCount == 2)
                {
                    sb.Append('b');
                    B--;
                    bCount++;
                    aCount = 0;
                }
                else if (bCount == 2)
                {
                    sb.Append('a');
                    A--;
                    aCount++;
                    bCount = 0;
                }
                else
                {
                    if (A - B > 2)
                    {
                        sb.Append('a');
                        A--;
                        aCount++;
                        bCount = 0;
                    }
                    else if (B - A > 2)
                    {
                        sb.Append('b');
                        B--;
                        bCount++;
                        aCount = 0;
                    }
                    else
                    {
                        if (A > B)
                        {
                            sb.Append('a');
                            A--;
                            aCount++;
                            bCount = 0;
                        }
                        else
                        {
                            sb.Append('b');
                            B--;
                            bCount++;
                            aCount = 0;
                        }
                    }
                }
            }

            return sb.ToString();
        }
    }
}