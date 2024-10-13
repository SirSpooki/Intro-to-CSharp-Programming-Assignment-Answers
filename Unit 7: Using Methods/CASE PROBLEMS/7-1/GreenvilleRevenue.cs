using System;

using static System.Console;

using System.Globalization;

class GreenvilleRevenue

{

  static void Main()

  {

    const int ENTRANCE_FEE = 25;

    const int MIN_CONTESTANTS = 0;

    const int MAX_CONTESTANTS = 30;

    int numThisYear;

    int numLastYear;

    int revenue;

    string[] names = new string[MAX_CONTESTANTS];

    char[] talents = new char[MAX_CONTESTANTS];

    char[] talentCodes = { 'S', 'D', 'M', 'O' };

    string[] talentCodesStrings
        = { "Singing", "Dancing", "Musical instrument", "Other" };

    int[] counts = { 0, 0, 0, 0 };
    ;

    numLastYear = GetContestantNumber("last", MIN_CONTESTANTS, MAX_CONTESTANTS);

    numThisYear = GetContestantNumber("this", MIN_CONTESTANTS, MAX_CONTESTANTS);

    revenue = numThisYear * ENTRANCE_FEE;

    Console.WriteLine(
        "Last year's competition had {0} contestants, and this year's has {1} contestants",

        numLastYear, numThisYear);

    Console.WriteLine(
        "Revenue expected this year is {0}", revenue.ToString("C"));

    DisplayRelationship(numThisYear, numLastYear);

    GetContestantData(
        numThisYear, names, talents, talentCodes, talentCodesStrings, counts);

    GetLists(
        numThisYear, talentCodes, talentCodesStrings, names, talents, counts);
  }

  // This method gets and returns a valid number of contestants and is called
  // twice once

  // for last year’s number of contestants and once for this year’s value

  public static int GetContestantNumber(string when, int min, int max)

  {

    // string entryString = string.Empty;

    int num = 0;

    Console.Write("Enter number of contestants {0} year >> ", when);

    GetContestantNum(ref num);

    while (num < min || num > max)

    {

      Console.WriteLine("Number must be between {0} and {1}", min, max);

      Console.Write("Enter number of contestants {0} year >> ", when);

      GetContestantNum(ref num);
    }

    return num;
  }

  // This method accepts the number of contestants this year and last year and
  // displays

  // one of the three messages that describes the relationship between the two
  // contestant values

  public static void DisplayRelationship(int numThisYear, int numLastYear)

  {

    if (numThisYear > 2 * numLastYear)

      Console.WriteLine("The competition is more than twice as big this year!");

    else

        if (numThisYear > numLastYear)

      Console.WriteLine("The competition is bigger than ever!");

    else

        if (numThisYear < numLastYear)

      Console.WriteLine(
          "A tighter race this year! Come out and cast your vote!");
  }

  // This method fills the array of competitors and their talent codes

  public static void GetContestantData(int numThisYear, string[] names,
      char[] talents, char[] talentCodes, string[] talentCodesStrings,
      int[] counts)

  {

    int x = 0;

    bool isValid;

    while (x < numThisYear)

    {

      Console.Write("Enter contestant name >> ");

      names[x] = Console.ReadLine();

      Console.WriteLine("Talent codes are:");

      for (int y = 0; y < talentCodes.Length; ++y)

        Console.WriteLine(" {0} {1}", talentCodes[y], talentCodesStrings[y]);

      Console.Write(" Enter talent code >> ");

      talents [x]
      = GetChar();

      isValid = false;

      while (!isValid)

      {

        for (int z = 0; z < talentCodes.Length; ++z)

        {

          if (talents[x] == talentCodes[z])

          {

            isValid = true;

            ++counts[z];
          }
        }

        if (!isValid)

        {

          Console.WriteLine("{0} is not a valid code", talents[x]);

          Console.Write(" Enter talent code >> ");

          talents [x]
          = GetChar();
        }
      }

      ++x;
    }
  }

  // This method continuously prompts for talent codes

  // and displays contestants with the corresponding talent until a sentinel
  // value is entered

  public static void GetLists(int numThisYear, char[] talentCodes,
      string[] talentCodesStrings, string[] names, char[] talents, int[] counts)

  {

    int x;

    char QUIT = 'Z';

    char option;

    bool isValid;

    int pos = 0;

    bool found;

    Console.WriteLine("\nThe types of talent are:");

    for (x = 0; x < counts.Length; ++x)

      Console.WriteLine("{0, -20} {1, 5}", talentCodesStrings[x], counts[x]);

    Console.Write("\nEnter a talent type or {0} to quit >> ", QUIT);

    option = GetChar();

    while (option != QUIT)

    {

      isValid = false;

      for (int z = 0; z < talentCodes.Length; ++z)

      {

        if (option == talentCodes[z])

        {

          isValid = true;

          pos = z;
        }
      }

      if (!isValid)

        Console.WriteLine("{0} is not a valid code", option);

      else

      {

        Console.WriteLine(
            "\nContestants with talent {0} are:", talentCodesStrings[pos]);

        found = false;

        for (x = 0; x < numThisYear; ++x)

        {

          if (talents[x] == option)

          {

            Console.WriteLine(names[x]);

            found = true;
          }
        }

        if (!found)

          Console.WriteLine(
              "No contestants had talent {0}", talentCodesStrings[pos]);
      }

      Console.Write("\nEnter a talent type or {0} to quit >> ", QUIT);

      option = GetChar();
    }
  }

#region Helper Private Methods

  // Tryparse is used for checking the valid number datatype

  private static void GetContestantNum(ref int num)

  {

    string entryString = string.Empty;

    bool isValidNumber = false;

    while (!isValidNumber)

    {

      entryString = Console.ReadLine();

      isValidNumber = int.TryParse(entryString, out num);

      if (!isValidNumber)

      {

        Console.WriteLine("Invalid number: {0} Please try again!", entryString);
      }
    }
  }

  // Tryparse used for checking the character datatype

  private static char GetChar()

  {

    char validChar = '0';

    bool isValidChar = false;

    var charInput = string.Empty;

    while (!isValidChar)

    {

      charInput = Console.ReadLine();

      isValidChar = Char.TryParse(charInput, out validChar);

      if (!isValidChar)

      {

        Console.WriteLine(
            "Invalid character - Please try again by entering one character!");
      }
    }

    return validChar;
  }

#endregion
}
