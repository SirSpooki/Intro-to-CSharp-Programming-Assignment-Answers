using System;
using static System.Console;
using System.Globalization;

class JobDemo2
{
   static void Main()
   {
      Job[] jobs = new Job[5];
      int x, y;
      double grandTotal = 0;
      bool goodNum;
      for(x = 0 ; x < jobs.Length; ++x)
      {
         jobs[x] = new Job();
         Write("Enter job number ");
         jobs[x].JobNumber = Convert.ToInt32(ReadLine());
         goodNum = true;
         for(y = 0; y < x; ++y)
         {
            if(jobs[x].Equals(jobs[y]))
               goodNum = false;
         }
         while(!goodNum)
         {
             Write("Sorry, the job number " +
                jobs[x].JobNumber + " is a duplicate. " +
                "\nPlease reenter ");
             jobs[x].JobNumber = Convert.ToInt32(ReadLine());
             goodNum = true;
             for(y = 0; y < x; ++y)
             {
                if(jobs[x].Equals(jobs[y]))
                   goodNum = false;
             }
         }
         Write("Enter customer name ");
         jobs[x].Customer = ReadLine();
         Write("Enter description ");
         jobs[x].Description = ReadLine();
         Write("Enter estimated hours ");
         jobs[x].Hours = Convert.ToDouble(ReadLine());
      }
      WriteLine("\nSummary:\n");
      for(x = 0; x < jobs.Length; ++x)
      {
         WriteLine(jobs[x].ToString());
         grandTotal += jobs[x].Price;
      }
      WriteLine("\nTotal for all jobs is " + grandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }
 
}   
class Job
{
   protected double hours;
   protected double price;
   public const double RATE = 45.00;
   public Job()
   {
   } 
   public Job(int num, string cust, string desc, double hrs)
   {
      JobNumber = num;
      Customer = cust;
      Description = desc;
      Hours = hrs;
   }
   public int JobNumber {get; set;}
   public string Customer {get; set;}
   public string Description {get; set;}
   public double Hours
   {
      get
      {
         return hours;
      }
      set
      {
         hours = value;
         price = hours * RATE;
      }
   }
   public double Price
   {
       get
       {
          return price;
       }
  }
   public override string ToString()
   {
      return(GetType() + " " + JobNumber + " " + Customer + " " +
         Description + " " + Hours + " hours @" + RATE.ToString("C", CultureInfo.GetCultureInfo("en-US")) +
         " per hour. Total price is " + Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }
   public override bool Equals(Object e)
   {
      bool equal;
      Job temp = (Job)e;
      if(JobNumber == temp.JobNumber)
        equal = true;
      else
        equal = false;
      return equal;
   }
   public override int GetHashCode()
   {
      return JobNumber;
   }
}
