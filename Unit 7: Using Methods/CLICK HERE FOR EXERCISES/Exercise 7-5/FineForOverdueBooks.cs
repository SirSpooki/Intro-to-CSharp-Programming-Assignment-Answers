using System;
using static System.Console;
using System.Globalization;
public class FineForOverdueBooks
{
   public static void Main()
   {
    WriteLine("Enter number of books checked out >>");
     int books = Convert.ToInt32(ReadLine());

     WriteLine("Enter days overdue >>");
     int days = Convert.ToInt32(ReadLine());
     
     DisplayFine(books, days);
   }
   public static void DisplayFine(int books, int days)
      {
          double price = 0;
          int count = 0;
          if(days <= 7)
            {
              for(count = 1; count <= days; ++count)
                {
                  price += books * .10;
                }
            }
          else
            {
              for(count = 1; count <= 7; ++count)
                {
                  price += books * .10;
                }
              int c = 7;
              while(c != days)
                {
                  price += books * .20;
                  c++;
                }
            }
          string Sprice = price.ToString("C", CultureInfo.GetCultureInfo("en-US"));
          WriteLine($"The fine for {books} book(s) for {days} day(s) is {Sprice}");
      }
   }
