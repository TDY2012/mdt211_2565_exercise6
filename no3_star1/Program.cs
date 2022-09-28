using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        for(int i=0; i<n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(num);

        for(int i=0; i<n; i++)
        {
            Console.WriteLine(num[i]);
        }
    }
}