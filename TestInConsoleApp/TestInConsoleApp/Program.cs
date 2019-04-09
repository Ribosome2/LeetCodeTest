using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts;

namespace TestInConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Array_Permute();

            var ret=test.Permute(new int[]{1,2,3});
            string str = "result ";
            for (int i = 0; i < ret.Count; i++)
            {
                string comStr = "";
                for (int j = 0; j < ret[i].Count; j++)
                {
                    comStr += ret[i][j];
                }
                str += " "+comStr;
            }
            Console.WriteLine(str);

            Console.Read();
        }


       
    }
}
