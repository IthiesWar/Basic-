using System;
namespace DatetimeProgram;
class Program{
    public static void Main(string[] args)
    {
  //first program
      DateTime date=new DateTime(2021,8,10,10,40,32);
       Console.WriteLine(date.ToString("yyyy/MM/dd hh:mm:ss tt"));
//2 program

        DateTime input2;
        
        string format="yyyy-MM-dd HH:mm";
        bool option=false;
        do{
        string input=Console.ReadLine();
        if(DateTime.TryParseExact(input,format,null,System.Globalization.DateTimeStyles.None,out input2))
        {
            string output=input2.ToString("tt ss mm HH dd MM yyyy");
            Console.WriteLine(output);
            break;
            
        }
        else
        {
            Console.WriteLine("invalid");
            option =true;
            Console.WriteLine("Enter correct date");
            
        }
        }while(option);
//3 program
        DateTime date1=new DateTime(2000,12,01,12,00,0);
        string formatdate1=date1.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine(date1);
        Console.WriteLine(date1.Day);
        Console.WriteLine(date1.Month);
        Console.WriteLine(date1.Year);
        

    }
}
