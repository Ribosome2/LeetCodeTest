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
       ListNode listNode=new ListNode(1);
        var node2=listNode.next=new ListNode(2);
        var node3=listNode.next.next=new ListNode(3);
        var node4=listNode.next.next.next=new ListNode(4);
        var node5= listNode.next.next.next.next = new ListNode(5);
//        node5.next = node2;
        Debug.Log(ArraySearchInsert.SearchInsert(new int[]{1,3,5,6},0 ));
       
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
