using static System.Console;
class Twitter
{
   static void Main()
   {
     string userM;
     WriteLine("Enter Your Message: ");
     userM = ReadLine();

     int length = userM.Length;
     
     if (length > 140)
      {
        WriteLine("The message is too long");
      }
     else
      {
        WriteLine(" The message is okay");
      }
     
   }
}
