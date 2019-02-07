using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int[] arr=new [] { 1,2,3,4,5};

    private void OnEnable()
    {
        //var matrix1 = new int[,]
        //{
        //    {1,2,3 },
        //    {8,9,4 },
        //    {7,6,5 },
        //};
        //var matrix2 = new int[,]
        //{
        //    {1, 2,  3,  4 },
        //    {10,11, 12, 5,},
        //    {9, 8,  7 , 6,},
        //};

        //var list = RotateMatrix.Rotate(matrix1);
        //PrintList(list);
        //PrintList(RotateMatrix.Rotate(matrix2));
        arr = new[] { 1, 2, 3, 4, 5 };
        RotateArray.Rotate(arr,2);
       
    }

   

    void PrintList(List<int> list)
    {
        var str = "";
        for(int i=0;i<list.Count;i++)
        {
            str += list[i]+",";
        }
        Debug.Log(str);
           
    }

    
}
