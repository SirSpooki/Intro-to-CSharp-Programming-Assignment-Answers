using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
   static void Main()
   {
     WriteLine("Enter number of contestants this year: ");
     int contCurrYear = Convert.ToInt32(ReadLine());
     WriteLine("Enter number of contestants last year: ");
     int contLastYear = Convert.ToInt32(ReadLine());

     double Profit = contLastYear * 25;
     int twice = contCurrYear *2;
     WriteLine("Revenue: {0}", Profit.ToString("C", CultureInfo.GetCultureInfo("en-US")));

     if (twice < contLastYear)
      {
        WriteLine("The competition is more than twice as big this year!");
      }
     if (contCurrYear < contLastYear)
      {
        WriteLine("The competition is bigger than ever!");
      }
     if (contCurrYear > contLastYear)
      {
        WriteLine("A tighter race this year! Come out and cast your vote!");
      }
   }
}
