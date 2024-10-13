using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using System.IO;

namespace GreenvilleRevenueApp
{
class TeenContestant : Contestant
{
public int TEEN_FEE = 20;
public TeenContestant()
{
Fee = TEEN_FEE;
}
public override string ToString()
{
return ("Teen Contestant " + Name + " " + TalentCode + " Fee " + Fee.ToString("C"));
}
}
}

/*
* File Name: GreenvilleRevenue.cs
* NameSpace: GreenvilleRevenueApp
*/

namespace GreenvilleRevenueApp
{

class GreenvilleRevenue
{
static void Main()
{
const int MIN_CONTESTANTS = 0;
const int MAX_CONTESTANTS = 30;
int num;
int revenue = 0;
const char QUIT = 'Z';
char option = ' ';
Contestant[] contestants = new Contestant[MAX_CONTESTANTS];

num = getContestantNumber(MIN_CONTESTANTS, MAX_CONTESTANTS);
int[] loadRes = loadContestants(num, contestants, revenue);
int startPos = loadRes[0];
revenue = loadRes[1];
WriteLine("\n\nRevenue expected this year is {0} after loading data from file", revenue.ToString("C"));

revenue = getContestantData(num, startPos, contestants, revenue);
WriteLine("\n\nRevenue expected this year is {0}", revenue.ToString("C"));
while (option != QUIT)
option = getLists(num, contestants);

saveContestants(num, contestants);
WriteLine("\nEnter any key to continue");
ReadKey();
}
private static int getContestantNumber(int min, int max)
{
string entryString;
int num = max + 1;
Write("\nEnter number of contestants >> ");
entryString = ReadLine();
while (num < min || num > max)
{
if (!int.TryParse(entryString, out num))
{
WriteLine("Format invalid");
num = max + 1;
Write("\nEnter number of contestants >> ");
entryString = ReadLine();
}
else
{
try
{
if (num < min || num > max)
throw (new ArgumentException());
}
catch (ArgumentException e)
{
WriteLine(e.Message);
WriteLine("Number must be between {0} and {1}", min, max);
num = max + 1;
Write("\nEnter number of contestants >> ");
entryString = ReadLine();
}
}
}
return num;
}
private static int getContestantData(int num, int startPos, Contestant[] contestants, int revenue)
{
const int ADULTAGE = 17;
const int TEENAGE = 12;
int x = startPos;
string name;
char talent;
int age;
int pos;
while (x < num)
{
Write("\nEnter contestant name >> ");
name = ReadLine();
WriteLine("Talent codes are:");
for (int y = 0; y < Contestant.talentCodes.Length; ++y)
WriteLine(" {0} {1}", Contestant.talentCodes[y], Contestant.talentStrings[y]);
Write(" Enter talent code >> ");
char.TryParse(ReadLine(), out talent);
try
{
validateCode(talent, out pos);
}
catch (ArgumentException e)
{
WriteLine(e.Message);
WriteLine("{0} is not a valid code. Assigned as Invalid.", talent);
}
Write(" Enter contestant's age >> ");
int.TryParse(ReadLine(), out age);
if (age > ADULTAGE)
contestants[x] = new AdultContestant();
else if (age > TEENAGE)
contestants[x] = new TeenContestant();
else
contestants[x] = new ChildContestant();
contestants[x].Name = name;
contestants[x].TalentCode = talent;
revenue += contestants[x].Fee;
++x;
}
return revenue;
}
private static char getLists(int num, Contestant[] contestants)
{
int x;
char QUIT = 'Z';
char option = ' ';
bool isValid;
int pos = 0;
bool found;
WriteLine("\nThe types of talent are:");
for (x = 0; x < Contestant.talentStrings.Length; ++x)
WriteLine("{0, -6}{1, -20}", Contestant.talentCodes[x], Contestant.talentStrings[x]);
Write("\nEnter a talent type or {0} to quit >> ", QUIT);
isValid = false;
while (!isValid)
{
if (!char.TryParse(ReadLine(), out option))
{
isValid = false;

WriteLine("Invalid format - entry must be a single character");
Write("\nEnter a talent type or {0} to quit >> ", QUIT);
}
else
{
if (option == QUIT)
isValid = true;
else
{
try
{
validateCode(option, out pos);
isValid = true;
}
catch (ArgumentException e)
{
WriteLine(e.Message);
WriteLine("{0} is not a valid code", option);
Write("\nEnter a talent type or {0} to quit >> ", QUIT);
isValid = false;
}
}
if (isValid && option != QUIT)
{

WriteLine("\nContestants with talent {0} are:", Contestant.talentStrings[pos]);
found = false;
for (x = 0; x < num; ++x)
{
if (contestants[x].TalentCode == option)
{
WriteLine("\n" + contestants[x].ToString());
found = true;
}
}
if (!found)
{
WriteLine("\n" + "No contestants had talent {0}", Contestant.talentStrings[pos]);
isValid = false;
Write("\nEnter a talent type or {0} to quit >> ", QUIT);
}
}
}
}
return option;
}
public static void validateCode(char option, out int pos)
{
bool isValid = false;
pos = Contestant.talentCodes.Length - 1;
for (int z = 0; z < Contestant.talentCodes.Length; ++z)
{
if (option == Contestant.talentCodes[z])
{
isValid = true;
pos = z;
}
}
if (!isValid)
throw (new ArgumentException());
}

private static int[] loadContestants(int num, Contestant[] contestants, int revenue)
{
int x = 0;
StreamReader sr = null;
int[] res = new int[2];
try
{
sr = new StreamReader("Greenville.ser");
string line = sr.ReadLine();
int pos;
int fee;
string name;
char talent;

while (line != null && x < num)
{
string[] data = line.Trim().Split(',');
if (data.Length == 3)
{
name = data[0];
char.TryParse(data[1], out talent);
try
{
validateCode(talent, out pos);
}
catch (ArgumentException e)
{
WriteLine(e.Message);
WriteLine("{0} is not a valid code. Assigned as Invalid.", talent);
}
int.TryParse(data[2], out fee);
if (fee == 30)
contestants[x] = new AdultContestant();
else if (fee == 30)
{
contestants[x] = new TeenContestant();
}
else
{
contestants[x] = new ChildContestant();
}

contestants[x].Name = name;
contestants[x].TalentCode = talent;
revenue += contestants[x].Fee;
x++;
}
else
{
WriteLine("\nLine: " + line + " has invalid number of fields");
}
line = sr.ReadLine();
}
WriteLine("\nLoaded " + x + " Contestants from file : Greenville.ser");
sr.Close();
}
catch (Exception e)
{
Console.WriteLine("\nError occured while reding file: Greenville.ser"+e);
if (sr != null)
{
sr.Close();
}

}
res[0] = x;
res[1] = revenue;
return res;

}
private static void saveContestants(int num, Contestant[] contestants)
{
StreamWriter sw = null;
try
{
sw = new StreamWriter("Greenville.ser");
for (int i = 0; i <num;i++)
{
sw.WriteLine(String.Format("{0:},{1:},{2:}", contestants[i].Name, contestants[i].TalentCode, contestants[i].Fee));
Console.WriteLine("Writing data: " + String.Format("{0:},{1:},{2:}", contestants[i].Name, contestants[i].TalentCode, contestants[i].Fee));
}
sw.Close();
}
catch (Exception e)
{
Console.WriteLine("\nError occured while writing to file : Greenville.ser \nerror log: " + e.Message);
if (sw != null)
{
sw.Close();
}

}

}
}
}

/*
* File Name: Contestant.cs
* NameSpace: GreenvilleRevenueApp
*/

namespace GreenvilleRevenueApp
{
class Contestant
{
public static char[] talentCodes = { 'S', 'D', 'M', 'O' };
public static string[] talentStrings = {
"Singing",
"Dancing",
"Musical instrument",
"Other"
};
public string Name { get; set; }
private char talentCode;
private string talent;
private int fee;
public char TalentCode
{
get
{
return talentCode;
}
set
{
int pos = talentCodes.Length;
for (int x = 0; x < talentCodes.Length; ++x)
if (value == talentCodes[x])
pos = x;
if (pos == talentCodes.Length)
{
talentCode = 'I';
talent = "Invalid";
}
else
{
talentCode = value;
talent = talentStrings[pos];
}
}

}
public string Talent
{
get
{
return talent;
}
}
public int Fee
{
get
{
return fee;
}
set
{
fee = value;
}
}
}
}


/*
* File Name: ChildContestant.cs
* NameSpace: GreenvilleRevenueApp
*/

namespace GreenvilleRevenueApp
{
class ChildContestant : Contestant
{
public int CHILD_FEE = 15;
public ChildContestant()
{
Fee = CHILD_FEE;
}
public override string ToString()
{
return ("Child Contestant " + Name + " " + TalentCode + " Fee " + Fee.ToString("C"));
}
}
}

/*
* File Name: AdultContestant.cs
* NameSpace: GreenvilleRevenueApp
*/

namespace GreenvilleRevenueApp
{
class AdultContestant : Contestant
{
public int ADULT_FEE = 30;
public AdultContestant()
{
Fee = ADULT_FEE;
}
public override string ToString()
{
return ("Adult Contestant " + Name + " " + TalentCode + " Fee " + Fee.ToString("C"));
}
}
}
