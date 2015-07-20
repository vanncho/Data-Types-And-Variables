using System;

//Declare two integer variables a and b and assign them with 5 and 10 and after that 
//exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = 0;

        Console.WriteLine("First number, before exchange: {0}", a);
        Console.WriteLine("Second number, before exchange: {0}", b);

        c = a;
        a = b;
        b = c;

        Console.WriteLine("First number, after exchange: {0}", a);
        Console.WriteLine("Second number, after exchange: {0}", b);
    }    
}
