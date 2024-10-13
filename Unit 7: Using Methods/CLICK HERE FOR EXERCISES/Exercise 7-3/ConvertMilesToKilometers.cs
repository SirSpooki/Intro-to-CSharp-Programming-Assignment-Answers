using System;
using static System.Console;
class ConvertMilesToKilometers
{
   static void Main()
   {
     WriteLine("Enter number of miles >>");
     int miles = Convert.ToInt32(ReadLine());

     ConvertToKilometers(miles);
   }
   public static double ConvertToKilometers(double miles)
   {
     double kilometers;

     kilometers = (double)miles*1.60934;
     WriteLine($"{miles} to kilometers is {kilometers}");
     return kilometers;
   }
}
