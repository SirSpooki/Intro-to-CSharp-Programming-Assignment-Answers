using System;
using static System.Console;
class Admission
{
   static void Main()
   {
      WriteLine("Enter Your Highschool GPA: ");
      double gpa = Convert.ToDouble(ReadLine());
      WriteLine("Enter Your Highschool GPA: ");
      int admission = Convert.ToInt32(ReadLine());


      if ((gpa >= 3.0 && admission >= 60) || (gpa <= 3.0 && admission >= 80))
      {
        WriteLine("Accepted");
      }
      else
      {
        WriteLine("Reject");
      }
   }
}
