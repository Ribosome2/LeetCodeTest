using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

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
        ListNode listNode1 = new ListNode(1);
        listNode1.next = new ListNode(2);
        listNode1.next.next = new ListNode(4);

        ListNode listNode2 = new ListNode(1);
        listNode2.next = new ListNode(3);
        listNode2.next.next = new ListNode(4);
        var resultNode = LinkListMerge.MergeTwoLists(listNode1, listNode2);
        Debug.Log(resultNode.ToStr());
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
