namespace TestInConsoleApp
{
    public class Int_PlusOne
    {
//        给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。
//        最高位数字存放在数组的首位， 数组中每个元素只存储一个数字。
//        你可以假设除了整数 0 之外，这个整数不会以零开头。
        public int[] PlusOne(int[] digits)
        {
            //按照十进制立竖式的方法来
            int temp = 1;
            for(int i=digits.Length-1;i>=0; i--)
            {
                int num = digits[i] + temp;
                if (num < 10)
                {
                    digits[i] = num;
                    temp = 0;
                    break;
                }
                else
                {
                    digits[i] = num % 10;
                }
            }

            if (temp > 0)
            {
                //位数不够需要加一位
                int[] arr=new int[digits.Length+1];
                arr[0] = 1;
                for (int i=0; i < digits.Length; i++)
                {
                    arr[i + 1] = digits[i];
                }

                return arr;
            }
            else
            {
                return digits;
            }
        }
    }
}