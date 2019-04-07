﻿namespace TestInConsoleApp
{
    public class Array_FlipAndInvertImage
    {
//        给定一个二进制矩阵 A，我们想先水平翻转图像，然后反转图像并返回结果。
//        水平翻转图片就是将图片的每一行都进行翻转，即逆序。例如，水平翻转[1, 1, 0] 的结果是[0, 1, 1]。
//        反转图片的意思是图片中的 0 全部被 1 替换， 1 全部被 0 替换。例如，反转[0, 1, 1] 的结果是[1, 0, 0]。
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                int[] arr = A[i];
                var halfWidth = arr.Length/2;
                for (int j = 0; j  < halfWidth; j++)
                {
                    int temp = arr[j];
                    int invertIndex = arr.Length-1 - j;
                    arr[j]=arr[invertIndex];
                    arr[invertIndex] = temp;
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                int[] arr = A[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] ^= 1;
                }
            }

            return A;
        }
    }
}