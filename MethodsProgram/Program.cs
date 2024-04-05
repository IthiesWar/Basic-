using System;
using System.ComponentModel;
using System.Xml.XPath;
namespace MethodsProgram;
class Program{
    
    public static void Main(string[] args)
    {   
      // int number1;
       // int number2;
       //int option;

        string option1=string.Empty;
        bool value=false;
        do{
           
            Console.WriteLine("enter the numbersL");
            int option;
             int number1=int.Parse(Console.ReadLine());
             int number2=int.Parse(Console.ReadLine());
          
          //  int option;
            option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                Console.WriteLine(Addition(number1,number2));
                break;
                case 2:
                Console.WriteLine(Sub(number1,number2));
                break;
                case 3:
                Console.WriteLine(Mul(number1,number2));
                break;
                case 4:
                Console.WriteLine(Div(number1,number2));
                break;

            }
            Console.WriteLine("Do you want to conditinue:");
            option1=Console.ReadLine();
            do
            {
                
                if(option1!="yes" && option1!="no")
                {
                    Console.WriteLine("Give Correct format");
                    value=true;
                    option1=Console.ReadLine();
                }
                
                else if(option1=="no")
                {
                    break;
                }
            }while(value);
        }while(option1=="yes");
        static int Addition(int number1,int number2)
        {
            return number1+number2;
        }
        static int Sub(int number1 ,int number2)
        {
            return number1-number2;
        }
        static int Mul(int number1,int number2)
        {
            return number1*number2;
        }
        static double Div(int number1,int number2)
        {
            return number1/number2;
        }
    }
}