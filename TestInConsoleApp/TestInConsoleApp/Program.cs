﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var test=new GenerateTowerTriangle();
            Console.WriteLine(test.GetRow1(4));
           
            Console.Read();
        }
    }
}
