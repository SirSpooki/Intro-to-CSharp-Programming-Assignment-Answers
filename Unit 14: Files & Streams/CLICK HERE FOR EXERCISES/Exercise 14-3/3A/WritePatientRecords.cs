using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;

//class Patient
class Patient
{
    // field variables
    public int balance;
    public string ID_number,name;
    
    //constructor
    public Patient(string id,string Name,int Balance)
    {
        ID_number=id;
        name=Name;
        balance=Balance;
    }
}
//class WritePatientRecords
class WritePatientRecords
{
    //Main()
    static void Main()
    {
        //List to add Patient class objects
        List<Patient> plist = new List<Patient>();
        //variables
        string ID_number,name;
        int balance;
        //print message
        Console.Write("Enter patient ID number or 999 to quit >> ");
        //read ID_number from user
        ID_number = Console.ReadLine();
        //Compare it with "999" if not equal then execute
        if(string.Compare(ID_number,"999")!=0)
        {
            //loop until user wants
            while(true)
            {
                //print message
                Console.Write("Enter last name >> ");
                //read name from user
                name = Console.ReadLine();
                //print message
                Console.Write("Enter balance  >> ");
                //Enter balance from user
                balance= Convert.ToInt32(Console.ReadLine());
                /*create objects of Patient class and add it into List 
                new Patient(ID_number,name,balance) is the new object by passing
                ID_number,name,balance*/
                plist.Add(new Patient(ID_number,name,balance));
                
                //print message
                Console.Write("Enter next patient ID number or 999 to quit >> ");
                //read ID_number from user
                ID_number = Console.ReadLine();
                //if ID_number=="999" then break from while loop
                if(string.Compare(ID_number,"999")==0)
                {
                    break;
                }
            }
            
            //writing into file using StreamWriter object
            using (StreamWriter sw = new StreamWriter("Patients.txt")) 
            {
                //loop through list to write all patients data in file
                foreach (Patient patient in plist) 
                {
                    //writing data in file by accessing corresponding field 
                    sw.WriteLine(patient.ID_number+","+patient.name+","
                    +patient.balance);
                }
            }
        }
        
    }
}
