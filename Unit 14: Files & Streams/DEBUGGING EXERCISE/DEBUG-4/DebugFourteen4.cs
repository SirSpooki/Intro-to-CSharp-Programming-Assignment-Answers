// Reads and write serializable Student objects
// namespace
using System;
using static System.Console;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
// application namespace
namespace DebugApplication {
class DebugFourteen4 // C# class
{
  // Main() method
  static void Main(string[] args)
  {
    const int END = 999;
    const string FILENAME = "Students.ser";
    Student stu = new Student();
    FileStream outFile
        = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
    BinaryFormatter bFormatter = new BinaryFormatter();
    Write("Enter Student number or " + END + " to quit "); // asking user number
    stu.StuNum = Convert.ToInt32(ReadLine()); // reading number
    while (stu.StuNum != END) {
      Write("Enter last name "); // asking last name
      stu.Name = ReadLine(); // reading file
      Write("Enter gpa "); // asking gpa
      stu.Gpa = Convert.ToDouble(ReadLine()); // reading gpa
      bFormatter.Serialize(outFile, stu);
      Write(
          "Enter Student number or " + END + " to quit "); // asking user number
      stu.StuNum = Convert.ToInt32(ReadLine()); // reading number
    }
    outFile.Close();
    FileStream inFile
        = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
    WriteLine("\n{0,-5}{1,-12}{2,8}\n", "Num", "Name", "GPA"); // print details
    while (inFile.Position < inFile.Length) {
      stu = (Student) bFormatter.Deserialize(inFile);
      WriteLine(
          "{0,-5}{1,-12}{2,8}", stu.StuNum, stu.Name, stu.Gpa.ToString("F2"));
    }
    inFile.Close(); // close file
  }
}
[Serializable]
public class Student // student class
{
  private int stuNum;
  private string name;
  private double gpa;
  private const double MINGPA = 0.0;
  private const double MAXGPA = 4.0;
  public int StuNum
  {
    get { return stuNum; }
    set { stuNum = value; }
  }
  public string Name
  {
    get { return name; }
    set { name = value; }
  }
  public double Gpa
  {
    get { return gpa; }
    set
    {
      if (value >= MINGPA && value <= MAXGPA)
        gpa = value;
      else
        gpa = 0;
    }
  }
}
}
