using System;

//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate 
//data types and descriptive names.

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Ivanov";
        decimal accountBalance = 1324600900.2M;
        string bankName = "BANKOFIVAN";
        ulong cardNumberOne = 1234567891234567;
        ulong cardNumberTwo = 4561237893216549;
        ulong cardNumberThree = 8521479632587412;

        //Print information about bank account

        Console.WriteLine("Bank name: {0}", bankName);
        Console.Write("Holder name: ");
        Console.WriteLine("{0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Account ballnce: {0}", accountBalance);
        Console.WriteLine("Credit cards numbers: 1st-{0}, 2nd-{1}, 3rd-{2}", cardNumberOne, cardNumberTwo, cardNumberThree);
    }
}
