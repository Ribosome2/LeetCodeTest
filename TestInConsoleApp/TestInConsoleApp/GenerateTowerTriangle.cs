using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class GenerateTowerTriangle
    {
        //给定一个非负整数 numRows，生成杨辉三角的前 numRows 行。
        //在杨辉三角中，每个数是它左上方和右上方的数的和。
        public List<List<int>> Generate(int numRows)
        {
            List<List<int>> reList=new List<List<int>>();
            if (numRows >0)
            {
                reList.Add( new List<int>(){1});
                for (int row = 1; row < numRows; row++)
                {
                    List<int> list=new List<int>();
                    List<int> preList = reList[row - 1];
                    for (int j = 0; j < row + 1; j++)
                    {
                        int num = 0;
                        if ((j-1) >= 0 &&  (j-1)<preList.Count)
                        {
                            num += reList[row - 1][j - 1];
                        }
                        if (j  >= 0 && j < preList.Count)
                        {
                            num += reList[row - 1][j];
                        }
                        list.Add(num);
                    }
                    reList.Add(list);
                }
            }

            return reList;
        }
    }
}