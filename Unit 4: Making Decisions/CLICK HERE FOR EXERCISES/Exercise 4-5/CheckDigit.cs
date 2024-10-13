using System;
using static System.Console;
class CheckDigit
{
   static void Main()
   {
      WriteLine("Enter your 4 digit account number: ");
      String accNum = ReadLine();

      int length = accNum.Length;
    
      if (length == 4)
        {
           String first3 = accNum.Substring(0,3);
           int f3Num = Convert.ToInt32(first3);

           String last1 = accNum.Substring(3,1);
           int lastNum = Convert.ToInt32(last1);

           if ((f3Num%7) == lastNum)
              {
                WriteLine("The account number is valid");
              }
            else if ((f3Num%7) != lastNum)
              {
                WriteLine("Invalid");
              }
        }
      
      if (length != 4)
              {
                WriteLine("Account number invalid - it must have 4 digits");  
              } 
   }
}

