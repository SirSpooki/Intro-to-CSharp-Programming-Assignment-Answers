using System;
using static System.Console;
class Hurricane
{
   static void Main()
   {    
      WriteLine("Enter Wind Speeds: ");
      int wind = Convert.ToInt32(ReadLine());

      int w = GetCategory(wind);
      if(w > 0)
        {
          WriteLine("Category" + w);
        }
      else
        {
          WriteLine("Not a hurricane");
        }
      
   }
    public static int GetCategory(int wind)
   {
     int num = 0;
     if (wind >= 157)
        {
          num = 5;
        }
      else if ((157 > wind) && (wind >= 130))
        {
          num = 4;
        }
      
      else if ((130 > wind) && (111 <= wind))
        {
          num = 3;
        }
      
      else if ((111 > wind) && (wind >= 96))
        {
          num = 2;
        }
      
      else if ((96 > wind) && (wind >= 74))
        {
          num = 1;
        }
      else 
        {
          num = 0;
        }
        return num;
   }
}
