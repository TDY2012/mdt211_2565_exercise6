using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string result = "";
        while(n > 0)
        {
            result = Console.ReadLine() + "\n" + result;
            n--;
        }
        Console.Write(result);
    }
}