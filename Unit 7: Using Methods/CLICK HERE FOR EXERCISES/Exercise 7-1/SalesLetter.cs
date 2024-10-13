using static System.Console;
public class SalesLetter
{
   public static void Main()
    {
      WriteLine("From");
      DisplayContactInfo();
      WriteLine("____________________________");

      WriteLine("Dear Client,");
      WriteLine("We want to provide you good service.");
      WriteLine("Feel free to contact us at any time.");
      DisplayContactInfo();
      WriteLine("     *********");

      WriteLine("Looking forward to a long relationship.");
      DisplayContactInfo();

    }
   public static void DisplayContactInfo()
    {
      WriteLine("C# Company");
      WriteLine("Phone: 555-1234     Cell: 555-0912");
      WriteLine("Email: csharpcompany@csharp.com");
      WriteLine("On the Web at www.csharpcompanyforyou.com");
    }
}
