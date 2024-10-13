using System;
using System.IO;
namespace Directories
{
    class DirectoryInformation
    {
        static void Main(string[] args)
        {
            string dirName = string.Empty;
            string filName = string.Empty;
            string[] filenames;
            Console.Write("Enter a directory >> ");
            dirName = Console.ReadLine();
            while (dirName.Trim() != "end")
            {
                if (Directory.Exists(dirName))
                {
                    filenames = Directory.GetFiles(dirName);
                    Console.WriteLine("{0} contains the following files:", dirName);
                    foreach (string file in filenames)
                    {
                        Console.WriteLine("{0}", file);
                    }
                }
                else
                {
                    Console.WriteLine("Directory {0} does not exist ", dirName);
                }
                Console.Write("\nEnter another directory or type end to quit >> ");
                dirName = Console.ReadLine();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
