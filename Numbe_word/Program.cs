using System;
namespace Numbe_word;
        public class Program
        {
            public static void Main(string[] args)
            {
                //Console.WriteLine("Hello World");
                // Write your logic here
                int number=int.Parse(Console.ReadLine());
                string [] start={"one","two","three","four","five",
                "six","seven","eight","nine"};

                string [] between={"ten","eleven","twelve","thirteen","fourteen","fivteen",
                "sixteen","seventeen","eighteen","nineteen"};

                string[] end={"twenty","thirty","fourty","fifty","seventy",
                "eighty","ninety"};
                if(number>=1 && number<=9)
                {
                    Console.Write(start[number-1]);
                }
                else if(number>=10 && number<=19)
                {
                    Console.Write(between[number-10]);
                }
                else if(number>=20 && number<=99)
                {
                    int digit1=number/10;
                    int digits=number%10;
                    if(digits>0)
                    {
                        Console.Write(end[digit1-2]+" "+start[digits-1]);
                    }
                    else{
                        Console.Write(end[digit1-1]);
                    }
                }
            }
        }
            