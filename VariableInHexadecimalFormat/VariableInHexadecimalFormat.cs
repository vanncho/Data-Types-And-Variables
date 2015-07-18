using System;

//Declare an integer variable and assign it with the value 254 in hexadecimal format
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            int decNumber = 254;
            Console.WriteLine(Convert.ToString(decNumber, 16));
            int hexNumber = 0xFE;
            Console.WriteLine(hexNumber);
        }
    }
