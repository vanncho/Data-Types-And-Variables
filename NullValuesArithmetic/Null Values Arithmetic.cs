using System;

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

class Program
{
    static void Main()
    {
        //int nullValue = int.MinValue;
        //Console.WriteLine(@"The null value of ""integer"" is: {0}", nullValue);

        //double nullValueD = double.MinValue;
        //Console.WriteLine(@"The null value of ""double"" is: {0}", nullValueD);

        int nullValue = null;
        Console.WriteLine(nullValue);

        int newNullval = nullValue + 10;
        Console.WriteLine(newNullval);
    }
}
