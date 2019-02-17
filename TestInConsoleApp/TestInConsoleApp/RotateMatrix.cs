using System;
using System.Collections;
using System.Collections.Generic;
public class RotateMatrix {
    /// <summary>
    /// 按顺时针遍历矩阵，返回一个列表
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public static List<int> SpiralOrder(int[,] matrix)
    {
        List<int> resultList = new List<int>();
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);
        int direction = 0;
        int rowSteps = rowCount;
        int colSteps = colCount;
        int colIndex = -1;
        int rowIndex = 0;
        int totalCount = rowCount * colCount;
        while((rowSteps>0 || colSteps>0) && resultList.Count<totalCount)
        {
            int curDir = direction % 4;
            switch (curDir)
            {
                case 0: //To Right
                    {
                        for(int i = 0; i < colSteps; i++)
                        {
                            colIndex++;
                            resultList.Add(matrix[rowIndex, colIndex]);
                        }
                        rowSteps--;
                        break;
                    }
                case 1: //To Down
                    {
                        for (int i = 0; i < rowSteps; i++)
                        {
                            rowIndex++;
                            resultList.Add(matrix[rowIndex, colIndex]);
                        }
                        colSteps--;
                        break;
                    }
                case 2: //To Left
                    {
                        for (int i = 0; i < colSteps; i++)
                        {
                            colIndex--;
                            resultList.Add(matrix[rowIndex, colIndex]);
                        }
                        rowSteps--;
                        
                        break;
                    }
                case 3: //To Up
                    {
                        for (int i = 0; i < rowSteps; i++)
                        {
                            rowIndex--;
                            resultList.Add(matrix[rowIndex, colIndex]);
                        }
                        colSteps--;
                        break;
                    }
            }
            direction++;
        }
        return resultList;
    }

    //给定一个 n × n 的二维矩阵表示一个图像 将图像顺时针旋转 90 度。
    //你必须在原地旋转图像，这意味着你需要直接修改输入的二维矩阵
    public void Rotate(int[,] matrix)
    {
        //思路:假如是2x2的矩阵{{1，2}{3，4}}，旋转的过程可以表现为:
        //保存1到临时变量-> 3覆盖1-> 4覆盖3->2覆盖4 临时变量覆盖2
        int size = matrix.GetLength(0);
        int temp = 0;
        int curSqureSize = size;
        int curRow = 0;
        int startCol = 0;
        int right = size - 1;
        int buttom = size - 1;
        while (curSqureSize>1)
        {
            //每次循环的第一个和最后一个是在 同一次旋转的，所以一行只需要循环n-1
            int colCurCount = curSqureSize-1; 
            int offset = 0;
            while (colCurCount>0)
            {
                temp = matrix[curRow, startCol+offset]; //1
                matrix[curRow, startCol+offset] = matrix[buttom-offset, startCol];//3->1
                matrix[buttom - offset, startCol] = matrix[buttom, right-offset];//4->3
                matrix[buttom, right-offset] = matrix[curRow + offset, right]; //2->4
                matrix[curRow + offset, right] = temp;

                colCurCount -= 1;
                offset++;
            }

           
            curRow++;
            startCol++;
            right--;
            buttom--;
            //每一次循环正方形半径小2 （上下左右一圈）
            curSqureSize -= 2;
        }
    }

}
