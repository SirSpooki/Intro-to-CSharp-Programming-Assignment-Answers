using System;
using static System.Console;
class CheckMonth
{
   static void Main()
   {
      WriteLine("Enter Birth Month: ");
      int month = Convert.ToInt32(ReadLine());

      if((month > 12) || (month < 1))
          {
            WriteLine("Invalid month");
          }
      else if ((month <= 12) || (month >= 1))
          {
            WriteLine(month + " is a valid month");
          }
   }
}
