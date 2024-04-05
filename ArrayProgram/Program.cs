using System;
namespace ArrayProgram;
class Program{
public static void Main(string[] args)
{
    int number=int.Parse(Console.ReadLine());
    string[] array=new string[number];
    string search=string.Empty;
    bool value=true;
    int count=0;
    for(int i=0;i<number;i++)
    {
        array[i]=Console.ReadLine();
    }
    Console.WriteLine("Names:");
    for(int i=0;i<number;i++)
    {
        Console.WriteLine(array[i]);
    }
   search=Console.ReadLine();
   
    for(int i=0;i<array.Length;i++)
    {
       if(search==array[i])
       {
        Console.WriteLine("The name is Present in the array");
        value=false;
        count=Array.IndexOf(array,search);
        Console.WriteLine(count);
       }
    }
    if(value)
    {
        Console.WriteLine("The name is not present in the array");
    }
    Console.WriteLine("Enter search name");
    string search2=Console.ReadLine();
    bool value1=true;
    foreach(string i in array)
    {
        if(search2==i)
        {
            value1=false;
            Console.WriteLine(i);
        }
    }
    if(value1)
    {
        Console.WriteLine("The name is not present in the array");
    }
}
    
}
