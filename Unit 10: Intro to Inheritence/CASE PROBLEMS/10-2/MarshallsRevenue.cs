using System;

// Includes the entire Program

namespace MarshallsRevenue

{

// Class definiton and

// declaration to set

// auto implemented properties

// as well as initialize

// public static array

class Mural

{

public static char[] code_word

= new char[5] { 'L', 'S', 'A', 'C', 'O' };

char code;

// field price for storing the

// price

public double price;

// auto implemented property

// for getting and setting

// customer name

public string Name

{ get; set; }

// auto-implemented property

// for getting and setting

// mural code

public char Code

{

get

{

return this.code;

}

set

{

if (this.code == 'L' | this.code == 'S' |

this.code == 'A' | this.code == 'O' |

this.code == 'C')

this.code = value;

else

this.code = 'I';

}

}

}// Mural class ends

class InteriorMural : Mural

{

public int intnum;

public string name;

public string inmu;

// Method definition to calculate

// total revenue depending on the

// month and hence return it

public double getRevenue(int c)

{

price = 0;

switch (c)

{

case 1:

price = intnum * 500;

Console.WriteLine("$"

+ price + " for interior mural");

break;

case 2:
price = intnum * 500;

Console.WriteLine("$"

+ price + " for interior mural");

break;

case 3:

price = intnum * 500;

Console.WriteLine("$"

+ price + " for interior mural");

break;

case 4:

price = intnum * 500;

Console.WriteLine("$"

+ price + " for interior");

break;

case 5:

price = intnum * 500;

Console.WriteLine("$"

+ price + " for interior mural");

break;

case 6:

price = intnum * 500;

Console.WriteLine("$"

+ price + " for interior mural");

break;

case 7:

price = intnum * 450;

Console.WriteLine("$"

+ price + " for interior");

break;

case 8:

price = intnum * 450;

Console.WriteLine("$"

+ price + " for interior mural");

break;

case 9:

price = intnum * 500;

Console.WriteLine("$"

+ price + " for interior mural");

break;

case 10:

price = intnum * 500;

Console.WriteLine("$"

+ price + " for interior mural");

break;

case 11:

price = intnum * 500;

Console.WriteLine("$"

+ price + " for interior mural");

break;

case 12:

price = intnum * 500;

Console.WriteLine("$"

+ price + " for interior mural");

break;

}

return price;

}

// Method definition to get mural

public void getMural()

{

string str;

Console.WriteLine("Enter no."

+ " of mural");

str = Console.ReadLine();

if (int.TryParse(str, out intnum))

{

intnum = Convert.ToInt32(str);

{

if (intnum > 0 && intnum < 30)

Console.WriteLine("It is a"

+ " valid mural");

}

}

}

public override string ToString()

{

return "Interior Moral "

+ name + " has the code "

+ inmu;

}

}

// InteriorMural class ends

class ExteriorMural : Mural

{

public int extnum;

public string name;

public string exmu;

// Method definition to calculate

// total revenue depending on the

// month and hence return it

public int getRevenue(int c)

{

int bcost = 0;

switch (c)

{

case 1:

bcost = 0;
Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

case 2:

bcost = 0;

Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

case 3:

bcost = extnum * 750;

Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

case 4:

bcost = extnum * 699;

Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

case 5:

bcost = extnum * 699;

Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

case 6:

bcost = extnum * 750;

Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

case 7:

bcost = 0;

Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

case 8:

bcost = extnum * 750;

Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

case 9:

bcost = extnum * 699;

Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

case 10:

bcost = extnum * 699;

Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

case 11:

bcost = extnum * 750;

Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

case 12:

bcost = 0;

Console.WriteLine("$"

+ bcost + " for exterior mural");

break;

}

return bcost;

}

// Method definition to get mural

public void getMural()

{

string str;

Console.WriteLine("Enter no."

+ " of mural");

str = Console.ReadLine();

if (int.TryParse(str, out extnum))

{

extnum = Convert.ToInt32(str);

{

if (extnum > 0 && extnum < 30)

Console.WriteLine("It is a"

+ " valid mural");

}

}

}

public override string ToString()

{

return "Exterior Moral "

+ name + " has the code "

+ exmu; ;

}

}

// ExteriorMural class ends

// Class definiton that

// contains Main

class Program

{

// Global variables

int totrevenue;

public int month;

public int tempo;

// Method definition to let

// user enter month and
// check its validity.

// If found invalid, prompt

// the user to enter until

// valid.

public bool getMonth()

{

string locmonth;

int dummy;

Console.WriteLine("Enter month");

locmonth = Console.ReadLine();

if (int.TryParse(locmonth,

out dummy))

{

dummy = Convert.ToInt32

(locmonth);

if (dummy > 0 & dummy < 13)

{

Console.WriteLine("Valid"

+ " month");

month = dummy;

return true;

}

}

return false;

}

// Main definition starts

static void Main(string[] args)

{

string category;

// object instantiation

Program obj = new Program();

InteriorMural interM = new InteriorMural();

ExteriorMural exterM = new ExteriorMural();

// Loop being run until

// valid month is obtained

while (!obj.getMonth())

{

Console.WriteLine("Invalid month!");

}

Console.WriteLine("Calling method for"

+ " exterior mural");

interM.getMural();

Console.WriteLine("Calling method for"

+ " interior mural");

exterM.getMural();

if (interM.intnum > exterM.extnum)

obj.tempo = interM.intnum;

else

obj.tempo = exterM.extnum;

Console.WriteLine("The valid mural"

+ " codes are L, S, A, C and O \n ");

// let user

// give customer names along

// with mural codes.

int i;

InteriorMural[] intArr =

new InteriorMural[interM.intnum];

for (i = 0; i < interM.intnum; i++)

{

intArr[i] = new InteriorMural();

Console.WriteLine("Interior Mural "

+ (i + 1));

Console.WriteLine("Name: ");

intArr[i].name = Console.ReadLine();

Console.WriteLine("Code: ");

intArr[i].inmu = Console.ReadLine();

intArr[i].intnum = interM.intnum;

}

// let user

// give customer names along

// with mural codes.

ExteriorMural[] extArr =

new ExteriorMural[exterM.extnum];

for (i = 0; i < exterM.extnum; i++)

{

extArr[i] = new ExteriorMural();

Console.WriteLine("Exterior Mural "

+ (i + 1));

Console.WriteLine("Name: ");

extArr[i].name = Console.ReadLine();

Console.WriteLine("Code: ");

extArr[i].exmu = Console.ReadLine();

extArr[i].extnum = exterM.extnum;

}

obj.totrevenue = (int)interM.getRevenue

(obj.tempo) + exterM.getRevenue

(obj.tempo);

Console.WriteLine("Total revenue is: "
+ obj.totrevenue);

Console.WriteLine("\n");

int loop = 0;

do

{

Console.WriteLine("Enter category");

category = Console.ReadLine();

loop = 0;

// used to return names

// of specified category

switch (category)

{

case "L":

for (i = 0; i < obj.tempo;

i++)

{

if (intArr[i].inmu == "L")

Console.WriteLine

(intArr[i].ToString());

if (extArr[i].exmu == "L")

Console.WriteLine

(extArr[i].ToString());

}

break;

case "S":

for (i = 0; i < obj.tempo; i++)

{

if (intArr[i].inmu == "S")

Console.WriteLine

(intArr[i].ToString());

if (extArr[i].exmu == "S")

Console.WriteLine

(extArr[i].ToString());

}

break;

case "A":

for (i = 0; i < obj.tempo; i++)

{

if (intArr[i].inmu == "A")

Console.WriteLine

(intArr[i].ToString());

if (extArr[i].exmu == "A")

Console.WriteLine

(extArr[i].ToString());

}

break;

case "C":

for (i = 0; i < obj.tempo; i++)

{

if (intArr[i].inmu == "C")

Console.WriteLine

(intArr[i].ToString());

if (extArr[i].exmu == "C")

Console.WriteLine

(extArr[i].ToString());

}

break;

case "O":

for (i = 0; i < obj.tempo; i++)

{

if (intArr[i].inmu == "O")

Console.WriteLine

(intArr[i].ToString());

if (extArr[i].exmu == "O")

Console.WriteLine

(extArr[i].ToString());

}

break;

default:

Console.WriteLine(

"Invalid choice");

loop = 1;

break;

}

}

while (loop == 1);

Console.ReadLine();

}// End of Main

}// End of Program class

}// End of namespace
