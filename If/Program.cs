using System;
namespace If;
class Program{
    public static void Main(string[] args)
    {
        int Mark=int.Parse(Console.ReadLine());
        if(Mark>=0 && Mark<=100)
        {
         if(80<=Mark)
        {
            Console.WriteLine("Grade A");
        }
        else if (Mark>=60 && Mark <80)
        {
            Console.WriteLine("Grade B");
        }
        else if(Mark>=36 && Mark<60 )
        {
            Console.WriteLine("Grade C");
        }
        else if(Mark <36 && Mark>0)
        {
            Console.WriteLine("Grade D");
        }
        else {
            Console.WriteLine("Invalid");
        }
        }
        else{
            Console.WriteLine("Invalid Input");
        }
    }
    }
    

