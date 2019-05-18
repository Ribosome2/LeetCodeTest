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
            string str="abc";
            char[] arr=new char[3];
            new TwoCitySchedCost_Test().TwoCitySchedCost(new int[6][]
            {
               new int[]{259,270 },
               new int[]{448,54 },
               new int[]{926,667 },
               new int[]{184,139 },
                new int[]{840,118 },
                new int[]{577,469 },
            });
            Console.Read();
        }


       
    }
}
