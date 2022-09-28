using System;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }

    static void BubbleSort(ref int[] arr)
    {
        for(int i=0; i<arr.Length; i++)
        {
            for(int j=0; j<arr.Length-i-1; j++)
            {
                if(arr[j] > arr[j+1])
                {
                    Swap(ref arr[j], ref arr[j+1]);
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        for(int i=0; i<n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }

        BubbleSort(ref num);

        for(int i=0; i<n; i++)
        {
            Console.WriteLine(num[i]);
        }
    }
}