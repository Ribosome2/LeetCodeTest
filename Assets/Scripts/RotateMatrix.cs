using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMatrix {
    /// <summary>
    /// 按顺时针遍历矩阵，返回一个列表
    /// </summary>
    /// <param name="matirx"></param>
    /// <returns></returns>
    public static List<int> Rotate(int[,] matirx)
    {
        List<int> resultList = new List<int>();
        int rowCount = matirx.GetLength(0);
        int colCount = matirx.GetLength(1);
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
                            resultList.Add(matirx[rowIndex, colIndex]);
                        }
                        rowSteps--;
                        break;
                    }
                case 1: //To Down
                    {
                        for (int i = 0; i < rowSteps; i++)
                        {
                            rowIndex++;
                            resultList.Add(matirx[rowIndex, colIndex]);
                        }
                        colSteps--;
                        break;
                    }
                case 2: //To Left
                    {
                        for (int i = 0; i < colSteps; i++)
                        {
                            colIndex--;
                            resultList.Add(matirx[rowIndex, colIndex]);
                        }
                        rowSteps--;
                        
                        break;
                    }
                case 3: //To Up
                    {
                        for (int i = 0; i < rowSteps; i++)
                        {
                            rowIndex--;
                            resultList.Add(matirx[rowIndex, colIndex]);
                        }
                        colSteps--;
                        break;
                    }
            }
            direction++;
        }
        return resultList;
    }
	
}
