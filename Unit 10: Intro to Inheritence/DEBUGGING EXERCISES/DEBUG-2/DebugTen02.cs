// Street is an abstract class
// OneWayStreet and TwoWayStreet derive from Street
// On a OneWayStreet, it is illegal to make a U turn
// On a TwoWayStreet, a U Turn reverses the travelling direction

// Main program creates two Street child objects - one OneWay and one TwoWay
// and demonstrates what happens when you make a U Turn
// on a OneWayStreet and a TwoWayStreet

using static System.Console;

class DebugTen02 {

  static void Main()
  {

    OneWayStreet oak = new OneWayStreet("Oak Avenue", "east");

    TwoWayStreet elm = new TwoWayStreet("Elm Street", "south");

    // using accesors to get the name variable
    WriteLine("On " + oak.getName() + " " + oak.MakeUTurn());
    WriteLine("On " + oak.getName() + " " + oak.MakeUTurn());
    WriteLine("On " + elm.getName() + " " + elm.MakeUTurn());
    WriteLine("On " + elm.getName() + " " + elm.MakeUTurn());
  }
}
abstract class Street {
  protected string name;
  private string direction;

  // was missing comma between parameters
  public Street(string name, string travelDirection)
  {
    // improper assignment corrected
    this.name = name;
    direction = travelDirection;
  }

  // was missing proper accessor for name
  public string getName() { return name; }
  // was missing proper accessor for direction
  public string getDirection() { return direction; }
  // was missing proper mutator for direction
  public void setDirection(string direction) { this.direction = direction; }

  public abstract string MakeUTurn();
}

class OneWayStreet : Street {

  public OneWayStreet(string name, string direction)
      : base(name, direction)
  {
  }

  public override string MakeUTurn()
  {

    string temp
        = "U Turn is illegal! Was going and still going " + getDirection();

    return temp;
  }
}

class TwoWayStreet : Street {

  public TwoWayStreet(string name, string direction)
      : base(name, direction)
  {
  }

  public override string MakeUTurn()
  {

    string wasGoing = getDirection();

    string[] directions = { "north", "south", "east", "west" };

    string[] oppDirections = { "south", "north", "west", "east" };

    for (int x = 0; x < directions.Length; ++x) {

      // using accesor and mutator to access private instance variable direction
      if (getDirection().Equals(directions[x])) {

        setDirection(oppDirections[x]);

        x = directions.Length;
      }
    }

    string temp = "U Turn successful. Was going " + wasGoing + ". Now going "
        + getDirection();

    // return value was missing
    return temp;
  }
}
