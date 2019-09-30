using System;
using System.Collections.Generic;
using System.Text;
namespace TestInConsoleApp
{
    public  class Str_MutiplyNumber
    {
        //给定两个以字符串形式表示的非负整数 num1 和 num2，返回 num1 和 num2 的乘积，
        //它们的乘积也表示为字符串形式。
        public string Multiply(string num1, string num2)
        {
            if(num1=="0" || num2=="0")
            {
                return "0";
            }
            //立竖式思想
            List<int> reList = new List<int>();
            int offsetIndex = 0;
            for(int i=0;i<num2.Length;i++)
            {
                var n2 = num2[num2.Length-1-i] -48;
                for(int j=0;j<num1.Length;j++)
                {
                    var n1 = num1[num1.Length-1-j]-48;
                    int numberIndex = j + offsetIndex;
                    int mulN = n1 * n2;
                    //Console.WriteLine(string.Format("result {0} ,n1 {1} ,n2 {2} n2", mulN, n1, n2));
                    int thisNum = mulN % 10;
                    int addNum =(int)Math.Floor( mulN / 10.0);
                    AddToNumberList(reList, numberIndex, thisNum);
                    if(addNum>0)
                    {
                        AddToNumberList(reList, numberIndex+1, addNum);
                    }
                }

                offsetIndex++;
            }
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<reList.Count;i++)
            {
                sb.Insert(0, ((char)(reList[i] + 48)));
            }
            return sb.ToString();
        }

        void AddToNumberList(List<int> numberList,int addIndex,int addNum)
        {
            //Console.WriteLine("AD " + addIndex + " add numb " + addNum);
            if(addIndex==numberList.Count)
            {
                numberList.Add(addNum);
            }
            else
            {
              
                addNum = numberList[addIndex] + addNum;
                numberList[addIndex] = addNum % 10;
                addNum = (int)Math.Floor(addNum / 10.0);
                if(addNum>0)
                {
                    AddToNumberList(numberList, addIndex + 1, addNum);
                }
            }
        }
    }
}
