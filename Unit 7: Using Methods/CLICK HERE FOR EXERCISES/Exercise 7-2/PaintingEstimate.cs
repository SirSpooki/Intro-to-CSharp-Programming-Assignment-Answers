using System;
using static System.Console;
using System.Globalization;
class PaintingEstimate
{
    static void Main()
    {
        WriteLine("Enter length of the room in feet >>");
        int length = Convert.ToInt32(ReadLine());

        WriteLine("Enter width of room in feet >>");
        int width = Convert.ToInt32(ReadLine());

        double A = ComputeCost(length, width);
        string AreaCostS = A.ToString("C", CultureInfo.GetCultureInfo("en-US"));

        WriteLine($"Cost of job for {length} X {width} foot room is {AreaCostS}");
    }

    public static double ComputeCost(int length, int width)     
    {
        int area;
        area = (2 * (length * 9)) + (2 * (width * 9));

        double areaCost = (double)area * 6;

        return areaCost ;
    }
}
