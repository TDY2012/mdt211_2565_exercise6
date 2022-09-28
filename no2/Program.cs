using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        bool[] electricity = new bool[n];
        int[] internet = new int[m];

        for(int i=0; i<n; i++)
        {
            electricity[i] = bool.Parse(Console.ReadLine());
        }
        for(int i=0; i<m; i++)
        {
            internet[i] = int.Parse(Console.ReadLine());
        }

        int computerNo = int.Parse(Console.ReadLine());
        computerNo--;
        if(electricity[computerNo % n])
        {
            Console.WriteLine("{0} Mbps", internet[computerNo / n]);
        }
        else
        {
            Console.WriteLine("Offline");
        }
    }
}