﻿using System;
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

            var test = new MaxScore_Test();
          
            Console.WriteLine(test.MaxScore(new int[]{1,2,3,4,5,6,1},3));
            Console.ReadKey();
        }


       
    }
}
