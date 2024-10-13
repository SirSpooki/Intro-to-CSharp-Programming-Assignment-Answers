using static System.Console;
class CookieDemo2
{
   static void Main()
   {
     CookieOrder order = new CookieOrder();
      order.OrderNum = "101";
      order.Name = "Arthur";
      order.CookieType = "chocolate chip";
      order.Dozens = 2;
      WriteLine(order.ToString());

      SpecialCookieOrder order2 = new SpecialCookieOrder();
      order2.OrderNum = "101";
      order2.Name = "John";
      order2.CookieType = "peanut butter";
      order2.SpecialDescription = "gluten-free";
      order2.Dozens = 3;
      WriteLine(order2.ToString());

   }
}
class CookieOrder
{
  public string OrderNum{get; set;}
  public string Name{get; set;}
  public string CookieType{get; set;}
  public int dozens;
  public int Price{get; set;}

  public int Dozens
  {
      get
      {
        return dozens;
      }

      set
      {
        dozens = value;
        if(dozens <= 2)
          {
              Price = dozens * 15;
          }
        if(dozens > 2)
          {
            int num =0;
            num = 2 * 15;
            Price = (dozens - 2) * 13;
            Price += num;
          }
      }
  }

  public override string ToString()
  {
    return($"Order #{OrderNum}      {Name}\n   type: {CookieType}\n   {Dozens} dozen --- ${Price}");
  }
}

class SpecialCookieOrder : CookieOrder
{
  public string SpecialDescription{get;set;}

  new public int Dozens
  {
      get
      {
        return dozens;
      }

      set
      {
        dozens = value;
        if(dozens <= 2)
          {
              Price = dozens * 15;
          }
        else if(dozens > 2)
          {
            int num =0;
            num = 2 * 15;
            Price = (dozens - 2) * 13;
            Price += num;
          }
        if(Price > 40)
          {
            Price +=8;
          }
        else
        {
          Price += 10;
        }
      }
  }
  public override string ToString()
  {
    return($"Order #{OrderNum}      {Name}\n   type: {SpecialDescription} {CookieType}\n   {Dozens} dozen --- ${Price}");
  }
}

