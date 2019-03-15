﻿using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_FloodFill
    {
        //有一幅以二维整数数组表示的图画，每一个整数表示该图画的像素值大小，数值在 0 到 65535 之间。
        //给你一个坐标(sr, sc) 表示图像渲染开始的像素值（行 ，列）和一个新的颜色值 newColor，让你重新上色这幅图像。
        //为了完成上色工作，从初始坐标开始，记录初始坐标的上下左右四个方向上像素值与初始坐标相同的相连像素点，
        //接着再记录这四个方向上符合条件的像素点与他们对应四个方向上像素值与初始坐标相同的相连像素点，……
        //，重复该过程。将所有有记录的像素点的颜色值改为新的颜色值。
        //最后返回经过上色渲染后的图像。
        public int[,] FloodFill(int[,] image, int sr, int sc, int newColor)
        {
            int maxRow = image.GetLength(0);
            int maxCol = image.GetLength(1);
            Queue<int > openQueque=new Queue<int>();
            int targetValue = image[sr, sc];
            if (targetValue == newColor)
            {
                return image;
            }
           TryFillQueque(image,targetValue,openQueque,sr,sc,maxRow,maxCol);
            while (openQueque.Count>0)
            {
                int count = openQueque.Count;
                while (count>0)
                {
                    int index = openQueque.Dequeue();
                    int row = index / maxCol;
                    int col = index % maxCol;
                    if (image[row, col] == targetValue)
                    {
                        image[row, col] = newColor;
                        TryFillQueque(image, targetValue, openQueque, row - 1, col, maxRow, maxCol);
                        TryFillQueque(image, targetValue, openQueque, row + 1, col, maxRow, maxCol);
                        TryFillQueque(image, targetValue, openQueque, row , col - 1, maxRow, maxCol);
                        TryFillQueque(image, targetValue, openQueque, row , col + 1, maxRow, maxCol);
                    }

                    count--;
                }
            }
            return image;
        }

        void TryFillQueque(int[,] image,int target, Queue<int> q, int rowIndex, int colIndex, int maxRow, int maxCol)
        {
            if (rowIndex >= 0 && rowIndex < maxRow && colIndex >= 0 && colIndex < maxCol)
            {
                if (image[rowIndex, colIndex] == target)
                {
                    q.Enqueue(rowIndex * maxCol + colIndex);
                }
            }
        }
        
    }
}