using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];
        for(int i=0; i<n; i++)
        {
            words[i] = Console.ReadLine();
        }
        for(int i=n-1; i>=0; i--)
        {
            Console.WriteLine(words[i]);
        }
    }
}