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
            var test = new Array_FloodFill();
            var arr = new int[,] {{0, 0, 0}, {0, 1, 1}};
            Console.WriteLine(test.FloodFill(arr, 1, 1, 1));
            Console.Read();
        }
    }
}
