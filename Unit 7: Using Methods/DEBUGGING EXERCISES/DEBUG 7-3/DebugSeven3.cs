using System; //namespace
using static System.Console;
class DebugSeven3 {
  static void Main() //Main method
    {
      int quantity;
      double price;
      quantity = GetQuantity();//method call to get quantity
      price = CalculatePrice(quantity);//method call to Calculate Price
      Console.WriteLine("Final price for {0} items is {1}.",quantity, price.ToString("c"));
    }

    private static int GetQuantity() //** added int return type
      {
        int quan;
        Console.Write("Enter number of items >> ");
        quan = Convert.ToInt32(Console.ReadLine());
        return quan; //** added this line
      }
    private static double CalculatePrice(int quantityOrdered) //** added double return type and made it static
      {
        double PRICE_PER_ITEM = 6.00;
        double price = 0;
        double discount = 0;
        int[] quanLimits = {0, 5, 10, 15}; //** added closing curly brace
        double[] limits = {0, 0.10, 0.14, 0.20}; //** added closing curly brace
        for(int x = limits.Length - 1; x >= 0; --x)
          if(quantityOrdered >= quanLimits[x]) //** changed to quanLimits & placed curly braces around following 2 statements
            {
              discount = limits[x];
              x = 0;
            }
        price = quantityOrdered * PRICE_PER_ITEM;
        price = price - price * discount;
        return price;
      }
      }
