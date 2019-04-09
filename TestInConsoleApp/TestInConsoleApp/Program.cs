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
            var test = new Array_LetterCombinations();

            var ret=test.LetterCombinations("23");
            string str = "result ";
            for (int i = 0; i < ret.Count; i++)
            {
                str += " "+ret[i];
            }
            Console.WriteLine(str);

            Console.Read();
        }


       
    }
}
