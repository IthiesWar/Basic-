using System;

namespace DoWhile;
class Program{
    public static void Main(string[] args)
    {
   string option=string.Empty;
      bool value=false;
        do
        {
           Console.Write("Enter the number :");
           int  Number1=int.Parse(Console.ReadLine());
            if(Number1%2==0)
            {
                Console.Write("odd number");
            }
            else{
                Console.Write("even number");
            }
             Console.WriteLine("Do want to continue with another number");
            option=Console.ReadLine();
            do{
            if(option!="yes" && option!="no")
            {
                value=true;
                Console.WriteLine("Give correct sentence");
                option=Console.ReadLine();
            }
            }while(value);
            if(option=="no")
            {
                break;
            }
        } while (option=="yes");

    }
}