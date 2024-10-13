using System;
using static System.Console;
using System.IO;

class DebugFourteen1 {
  static void Main()
  {
    string fileName;
    string directory;
    string path;

    // Directory.GetFiles return an array of file names. So, an array should be
    // declared correction was done here
    string[] files;
    int x;
    Write("Enter a directory: ");
    directory = ReadLine();

    // You have written Directory which was calling the Directory class.
    // Correction was done here
    if (Directory.Exists(directory)) {
      files = Directory.GetFiles(directory);

      // inside an if clause you check for a condition.
      // you have written files.Length=0 which is providing a value
      // correction was done here
      if (files.Length == 0)
        WriteLine("There are no files in " + directory);
      else {
        WriteLine(directory + " contains the following files");
        // files.length should always be checked as < and not <=
        // correction was done here
        for (x = 0; x < files.Length; x++)
          WriteLine(" " + files[x]);

        Write("\nEnter a file name: ");
        fileName = ReadLine();
        path = directory + "/" + fileName;
        if (File.Exists(path)) {
          WriteLine(
              " File exists and was created " + File.GetCreationTime(path));
          WriteLine("File was created " + File.GetCreationTime(fileName));
        } else
          WriteLine(
              fileName + " does not exist in the " + directory + " directory");
      }
    } else {
      WriteLine("Directory " + directory + " does not exist");
    }
  }
}
