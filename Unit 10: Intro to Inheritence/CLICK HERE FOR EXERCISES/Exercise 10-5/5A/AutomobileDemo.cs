using System;
using static System.Console;
using System.Globalization;
class AutomobileDemo
{
   static void Main()
   {
     Automobile[] ato = new Automobile[8];
     int x;
     int Id;
     string mod;
     int year;
     double price;
     double Total = 0;
 
     for(x=0; x<8; ++x){
       Write("Enter ID number >> ");
       Id = Convert.ToInt32(ReadLine());
       if(x!=0){
         for(int y = 0; y<x; ++y){
           if(Id == ato[y].IdNumber){
             Write("Enter ID number >> ");
             Id = Convert.ToInt32(ReadLine());
             break;
           }
         }
       }
       Write("Enter Make of Automobille >>");
       mod = ReadLine();
       Write("Enter Model Year >> ");
       year = Convert.ToInt32(ReadLine());
       Write("Enter Price of Automobile >> ");
       price = Convert.ToDouble(ReadLine());
 
       Automobile atoX = new Automobile();
       atoX.IdNumber = Id;
       atoX.Make = mod;
       atoX.Year = year;
       atoX.Price = price;
       ato[x] = atoX;
     }
     Array.Sort(ato);
     for(x=0; x<8; ++x){
       WriteLine(ato[x].ToString());
       Total += ato[x].Price;
     }
     WriteLine("Total for all Automobiles is ${0:F2}",Total);
   }
}
 
class Automobile : IComparable{
  public int IdNumber{get; set;}
  public string Make{get; set;}
  public int Year{get; set;}
  public double Price{get; set;}
 
  public override string ToString(){
    string temp = "Automobile "+IdNumber+" "+Year+" "+Make+" Price is $"+Price.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    return temp;
  }
 
  int IComparable.CompareTo(Object o){
    int ReturnVal;
    Automobile tempA = (Automobile)o;
    if(IdNumber > tempA.IdNumber){
      ReturnVal = 1;
    }
    else if(IdNumber < tempA.IdNumber){
      ReturnVal = -1;
    }
    else{
      ReturnVal = 0;
    }
    return ReturnVal;
  }
}
 
