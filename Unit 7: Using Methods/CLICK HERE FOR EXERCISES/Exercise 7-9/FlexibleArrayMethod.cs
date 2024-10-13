using static System.Console;
using System.Linq;
public class FlexibleArrayMethod
{
     static int [] array1 = {5, 10 , 15};
     static int [] array2 = {2,4,6,8};
     static int [] array3 = {3};

   static void Main()
   {
     DisplayAndSum(array1);
     DisplayAndSum(array2);
     DisplayAndSum(array3);
   }
   public static void DisplayAndSum(int[] arr)
   {
     Write("\n\nArray Values Are >>");
      for(int x = 0; x < arr.Length; ++x)
        {
          Write("   " + arr[x]);
        }
     Write("\nSum of values is >>");
     Write("   " + arr.Sum());
   }
}
