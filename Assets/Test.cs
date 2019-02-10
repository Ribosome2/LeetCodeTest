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
        listNode.next=new ListNode(2);
        listNode.next.next=new ListNode(3);
        listNode.next.next.next=new ListNode(4);
        listNode.next.next.next.next=new ListNode(5);
        Debug.Log(ReverseLinkList.ReverseBetween(listNode,1,5).ToStr());
       
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
