using System;
using static System.Console;
using System.Globalization;
static class AutomobileDemo3
{
   static void Main()
   {
     FinancedAutomobile[] ato = new FinancedAutomobile[4];
     int x;
     int Id;
     string mod;
     int year;
     double price;
     double financed;
     double Total = 0;
     double TotalFinanced = 0;
 
     for(x=0; x<4; ++x){
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
       Write("Enter Amount Financed >> ");
       financed = Convert.ToDouble(ReadLine());
       while(financed > price){
         
       }
 
       FinancedAutomobile atoX = new FinancedAutomobile();
       atoX.IdNumber = Id;
       atoX.Make = mod;
       atoX.Year = year;
       atoX.Price = price;
       atoX.AmtFinanced = financed;
       ato[x] = atoX;
     }
     Array.Sort(ato);
     WriteLine("Summary:");
     for(x=0; x<4; ++x){
       WriteLine(ato[x].ToString());
       Total += ato[x].Price;
       TotalFinanced += ato[x].AmtFinanced;
     }
     WriteLine("Total for all Automobiles is ${0:F2}\nTotal financed all Automobiles is ${1:F2}",Total,TotalFinanced);
   }
}
 
class Automobile : IComparable{
  public int IdNumber{get; set;}
  public string Make{get; set;}
  public int Year{get; set;}
  public double Price{get; set;}
 
  public override string ToString(){
    string temp = "Automobile "+IdNumber+" "+Year+" "+Make+" Price is "+Price.ToString("C", CultureInfo.GetCultureInfo("en-US"));
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
 
class FinancedAutomobile : Automobile{
  public double AmtFinanced{get; set;}
  public override string ToString(){
        string temp = "FinancedAutomobile "+IdNumber+" "+Year+" "+Make+" Price is "+Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))+" Amount financed "+ AmtFinanced.ToString("C", CultureInfo.GetCultureInfo("en-US"));
        return temp;
  }
  public double GetPaymentAmount(){
    double MontPayment = AmtFinanced/24;
    return MontPayment;
  }
}
