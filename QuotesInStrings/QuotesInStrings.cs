using System;

//Declare two string variables: The "use" of quotations causes difficulties.

class QuotesInStrings
{
    static void Main()
    {
        string sentenceOne = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(sentenceOne);
        string sentenceTwo = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(sentenceTwo);
    }
}