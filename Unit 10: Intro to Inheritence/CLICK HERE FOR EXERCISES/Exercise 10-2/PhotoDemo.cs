using System;
using static System.Console;
using System.Globalization;
class PhotoDemo
{
   static void Main()
   {
      Photo P1 = new Photo();
         P1.Width = 8;
         P1.Height = 10;
      WriteLine(P1.ToString());

      Photo P2 = new Photo();
         P2.Width = 8;
         P2.Height = 9;
      WriteLine(P2.ToString());

      MattedPhoto M1 = new MattedPhoto();
        M1.Width = 10;
        M1.Height = 12;
        M1.Color = "white";
      WriteLine(M1.ToString());

      FramedPhoto F1 = new FramedPhoto();
        F1.Width = 8;
        F1.Height = 10;
        F1.Material = "silver";
        F1.Style = "modern";
        WriteLine(F1.ToString());
   }
}

class Photo
{
  public int width;
  public int height;
  protected double price;

  public int Width
  {
    get
    {
      return width;
    }
    set
    {
      width = value;
    }
  }

  public int Height
  {
    get
    {
      return height;
    }
    set
    {
      height = value;
      if(width == 8 && height == 10)
        {
          price = 3.99;
        }
      else if(width == 10 && height == 12)
        {
          price = 5.99;
        }
      else
        {
          price = 9.99;
        }
    }
  }

  public double Price
  {
    get{return Price;}
  }

 public override string ToString()
 {
   return(GetType()+"    "+width+" X "+height+"   Price: "+price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
 }

}
class MattedPhoto : Photo
{
  public string color;

  public string Color
  {
    get {return color;}
    set
    {
      color = value;
      price = price +10;
    }
  }
  public override string ToString()
 {
   return(GetType()+"    "+Color+" matting "+width+" X "+height+"   Price: "+price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
 }
  
}
class FramedPhoto : Photo
{
  public string material;
  public string Style{get; set;}
  
  public string Material
  {
    get {return material;}
    set
    {
      material = value;
      price = price +25;
    }
  }
  public override string ToString()
 {
   return(GetType()+"    "+Style+", "+ Material+" frame "+width+" X "+height+"   Price: "+price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
 }
}
