// Interface IReversable defines behavior Reverse()
// Reverse is implemented differently for a Soldier and a PhoneCall
// Main program demonstrates an object of each type
using System;
using static System.Console;
using System.Globalization;

class DebugTen03 // C# class
{
  static void Main() // Main() method
  {
    Soldier giJoe = new Soldier(266143);
    PhoneCall aCall = new PhoneCall("212", "344-4188");
    WriteLine(giJoe.ToString());
    giJoe.Reverse();
    WriteLine(giJoe.ToString());
    giJoe.Reverse();
    WriteLine(giJoe.ToString());
    WriteLine(aCall.ToString());
    aCall.Reverse();
    WriteLine(aCall.ToString());
  }
}
public interface IReversable // Java Interface
{
  void Reverse(); // missing semicolon(;)
}
// C# class
class Soldier : IReversable {
  private int idNum;
  private string facing;
  public Soldier(int id) // public is wrongly typed
  {
    idNum = id; // changed idNum to id
    facing = "front";
  }

  // When a Soldier reverses if the Soldier was facing front, change to back
  // If the Soldier was facing back, change to front

  public void Reverse()
  {
    // checking facing
    if (facing == "front")
      facing = "back"; // when setting is front
    else
      facing = "front"; // else setting is back
  }

  public override string ToString() // changed data type
  {
    string temp = "Soldier #" + idNum + " is facing " + facing;
    return temp;
  }
}
// C# class PhoneCall
class PhoneCall : IReversable //= is wrongly used
{
  private string areaCode;
  private string number;
  private double charge;
  private string mode; // strin is wrong data type
  // Constructor
  public PhoneCall(string area, string num)
  {
    areaCode = area;
    number = num;
    charge = 0.25;
    mode = "regular"; // double quotes is missing
  }

  // When a phone call reverses, mode becomes collect and charge becomes 0
  public void Reverse()
  {
    mode = "collect";
    charge = 0;
  }
  // ToString() method
  public override string ToString()
  {
    string temp = "(" + areaCode + ") " + number + " Charge "
        + charge.ToString("C", CultureInfo.GetCultureInfo("en-US"))
        + " Call is " + mode;
    return temp;
  }
}
