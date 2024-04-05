using System;
namespace TypeConversion;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name:");
        string Name=Console.ReadLine();
        Console.Write("Enter your age:");
        int Age=int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject1:");
        int Mark1=int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2:");
        int Mark2=int.Parse(Console.ReadLine());
        Console.Write("Enter the mark of subject3:");
        int Mark3=int.Parse(Console.ReadLine());
        Console.Write("Enter Grade:");
        char Grade=char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number:");
        long Mobile=long.Parse(Console.ReadLine());
        Console.Write("Enter the mail id:");
        string mail=Console.ReadLine();

        double total= Mark1+Mark2+Mark3;
        double average=total/3.0f;
        //Printing
        Console.WriteLine("Trainee Detaile Are");
        Console.WriteLine("Name:"+Name);
        Console.WriteLine("Age:"+Age);
        Console.WriteLine("Mobile:"+Mobile);
        Console.WriteLine("Marks1:"+Mark1);
        Console.WriteLine("Marks2:"+Mark2);
        Console.WriteLine("Marks3:"+Mark3);
        Console.WriteLine("Average:"+average);
        Console.WriteLine("Grade:"+Grade);
        Console.WriteLine("Mail id:"+mail);

        Console.WriteLine($"Name:{Name}");

    }
}