using System;
using static System.Console;
class Hurricane
{
   static void Main()
   {

      WriteLine("Enter Wind Speeds: ");
      int wind = Convert.ToInt32(ReadLine());

      if (wind >= 157)
        {
          WriteLine(" This is a category 5 hurricane");
        }
      else if ((157 > wind) && (wind >= 130))
        {
          WriteLine(" This is a category 4 hurricane");
        }
      
      else if ((130 > wind) && (111 <= wind))
        {
          WriteLine(" This is a category 3 hurricane");
        }
      
      else if ((111 > wind) && (wind >= 96))
        {
          WriteLine(" This is a category 2 hurricane");
        }
      
      else if ((96 > wind) && (wind >= 74))
        {
          WriteLine(" This is a category 1 hurricane");
        }
      
      else if (wind < 74)
      {
        WriteLine("This is not a hurricane");
      }
   }
}
