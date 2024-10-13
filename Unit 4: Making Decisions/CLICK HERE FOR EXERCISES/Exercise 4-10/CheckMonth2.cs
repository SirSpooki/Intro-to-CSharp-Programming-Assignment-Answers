using System;
using static System.Console;
class CheckMonth2
{
   static void Main()
   {
     WriteLine("Enter Birth Month: ");
     int month = Convert.ToInt32(ReadLine());
     WriteLine("Enter Birth Day: ");
     int day = Convert.ToInt32(ReadLine());

     if ((month > 12) || (month < 1))
        {
            WriteLine("Invalid date");
        }
     else if ((month == 2) && ((day > 29) || (day < 1)))
        {  
            WriteLine("Invalid date");
        }
    else if ((month == 2) && ((day <= 29) || (day >= 1)))
        {  
            WriteLine(month+"/"+day+" is a valid birthday");
        }

    if (((month <= 12) && (month > 2)) || (month == 1))
    {
      if (month == 11)
        {
            if (day>30)
          {
            WriteLine("Invalid date");
          }
        }
        else if (((day > 31) || (day < 1)))
            {
              WriteLine("Invalid date");
            }
        else if (((day <= 31) || (day >= 1)))
        {
          WriteLine(month+"/"+day+" is a valid birthday");
        }
    }

        



     /*if month ((month < 12) || (month > 1))
        {
          else if ((month < 12)(month > 2))
        }*/



   }
}
