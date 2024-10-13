using System;
using static System.Console;
class RelativesList
{
   static void Main()
   {
      Relative[] relativeArray = new Relative[12];
      int x;
      int m;
      int temp = 0;
      bool test = false;
      for(x = 0; x < relativeArray.Length; ++x)
      {
         relativeArray[x] = new Relative();
         Write("Enter your relative's name ");
         relativeArray[x].Name = ReadLine();
         Write("Enter {0}'s relationship to you ", relativeArray[x].Name);
         relativeArray[x].Relationship = ReadLine();
         Write("Enter your relative's birth month ");
         int.TryParse(ReadLine(), out m);
         relativeArray[x].Month = m;
         Write("Enter your relative's birth day ");
         int.TryParse(ReadLine(), out m);
         relativeArray[x].Day = m;
         Write("Enter your relative's birth year ");
         int.TryParse(ReadLine(), out m);
         relativeArray[x].Year = m;
      }
      Array.Sort(relativeArray);
      WriteLine("\nSorted relatives: ");
      for(x = 0; x < relativeArray.Length; ++x)
      {
         WriteLine("{0,-15}{1,-15}{2}/{3}/{4}",
            relativeArray[x].Name, relativeArray[x].Relationship,
            relativeArray[x].Month, relativeArray[x].Day,
            relativeArray[x].Year);
      }
    WriteLine("Enter Relative Name for Info >> ");
    string user = ReadLine();
    for(x = 0; x < relativeArray.Length; ++x)
    {
      if(user.Equals(relativeArray[x].Name))
        {
          temp = x;
          test = true;
        }
    }
    if(test == true)
      {
      WriteLine($"Birthday for {relativeArray[temp].Name}, your {relativeArray[temp].Relationship}, is {relativeArray[temp].Month}/{relativeArray[temp].Day}/{relativeArray[temp].Year}");
      }
    else
    {
     WriteLine($"Sorry - no match for {user}");
    }
   }

}
class Relative : IComparable
{
   
   public string Name {get; set;}
   public string Relationship {get; set;}
   public int Month {get; set;}
   public int Day {get; set;}
   public int Year {get; set;}
   int IComparable.CompareTo(object o)
   {
      int returnVal;
      Relative temp = (Relative)o;
      returnVal = this.Name.CompareTo(temp.Name); 
      return returnVal;
   }
}
