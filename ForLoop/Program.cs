using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {
        int sum=0;
        int total=0;
        Console.Write("Enter the Initilizer:");
        int initializer=int.Parse(Console.ReadLine());
        Console.Write("Enter the End:");
        int End=int.Parse(Console.ReadLine());
        for(int i=initializer+1;i<End;i++)
        {
           sum=i*i;
           total+=sum;
        }
        Console.WriteLine(total);
    }
}