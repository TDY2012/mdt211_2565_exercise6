using System;
using System.Collections.Generic;

class Program
{
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

        IEnumerable<int> union = arr1.Union(arr2);

        foreach(int num in union)
        {
            Console.WriteLine(num);
        }
    }
}