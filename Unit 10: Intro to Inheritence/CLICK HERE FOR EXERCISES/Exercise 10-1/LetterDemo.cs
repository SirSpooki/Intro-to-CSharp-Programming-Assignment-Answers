using static System.Console;
class LetterDemo
{
   static void Main()
   {
      Letter L1 = new Letter();
       L1.Name = "Electric Company";
       L1.Date = "02/14/18";
       WriteLine(L1.ToString());

      CertifiedLetter CL1 = new CertifiedLetter();
       CL1.Name = "SlayTeam LLC";
       CL1.Date = "4/20/6969";
       CL1.TrackingNumber = "69420";
       WriteLine(CL1.ToString());
   }
}

class Letter
{
  public string Name{get; set;}
  public string Date{get; set;}

  public override string ToString()
  {
    return(GetType()+" : " + Name + " : "+ Date);
  }
}
class CertifiedLetter : Letter
{
  public string TrackingNumber{get; set;}
}
