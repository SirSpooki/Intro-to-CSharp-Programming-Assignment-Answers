using System;
using static System.Console;
using System.Globalization;

class DebugTen04 {
  static void Main()
  {
    HotelRoom aRoom = new HotelRoom(234);
    SingleRoom aSingle = new SingleRoom(135);
    Suite aSuite = new Suite(453);
    WriteLine(aRoom.ToString());
    WriteLine(aSingle.ToString());
    WriteLine(aSuite.ToString()); // missing )
  }
}
class HotelRoom {
  public const double PREMIUM = 30.00;
  public const double STD_RATE = 89.99;
  private int roomNumber;
  protected double rate;
  public HotelRoom(int room) // roomNumber has integer data type
  {
    roomNumber = room;
    rate = STD_RATE; // changed STANDARD_RATE to rate
  }
  public int RoomNumber
  {
    get
    {
      return roomNumber; // changed roomNum to roomNumber
    }
  }
  public double Rate // changed rate to Rate and changed data type to double
  {
    get { return rate; }
  }
  public override string ToString()
  {
    string temp = GetType() + " Room " + RoomNumber
        + " Rate: " + Rate.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    return temp; // changed string to temp
  }
}
class SingleRoom : HotelRoom // replaced inheritsFrom to :
{
  public SingleRoom(int room)
      : base(room)
  {
    rate -= PREMIUM;
  }
}

class Suite : HotelRoom // replace inheritsFrom to :
{
  public Suite(int room)
      : base(room) // called base class constructor with base(room)
  {
    rate += PREMIUM;
  }
}
