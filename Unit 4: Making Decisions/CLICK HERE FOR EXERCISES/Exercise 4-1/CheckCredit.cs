using System;
using static System.Console;
class CheckCredit
{
   static void Main()
   {
      WriteLine("Enter pruchase price");
      int userNum = Convert.ToInt32(ReadLine());

      if (userNum > 8000)
      {
        WriteLine("You have exceeded the credit limit");
      }
      else
      {
        WriteLine("Approved");
      }


   }
}
