using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] map = new int[n];
        for(int i=0; i<n; i++)
        {
            map[i] = int.Parse(Console.ReadLine()) - 1;
        }

        int current = int.Parse(Console.ReadLine());
        current--;
        int t = int.Parse(Console.ReadLine());
        while(t > 0)
        {
            current = map[current];
            t--;
        }

        Console.WriteLine(current + 1);
    }
}