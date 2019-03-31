using System;

namespace TestInConsoleApp
{
    public class Int_FindComplement
    {
        //给定一个正整数，输出它的补数。补数是对该数的二进制表示取反。

        //注意:

        //给定的整数保证在32位带符号整数的范围内。
        //你可以假定二进制数不包含前导零位。
        public int FindComplement(int num)
        {
            if (num == 0)
            {
                return num;
            }
            int temp = num, c = 0;
            Console.WriteLine("Temp "+Convert.ToString(temp,2));
            Console.WriteLine("c " + Convert.ToString(c, 2));
            while (temp > 0)
            {
                Console.WriteLine("");

                temp >>= 1;        //这里Temp的作用只是为了创造出跟num 相同位数的全部位从左到右都为1的数
                c = (c << 1) + 1;  //C的每一个位都会是1

                Console.WriteLine("Temp " + Convert.ToString(temp, 2));
                Console.WriteLine("c " + Convert.ToString(c, 2));
            }

         
            Console.WriteLine("Final  " + Convert.ToString(num ^ c, 2));
            //一个数跟跟从左到右（直到0位）全部位为1的数进行异或（如果a、b两个值不相同，则异或结果为1。如果a、b两个值相同，异或结果为0。），
            //就得到它的补位
            return num ^ c;
        }
    }
}