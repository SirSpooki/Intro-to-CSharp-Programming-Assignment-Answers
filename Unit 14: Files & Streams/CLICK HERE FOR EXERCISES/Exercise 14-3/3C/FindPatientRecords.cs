using static System.Console;
using System.Globalization;

class FindPatientRecords
{
    static void Main()
    {
        int counter = 0;
        string line, patient_id;
        int flag = 0;
        // get input of patient id from user
        Write("Enter Patient ID number to find >> ");
        patient_id = ReadLine();
        // open the input file "Patients.txt"
        System.IO.StreamReader file = new System.IO.StreamReader(@"Patients.txt");
        WriteLine("{0,-15}{1,-10}{2,-10}", "ID Number", "Name", "Balance");
        // iterate till the end of file
        while ((line = file.ReadLine()) != null)
        {
            // split the line by ","
            string[] st = line.Split(',');
            // check if the id matched with the entered user patient id
            if (st[0].Equals(patient_id) == true)
            {
                // Print the details
                WriteLine("{0,-15}{1,-10}{2,-10}", patient_id, st[1], double.Parse(st[2]).ToString("C", CultureInfo.GetCultureInfo("en-US")));
                flag = 1;
                // end the loop
                break;
            }
            // increment the counter
            counter++;
        }
        // if not found
        if (flag == 0)
        {
            WriteLine("No records found for " + patient_id);
        }
        // close the file
        file.Close();
        ReadKey();
    }
}
