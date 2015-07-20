using System;

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//Use descriptive names. Print the data at the console.

class EmployeeData
{
    static void Main()
    {
        Console.Write("Enter employee first name:");
        string fname = Console.ReadLine();
        Console.Write("Enter employee last name:");
        string lname = Console.ReadLine();
        Console.Write("Enter employee's age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write(@"Enter you gender like ""m"" or ""f"":");
        char gender = char.Parse(Console.ReadLine());

        //Check gender is entered like "m" or "f".
        if (gender != 'm' && gender != 'f')
        {
            while (gender != 'm' && gender != 'f')
            {
                Console.Write(@"Error!Enter gender like ""m"" or ""f"":");
                Console.ReadLine();
            }
        }

        Console.Write("Enter ID number (e.g. 8306112507):");
        long idNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter unique number (e.g.27560000…27569999):");
        uint employeeNumber = uint.Parse(Console.ReadLine());
       

        //Check unique employee number is between 27560000 and 27569999.
        if (employeeNumber < 27560000 || employeeNumber > 27569999)
        {
            while(employeeNumber < 27560000 || employeeNumber > 27569999)
            {
                Console.Write("Error!Enter unique number like (e.g.27560000…27569999):");
                Console.ReadLine();
            }
        }

        string allData = fname + " " + lname + " " + age + " " + gender + " " + idNumber + " " + employeeNumber;
        Console.WriteLine(allData);
    }
}