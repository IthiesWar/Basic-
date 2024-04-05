using System;
namespace SwitchCase;
class Program{
    public static void Main(string[] args)
    { Console.WriteLine("Enter the Option'+', '-', '*', '/', '%'");
        char option=char.Parse(Console.ReadLine());
        float Number1=int.Parse(Console.ReadLine());
        float Number2=int.Parse(Console.ReadLine());
       
        switch(option)
        {
            case '+':
            {
                Console.WriteLine(Number1+Number2);
                break;
            }
            case '-':
            {
                Console.WriteLine(Number1-Number2);
                break;

            }
            case '*':
            {
                Console.WriteLine(Number1*Number2);
                break;
            }
            case '/':
            {
                Console.WriteLine(Number1/Number2);
                break;
            }
            case '%':
            {
                Console.WriteLine(Number1%Number2);
                break;
            }
            default :
            {
                Console.WriteLine("Invalid Option");
             break;
            }

        }
    }
}