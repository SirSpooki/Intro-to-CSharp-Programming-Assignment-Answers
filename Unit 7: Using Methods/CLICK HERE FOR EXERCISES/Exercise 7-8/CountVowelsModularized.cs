using System;
using static System.Console;
class CountVowelsModularized
{
   public static void Main()
   {
     CountVowels("bruh");
   }
   public static int CountVowels(string x)
   {
     int vowelCount = 0;
     char checkLetter = '\0';
     for (int i = 0; i < x.Length; ++i)
            {
                checkLetter = char.ToUpper(x[i]);
                switch(checkLetter)
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        vowelCount++;
                        break;
                }
            }
            WriteLine("Vowels :" + vowelCount);
            return vowelCount;
   }
}
