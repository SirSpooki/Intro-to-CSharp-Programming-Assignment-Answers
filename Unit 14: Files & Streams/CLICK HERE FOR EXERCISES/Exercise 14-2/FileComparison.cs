using System;

using static System.Console;

using System.IO;

class FileComparison

{

static void Main()

{

// code here

// Getting the file size of "Quote.txt"

FileInfo fileInfoQuoteTxt = new FileInfo("/root/sandbox/Quote.txt");

long lengthOfQuoteTxt = fileInfoQuoteTxt.Length;

// Getting the file size of "Quote.docx"

FileInfo fileInfoQuoteDocx = new FileInfo("/root/sandbox/Quote.docx");

long lengthOfQuoteDocx = fileInfoQuoteDocx.Length;

// Finding the percentage of the size of "Quote.txt" to the size of "Quote.docx"

double percentage = 100.0 * lengthOfQuoteTxt / lengthOfQuoteDocx;


// Printing the results

Console.WriteLine("The size of the Word file is " + lengthOfQuoteDocx);

Console.WriteLine("and the size of the Notepad file is " + lengthOfQuoteTxt);

Console.WriteLine("The Notepad file is " + percentage.ToString("0.00")+ " % of the size of the Word file");

}

}
