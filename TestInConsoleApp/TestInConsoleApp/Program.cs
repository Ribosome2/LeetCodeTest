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

            var test = new LargestPerimeter_Test();
          
            Console.WriteLine(test.LargestPerimeter(new []{2,1,2}));
            Console.ReadKey();
        }


       
    }
}
