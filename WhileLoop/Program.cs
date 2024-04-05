using System;
namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {
       // int Number=int.Parse(Console.ReadLine());
       int i=0;
       while(i<25)
       {
        if(i%2!=0)
        Console.WriteLine(i);
        i++;
       }
        Console.Write("Enter the Number:");
       bool Number=int.TryParse(Console.ReadLine(),out int output);
       while(!Number)
       {
            Console.WriteLine("Invalid number Enter again:");
            Number=int.TryParse(Console.ReadLine(),out output);
       }
       Console.WriteLine(Number);
    }
}