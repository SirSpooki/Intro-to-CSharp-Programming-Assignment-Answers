// C# program to read the Patients.txt file 
// and write file content to the console into the tabular format
using System;
using System.IO;
using System.Globalization;
using static System.Console;

// class definition
class ReadPatientRecords
{
    // main
    static void Main()
    {
        // declare a delimiter to split the line into array of strings
        const char DELIM = ',';
        
        // declare file name
        const string FILENAME = "Patients.txt";
        
        // open file using FileStream
        FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        
        // pass file stream to the StreamReader
        StreamReader reader = new StreamReader(inFile);
        
        // write table headers to the console
        WriteLine("{0,-10}{1,-18}{2,10}", "IdNumber", "Name", "Balance");
        
        // read first line frpm the file
        string recordIn = reader.ReadLine();
        
        // loop to read the remaining lines of the file
        while(recordIn !=null)
        {
            // split the read line into array of string using the delimiter
            // each line of file contains IdNumber, Name, and Balance separated by a comma
            string[] fields = recordIn.Split(DELIM);
            
            // extract IdNumber, Name, and Balance from the array
            string IdNum = fields[0];
            string Name= fields[1];
            double Balance = Convert.ToDouble(fields[2]);
            
            // write IdNumber, Name, and Balance to the console in tabular format
            // balance is formatted in the US currency using the CultureInfo.GetCultureInfo
            WriteLine("{0,-10}{1,-18}{2,10}", IdNum, Name, Balance.ToString("C", CultureInfo.GetCultureInfo("en-US")));
            
            // read next line from the file
            recordIn = reader.ReadLine();
        }
        
        // close file streams
        reader.Close();
        inFile.Close();
   }
}
