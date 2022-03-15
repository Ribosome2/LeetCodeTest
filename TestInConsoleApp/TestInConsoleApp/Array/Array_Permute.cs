using System;
using System.Collections;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_Permute
    {
//        给定一个没有重复数字的序列，返回其所有可能的全排列。
        public IList<IList<int>> Permute(int[] nums) {
            List<IList<int>> re=new List<IList<int>>();
            Permutation(nums,0,re);
            return re;
        }
        
        public  void Permutation(int[] nums,int start,List<IList<int>>  list )
        {
            if(start==nums.Length-1)
            {
                var li = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    li.Add(nums[i]);
                }
                list.Add(li);
                //如果已经到了数组的最后一个元素，前面的元素已经排好，输出。
            }
            for(int i=start;i<=nums.Length-1;i++)
            {
                //把第一个元素分别与后面的元素进行交换，递归的调用其子数组进行排序
                Swap(nums,i,start);
                Permutation(nums,start+1,list);
                Swap(nums,i,start);
                //子数组排序返回后要将第一个元素交换回来。  
                //如果不交换回来会出错，比如说第一次1、2交换，第一个位置为2，子数组排序返回后如果不将1、2
                //交换回来第二次交换的时候就会将2、3交换，因此必须将1、2交换使1还是在第一个位置 
            }
        }
        public  void Swap(int[] chs,int i,int j)
        {
            Console.WriteLine("Swap "+chs[i]+"  "+chs[j]);
            var  temp=chs[i];
            chs[i]=chs[j];
            chs[j]=temp;
        }
   
    }
}