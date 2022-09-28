using System;
using System.Collections.Generic;

class Program
{
    static int MoveToNextDifferenceIndex(ref int[] arr, int ptr, int num)
    {
        if(ptr < 0 || ptr >= arr.Length)
        {
            return -1;
        }
        else if(arr[ptr] == num)
        {
            return MoveToNextDifferenceIndex(ref arr, ptr + 1, num);
        }
        else
        {
            return ptr;
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        for(int i=0; i<n; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        int m = int.Parse(Console.ReadLine());
        int[] arr2 = new int[m];
        for(int i=0; i<m; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }

        int[] union = new int[n+m];
        int sameIndex = 0;
        int ptr1 = 0;
        int ptr2 = 0;

        union[sameIndex] = arr1[0];
        while(true)
        {
            ptr1 = MoveToNextDifferenceIndex(ref arr1, ptr1, union[sameIndex]);
            ptr2 = MoveToNextDifferenceIndex(ref arr2, ptr2, union[sameIndex]);

            sameIndex++;
            if(ptr1 == -1 && ptr2 == -1)
            {
                break;
            }
            else if(ptr1 == -1)
            {
                union[sameIndex] = arr2[ptr2];
            }
            else if(ptr2 == -1)
            {
                union[sameIndex] = arr1[ptr1];
            }
            else if(arr1[ptr1] < arr2[ptr2])
            {
                union[sameIndex] = arr1[ptr1];
            }
            else
            {
                union[sameIndex] = arr2[ptr2];
            }
        }

        for(int i=0; i<sameIndex; i++)
        {
            Console.WriteLine(union[i]);
        }
    }
}