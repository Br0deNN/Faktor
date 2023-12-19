using System;
class Program
{
    static void Main(string[] args)
    {
        string x = Console.ReadLine();
        string[] x2 = x.Split(' ');
        

        int a = int.Parse(x2[0]);
        int b = int.Parse(x2[1]);

        int sum = (a * (b - 1));
        Console.WriteLine(sum + 1);

    }
}