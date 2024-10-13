//These namespaces are provided by the .NET Framework
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//This namespace is created by the application
namespace Debugging
{
public class DebugFour4 //C# class
{
static void Main() //Main() method
{
//declaring variables
double sales = 0, commission = 0;
string inputString;
const int LOWSALES = 1000;
const int MEDSALES = 5000;
const int HIGHSALES = 10000;
const double LOWPCT = 0.05;
const double MEDPCT = 0.07;
const int BONUS1 = 1000;
const int BONUS2 = 1500;
//This line prompt for the sales amount
Console.WriteLine("What was the sales amount? ");
inputString = Console.ReadLine();
sales = Convert.ToDouble(inputString);

if (sales <= LOWSALES)
  commission = (LOWSALES * LOWPCT);
    else if (sales > LOWSALES && sales <= MEDSALES)
      commission = (LOWSALES * LOWPCT) + (sales - LOWSALES) * MEDPCT;

    else if (sales <= HIGHSALES)
      commission = (LOWSALES * LOWPCT) + (sales - LOWSALES) * MEDPCT + BONUS1;
    else if (sales > HIGHSALES)
      commission = (LOWSALES * LOWPCT) + (sales - LOWSALES) * MEDPCT + BONUS2 +BONUS1;
Console.WriteLine("Sales: {0}\nCommission: {1}", sales.ToString("C"), commission.ToString("C"));

}
}

}
