using System;

//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.

class BooleanVariable
{
    static void Main()
    {
        bool isFemale = false;
        Console.Write("Enter you gender:");
        string enterGender = Console.ReadLine();
        string myGender = "male";
        if (myGender == enterGender)
        {
            Console.WriteLine("Your gender is male!");
        }
        else
        {
            Console.WriteLine("Your gender is female is: {0}", isFemale);
        }
    }
}