using System;
using System.IO;
namespace StringProgram;
class Program{
    public static void Main(string[] args)
    {
        string name=Console.ReadLine();
        string name1=Console.ReadLine();
        int count=0;
        string[] arr=name.Split(name);
        for(int i=0;i<arr.Length;i++)
        {
            count+=name1.Length;
            
        }
        Console.WriteLine(count);
    }
}
